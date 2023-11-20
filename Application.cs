using ABC_Bakery.Helpers;
using ABC_Bakery.Models;
using ABC_Bakery.Repositories;
using ABC_Bakery.Forms;
using ABC_Bakery.Services;
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
        private OrderTCNoPayment orderTCNoPayment;
        private Forms.Order order;
        private CreateProduct createProdct;
        private DefaultForm defaultForm;

        public Application()
        {
            InitializeComponent();
            Init();
            MdiProperties();
        }

        private void MdiProperties()
        {
            Helpers.MDI.MdiProperties.SetBevel(this, false);
            //Controls.OfType<MdiClient>().FirstOrDefault().BackColor = ColorTranslator.FromHtml(Helpers.Constants.Colors.Primary);
        }

        private void Init()
        {
            var db = new DatabaseContext();
            RoleRepository roleRepository = new RoleRepository(db);
            roleRepository.Create(new Role { Name = "Cashier" });

            var cashierRole = roleRepository.FindByName("Cashier");
            if (cashierRole == null)
            {
                return;
            }
            UserRepository userRepository = new UserRepository(db);
            if (userRepository.FindByName("Cashier") != null)
            {
                return;
            }
            User user = new User
            {
                Name = "Cashier",
                Password = "cashier",
                RoleId = cashierRole.Id
            };

            userRepository.Create(user);
        }

        private void Application_Load(object sender, EventArgs e)
        {
            if (defaultForm == null)
            {
                defaultForm = new DefaultForm();
                defaultForm.MdiParent = this;
                defaultForm.Dock = DockStyle.Fill;
                defaultForm.FormClosed += DefaultForm_FormClosed;
                defaultForm.Show();
            }
            else
            {
                defaultForm.Activate();
            }

        }

        private void DefaultForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            defaultForm = null;
        }

        private void OrderNoPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderNoPayment = null;
        }
        private void OrderTCNoPayment_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderTCNoPayment = null;
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCreateOrder_Click(object sender, EventArgs e)
        {
            if (order == null)
            {
                order = new Forms.Order();
                order.MdiParent = this;
                order.Dock = DockStyle.Fill;
                order.FormClosed += Order_FormClosed;
                order.Show();
            }
            else
            {
                order.Activate();
            }
        }

        private void Order_FormClosed(object sender, FormClosedEventArgs e)
        {
            order = null;
        }

        private void btnOrderTCNoPayment_Click(object sender, EventArgs e)
        {
            if (orderTCNoPayment == null)
            {
                orderTCNoPayment = new OrderTCNoPayment();
                orderTCNoPayment.MdiParent = this;
                orderTCNoPayment.Dock = DockStyle.Fill;
                orderTCNoPayment.FormClosed += OrderTCNoPayment_FormClosed;
                orderTCNoPayment.Show();
            }
            else
            {
                orderTCNoPayment.Activate();
            }
        }

        private void btnCreateProduct_Click(object sender, EventArgs e)
        {
            if (createProdct == null)
            {
                createProdct = new CreateProduct();
                createProdct.MdiParent = this;
                createProdct.Dock = DockStyle.Fill;
                createProdct.FormClosed += CreateProdct_FormClosed;
                createProdct.Show();
            }
            else
            {
                createProdct.Activate();
            }
        }

        private void CreateProdct_FormClosed(object sender, FormClosedEventArgs e)
        {
            createProdct = null;
        }

        private void btnCreateCategory_Click(object sender, EventArgs e)
        {
            
        }
    }
}