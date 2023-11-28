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
    public partial class PrePlaceOrder : Form
    {
        public PrePlaceOrder()
        {
            InitializeComponent();
        }

        private void PrePlaceOrder_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
        }
    }
}
