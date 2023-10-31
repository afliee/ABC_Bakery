using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Bakery.Forms
{
    public partial class OrderNoPayment : Form
    {
        public OrderNoPayment()
        {
            InitializeComponent();
        }

        private void OrderNoPayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Init();
        }

        private void Init()
        {
            // init header for data grid view
            string[] headers =
            {
                "STT",
                "Mã Biên Nhận",
                "Ngày đặt",
                "Tổng tiền",
                "Ghi chú"
            };


        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
