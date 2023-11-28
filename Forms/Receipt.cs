using ABC_Bakery.Helpers.Utils;
using ABC_Bakery.Models.Constants;
using ABC_Bakery.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessageBox = ABC_Bakery.Helpers.UI.MessageBox;
namespace ABC_Bakery.Forms
{
    public partial class Receipt : Form
    {
        private ReceiptService _receiptService;
        private OrderService _orderService;
        public Receipt()
        {
            InitializeComponent();
            _receiptService = ReceiptService.GetInstance();
            _orderService = OrderService.GetInstance();
        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            datetime.Value = DateTime.Now;
            Load_Receipts();
        }
        private void Load_Receipts()
        {
            DateTime date = datetime.Value;
            Models.Receipt receipt = _receiptService.FindByCreatedDayAndReceiptType(date, (int)ReceiptType.Import);

            if (receipt == null)
            {
                MessageBox.Show("Không tìm thấy hóa đơn");
                return;
            }

            int index = 0;
            dgOrders.Rows.Clear();
            MessageBox.Show(receipt.Orders.Count.ToString());
            foreach (var order in receipt.Orders)
            {
                dgOrders.Rows.Add(index + 1, order.Id, order.CreatedAt, new TextCurrency
                {
                    CultureInfor = TextCurrency.VIETNAM,
                    Value = order.Price,
                    Format = TextCurrency.NO_DECIMAL
                }, order.Note);
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
