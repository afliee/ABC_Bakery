using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace ABC_Bakery.Forms
{
    public partial class OrderTCNoPayment : Form
    {
        public OrderTCNoPayment()
        {
            InitializeComponent();
            //this.ControlBox = false;
            Init();
        }

        private void Init()
        {
            stt.DefaultCellStyle.BackColor = Color.White;
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderTCNoPayment_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
