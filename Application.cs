using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositorys;
using ABC_Bakery.Forms;

namespace ABC_Bakery
{
    public partial class Application : Form
    {
        private static readonly int ORDER_HEIGHT = 245;
        private static readonly int ORDER_ITEM_HEIGHT = 53;
        private Boolean IsOrderExpanded = false;
        private Boolean IsSideMenuExpanded = true;
        public Application()
        {
            InitializeComponent();
            Init();
            toggle_Order_Click();
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
            Forms.OrderNoPayment orderNoPayment = new Forms.OrderNoPayment();
            orderNoPayment.Show();
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
                if (sidebarContainer.Width <= 70)
                {
                    sidebarTransition.Stop();
                    IsSideMenuExpanded = false;
                }
            }
            else
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 286)
                {
                    sidebarTransition.Stop();
                    IsSideMenuExpanded = true;
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
    }
}