using ABC_Bakery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;

namespace ABC_Bakery.Forms
{
    public partial class PromotionForm : Form
    {
        private const string TIME_FORMAT = "dddd , dd MMMM yyyy";
        private const string DATE_FORMAT = "dd/MM/yyyy";
        private readonly PromotionService _promotionService = PromotionService.GetInstance();
        public PromotionForm()
        {
            InitializeComponent();
        }

        private void LoadPromotions()
        {
            var promotions = _promotionService.GetAll();
            dgPromotions.Rows.Clear();

            if (promotions.Count == 0)
            {
                return;
            }

            foreach (var promotion in promotions)
            {
                dgPromotions.Rows.Add(
                    promotion.Id,
                    promotion.Name,
                    promotion.Code,
                    promotion.Ratio,
                    promotion.ExpiredAt.ToString(DATE_FORMAT),
                    promotion.IsActived
                );
            }
        }

        private void PromotionForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            dt_date.MinDate = DateTime.Now;
            table_infor.Visible = false;
            LoadPromotions();
        }

        private void tbName_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(tbName, "Tên khuyến mãi không được để trống và phải có ít nhất 5 ký tự");
        }

        private void tbName__TextChanged(object sender, EventArgs e)
        {
            // name valid when not empty and min length is 5 and max length is 50

            string name = tbName.Texts;
            bool valid = !string.IsNullOrEmpty(name) && name.Length >= 5 && name.Length <= 50;
            if (valid)
            {
                tbName.BorderColor = Color.Green;
                tbName.ForeColor = Color.Green;
            }
            else
            {
                tbName.BorderColor = Color.Red;
                tbName.ForeColor = Color.Red;
            }
        }

        private void tbRatio__TextChanged(object sender, EventArgs e)
        {
            // ratio valid when not empty and min length is 1 and max length is 3, and all character is digit and ratio is between 1 and 100
            string ratio = tbRatio.Texts;
            bool valid = !string.IsNullOrEmpty(ratio) && ratio.Length >= 1 && ratio.Length <= 3 && ratio.All(char.IsDigit) && int.Parse(ratio) >= 1 && int.Parse(ratio) <= 100;

            if (valid)
            {
                tbRatio.BorderColor = Color.Green;
                tbRatio.ForeColor = Color.Green;
            }
            else
            {
                tbRatio.BorderColor = Color.Red;
                tbRatio.ForeColor = Color.Red;
            }
        }

        private void tbRatio_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(tbRatio, "Tỉ lệ phải là số nguyên dương và nằm trong khoảng từ 1 đến 100");
        }

        private void tbCode__TextChanged(object sender, EventArgs e)
        {
            // name valid when not empty and min length is 5 and max length is 10, and all character is upper
            string name = tbCode.Texts;
            bool valid = !string.IsNullOrEmpty(name) && name.Length >= 5 && name.Length <= 10 && name.All(char.IsUpper);

            if (valid)
            {
                tbCode.BorderColor = Color.Green;
                tbCode.ForeColor = Color.Green;
            }
            else
            {
                tbCode.BorderColor = Color.Red;
                tbCode.ForeColor = Color.Red;
            }
        }

        private void tbCode_MouseMove(object sender, MouseEventArgs e)
        {
            tooltip.SetToolTip(tbCode, "Mã khuyến mãi tất cả nên được viết hoa");
        }

        private void PromotionForm_Shown(object sender, EventArgs e)
        {
            table_infor.Visible = true;
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            delayTextChanged.Start();
        }

        private void delayTextChanged_Tick(object sender, EventArgs e)
        {

            delayTextChanged.Stop();
            string name = tbSearch.Texts;
            if (string.IsNullOrEmpty(name))
            {
                LoadPromotions();
                return;
            }

            var promotions = _promotionService
                .GetAll()
                .Where(p => p.Name
                            .ToLower()
                            .Contains(name.ToLower()) ||
                            p.Code
                            .ToLower()
                            .Contains(name.ToLower())
                )
                .ToList();
            dgPromotions.Rows.Clear();

            if (promotions.Count == 0)
            {
                return;
            }

            foreach (var promotion in promotions)
            {
                dgPromotions.Rows.Add(
                    promotion.Id,
                    promotion.Name,
                    promotion.Code,
                    promotion.Ratio,
                    promotion.ExpiredAt.ToString(DATE_FORMAT),
                    promotion.IsActived
                );
            }
        }

        private bool All_Input_Valid()
        {
            // check all input is valid when all is green
            return tbName.BorderColor == Color.Green && tbCode.BorderColor == Color.Green && tbRatio.BorderColor == Color.Green;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!All_Input_Valid())
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string name = tbName.Texts;
            string code = tbCode.Texts;
            int ratio = int.Parse(tbRatio.Texts);
            DateTime expiredAt = dt_date.Value;

            bool rs = _promotionService.Create(name, code, ratio, expiredAt);
            if (rs)
            {
                MessageBox.Show("Thêm khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Input();
                LoadPromotions();
            }
            else
            {
                MessageBox.Show("Thêm khuyến mãi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear_Input()
        {
            tbName.ClearText();
            tbCode.ClearText();
            tbRatio.ClearText();
            dt_date.Value = DateTime.Now;
        }

        private void dgPromotions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // check if click on checkbox column
            if (e.ColumnIndex == 5)
            {
                int id = int.Parse(dgPromotions.Rows[e.RowIndex].Cells["stt"].Value.ToString());
                bool isActived = bool.Parse(dgPromotions.Rows[e.RowIndex].Cells["status"].Value.ToString());
                bool rs = _promotionService.UpdateStatus(id, !isActived);
                if (rs)
                {
                    MessageBox.Show("Cập nhật trạng thái khuyến mãi thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadPromotions();
                }
                else
                {
                    MessageBox.Show("Cập nhật trạng thái khuyến mãi thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
