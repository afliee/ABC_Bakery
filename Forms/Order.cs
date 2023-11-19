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
    public partial class Order : Form
    {
        public Order()
        {
            //this.BackgroundImage = Properties.Resources.Bg;
            InitializeComponent();
            //this.ControlBox = false;
            //panel2.BackColor = Color.Transparent;

        }

        private void Order_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTime_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
