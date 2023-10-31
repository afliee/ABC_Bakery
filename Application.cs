using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositorys;
using ABC_Bakery.Forms;

namespace ABC_Bakery
{
    public partial class Application : Form
    {
        private static readonly int ORDER_HEIGHT = 215;
        private static readonly int ORDER_ITEM_HEIGHT = 53;
        private Boolean IsOrderExpanded = true;
        private Boolean IsSideMenuExpanded = true;
        private Boolean IsReceiptExpanded = true;
        private Boolean IsFollowReceiptExpanded = true;
        private OrderNoPayment orderNoPayment;
        public Application()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            var db = new DatabaseContext();
            RoleRepository roleRepository = new RoleRepository(db);

            //roleRepository.Create(new Role { Name = "Admin" });
        }

        private void Application_Load(object sender, EventArgs e)
        {
            //Forms.Order order = new Forms.Order();
            //order.Show();
            if (orderNoPayment == null)
            {
                orderNoPayment = new OrderNoPayment();
                orderNoPayment.MdiParent = this;
                orderNoPayment.Dock = DockStyle.Fill;
                orderNoPayment.FormClosed += OrderNoPayment_FormClosed;
                orderNoPayment.Show();
            }
            else
            {
                orderNoPayment.Activate();
            }
        }

        private void OrderNoPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderNoPayment = null;
        }

        private void orderTransition_Tick(object sender, EventArgs e)
        {
            toggle_Order_Click();
        }

        private void toggle_Order_Click()
        {
            if (!IsOrderExpanded)
            {
                orderContainer.Height += 10;
                if (orderContainer.Height >= ORDER_HEIGHT)
                {
                    orderTransition.Stop();
                    IsOrderExpanded = true;
                }
            }
            else
            {
                orderContainer.Height -= 10;
                if (orderContainer.Height <= ORDER_ITEM_HEIGHT + 5)
                {
                    orderTransition.Stop();
                    IsOrderExpanded = false;
                }
            }
        }

        private void orders_Click(object sender, EventArgs e)
        {
            orderTransition.Start();
        }

        private void toggle_SideMenu_Click()
        {
            if (IsSideMenuExpanded)
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 65)
                {
                    sidebarTransition.Stop();
                    IsSideMenuExpanded = false;


                    orderContainer.Width = sidebarContainer.Width;
                    receiptContainer.Width = sidebarContainer.Width;
                    followReceiptContainer.Width = sidebarContainer.Width;

                    pnLogo.Visible = false;
                }
            }
            else
            {
                sidebarContainer.Width += 5;
                if (sidebarContainer.Width >= 286)
                {
                    sidebarTransition.Stop();
                    IsSideMenuExpanded = true;

                    orderContainer.Width = sidebarContainer.Width;
                    receiptContainer.Width = sidebarContainer.Width;
                    followReceiptContainer.Width = sidebarContainer.Width;

                    pnLogo.Visible = true;
                }
            }
        }

        private void menubar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            toggle_SideMenu_Click();
        }

        private void receiptTransition_Tick(object sender, EventArgs e)
        {
            if (!IsReceiptExpanded)
            {
                receiptContainer.Height += 10;
                if (receiptContainer.Height >= 163)
                {
                    receiptTransition.Stop();
                    IsReceiptExpanded = true;
                }
            }
            else
            {
                receiptContainer.Height -= 10;
                if (receiptContainer.Height <= 53)
                {
                    receiptTransition.Stop();
                    IsReceiptExpanded = false;
                }
            }
        }

        private void receipts_Click(object sender, EventArgs e)
        {
            receiptTransition.Start();
        }

        private void followReceiptTransition_Tick(object sender, EventArgs e)
        {
            if (!IsFollowReceiptExpanded)
            {
                followReceiptContainer.Height += 10;
                if (followReceiptContainer.Height >= 221)
                {
                    followReceiptTransition.Stop();
                    IsFollowReceiptExpanded = true;
                }
            }
            else
            {
                followReceiptContainer.Height -= 10;
                if (followReceiptContainer.Height <= 53)
                {
                    followReceiptTransition.Stop();
                    IsFollowReceiptExpanded = false;
                }
            }
        }

        private void receiptFollow_Click(object sender, EventArgs e)
        {
            followReceiptTransition.Start();
        }
    }
}