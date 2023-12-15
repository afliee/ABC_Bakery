using ABC_Bakery.Helpers;
using ABC_Bakery.Forms;
using ABC_Bakery.Models;
using ABC_Bakery.Repositories;
using ABC_Bakery.Services;

namespace ABC_Bakery
{
    public partial class Application : Form
    {
        private static readonly int ORDER_HEIGHT = 215;
        private static readonly int ORDER_ITEM_HEIGHT = 53;
        private readonly ReceiptService _receiptService;
        private Boolean IsOrderExpanded = true;
        private Boolean IsSideMenuExpanded = true;
        private Boolean IsReceiptExpanded = true;
        private Boolean IsFollowReceiptExpanded = true;
        private OrderNoPayment orderNoPayment;
        private OrderTCNoPayment orderTCNoPayment;
        private OrderDH orderDH;
        private Forms.Order order;
        private CreateProduct createProdct;
        private DefaultForm defaultForm;
        private Forms.Receipt receipt;
        private Receive receive;
        private PrePlaceOrder prePlaceOrder;
        private PlaceOrderTC placeOrderTC;
        private OrdersEquipment ordersEquipment;
        private OrdersDirect ordersDirect;
        private OrdersPrePlaced ordersPrePlaced;
        private CreateCategory createCategory;
        private PromotionForm promotionForm;
        public Application()
        {
            InitializeComponent();
            _receiptService = ReceiptService.GetInstance();
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
            _receiptService.InitToday();
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
            sidebarContainer.HorizontalScroll.Visible = true;
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

        private void OrderDH_FormClosed(object sender, FormClosedEventArgs e)
        {
            orderDH = null;
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
            if (createCategory == null || createCategory.IsDisposed)
            {
                createCategory = new CreateCategory();
                createCategory.Show();
            }
            else
            {
                // show the existing form
                createCategory.Activate();
            }
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            if (receipt == null)
            {
                receipt = new Forms.Receipt();
                receipt.MdiParent = this;
                receipt.Dock = DockStyle.Fill;
                receipt.FormClosed += Receipt_FormClosed;
                receipt.Show();
            }
            else
            {
                receipt.Activate();
            }
        }
        private void Receipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            receipt = null;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            if (receive == null)
            {
                receive = new Receive();
                receive.MdiParent = this;
                receive.Dock = DockStyle.Fill;
                receive.FormClosed += Receive_FormClosed;
                receive.Show();
            }
            else
            {
                receive.Activate();
            }
        }
        private void Receive_FormClosed(object sender, FormClosedEventArgs e)
        {
            receive = null;
        }

        private void btnCreateOrderNoPayment_Click(object sender, EventArgs e)
        {
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

        private void btnCreateDH_Click(object sender, EventArgs e)
        {
            if (prePlaceOrder == null)
            {
                prePlaceOrder = new PrePlaceOrder();
                prePlaceOrder.MdiParent = this;
                prePlaceOrder.Dock = DockStyle.Fill;
                prePlaceOrder.FormClosed += PrePlaceOrder_FormClosed;
                prePlaceOrder.Show();
            }
            else
            {
                prePlaceOrder.Activate();
            }
        }
        private void PrePlaceOrder_FormClosed(object sender, FormClosedEventArgs e)
        {
            prePlaceOrder = null;
        }

        private void ordersDH_Click(object sender, EventArgs e)
        {
            if (orderDH == null)
            {
                orderDH = new OrderDH();
                orderDH.MdiParent = this;
                orderDH.Dock = DockStyle.Fill;
                orderDH.FormClosed += OrderDH_FormClosed;
                orderDH.Show();
            }
            else
            {
                orderDH.Activate();
            }
        }

        private void btnCreatePlaceTCOrder_Click(object sender, EventArgs e)
        {
            if (placeOrderTC == null)
            {
                placeOrderTC = new PlaceOrderTC();
                placeOrderTC.MdiParent = this;
                placeOrderTC.Dock = DockStyle.Fill;
                placeOrderTC.FormClosed += PlaceOrderTC_FormClosed;
                placeOrderTC.Show();
            }
            else
            {
                placeOrderTC.Activate();
            }
        }

        private void PlaceOrderTC_FormClosed(object sender, FormClosedEventArgs e)
        {
            placeOrderTC = null;
        }

        private void orders_equip_Click(object sender, EventArgs e)
        {
            if (ordersEquipment == null)
            {
                ordersEquipment = new OrdersEquipment();
                ordersEquipment.MdiParent = this;
                ordersEquipment.Dock = DockStyle.Fill;
                ordersEquipment.FormClosed += OrdersEquipment_FormClosed;
                ordersEquipment.Show();
            }
            else
            {
                ordersEquipment.Activate();
            }
        }

        private void OrdersEquipment_FormClosed(object sender, FormClosedEventArgs e)
        {
            ordersEquipment = null;
        }

        private void btnOrderDirect_Click(object sender, EventArgs e)
        {
            if (ordersDirect == null)
            {
                ordersDirect = new OrdersDirect();
                ordersDirect.MdiParent = this;
                ordersDirect.Dock = DockStyle.Fill;
                ordersDirect.FormClosed += OrdersDirect_FormClosed;
                ordersDirect.Show();
            }
            else
            {
                ordersDirect.Activate();
            }
        }

        private void OrdersDirect_FormClosed(object sender, FormClosedEventArgs e)
        {
            ordersDirect = null;
        }

        private void btnOrdersPrePlaced_Click(object sender, EventArgs e)
        {
            if (ordersPrePlaced == null)
            {
                ordersPrePlaced = new OrdersPrePlaced();
                ordersPrePlaced.MdiParent = this;
                ordersPrePlaced.Dock = DockStyle.Fill;
                ordersPrePlaced.FormClosed += OrdersPrePlaced_FormClosed;
                ordersPrePlaced.Show();
            }
            else
            {
                ordersPrePlaced.Activate();
            }
        }

        private void OrdersPrePlaced_FormClosed(object sender, FormClosedEventArgs e)
        {
            ordersPrePlaced = null;
        }

        private void btnCreatePromotion_Click(object sender, EventArgs e)
        {
            if (promotionForm == null)
            {
                promotionForm = new PromotionForm();
                promotionForm.MdiParent = this;
                promotionForm.Dock = DockStyle.Fill;
                promotionForm.FormClosed += PromotionForm_FormClosed;
                promotionForm.Show();
            }
            else
            {
                promotionForm.Activate();
            }
        }

        private void PromotionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            promotionForm = null;
        }
    }

}