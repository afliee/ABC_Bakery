using ABC_Bakery.Models;
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
    public partial class CreateCategory : Form
    {
        private readonly CategoryService _categoryService;
        public CreateCategory()
        {
            InitializeComponent();
            _categoryService = CategoryService.GetInstance();
        }

        private void tbName__TextChanged(object sender, EventArgs e)
        {

        }

        public void ValidateInput()
        {
            string name = tbName.Texts;
            if (string.IsNullOrEmpty(name))
            {
                MessageBox.Show("Hãy nhập tên danh mục");
                return;
            }

            if (name.Length > 50)
            {
                MessageBox.Show("Tên danh mục không được quá 50 ký tự");
                return;
            }

            // check if all name is number
            if (name.All(char.IsDigit))
            {
                MessageBox.Show("Tên danh mục không được toàn số");
                return;
            }


        }

        private void LoadCategories()
        {
            dgProducts.Rows.Clear();

            List<Category> categories = _categoryService.GetAll();
            foreach (Category category in categories)
            {
                dgProducts.Rows.Add(category.Id, category.Name);
            }
        }

        private void CreateCategory_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbSearch__TextChanged(object sender, EventArgs e)
        {
            delayTextChanged.Stop();
            delayTextChanged.Start();
        }

        private void Search()
        {
            string keyword = tbSearch.Texts;
            if (string.IsNullOrEmpty(keyword))
            {
                LoadCategories();
                return;
            }

            dgProducts.Rows.Clear();

            List<Category> categories = _categoryService.GetAll();
            foreach (Category category in categories)
            {
                if (category.Name.ToLower().Contains(keyword.ToLower()))
                {
                    dgProducts.Rows.Add(category.Id, category.Name);
                }
            }
        }
        private void delayTextChanged_Tick(object sender, EventArgs e)
        {
            Search();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            ValidateInput();

            if (_categoryService.Create(tbName.Texts))
            {
                MessageBox.Show("Thêm danh mục thành công");
                LoadCategories();
                return;
            }

            MessageBox.Show("Thêm danh mục thất bại do trùng tên hoặc một lỗi gì đó!", "Thông báo");
        }
    }
}
