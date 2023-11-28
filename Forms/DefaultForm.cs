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
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();
            // unvisible util shown
            this.Visible = false;
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lbTimer.Text = DateTime.Now.ToString("dddd , dd MMMM, yyyy");
            lbTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
    }
}
