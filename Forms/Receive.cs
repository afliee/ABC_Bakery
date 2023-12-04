using ABC_Bakery.Helpers.Utils;
using ABC_Bakery.Models.Constants;
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
    public partial class Receive : Form
    {
        private ReceiptService _receiptService;
        private OrderService _orderService;
        private OrderDetailService _orderDetailService;
        private int _rowIndex = -1;
        public Receive()
        {
            InitializeComponent();
            _receiptService = ReceiptService.GetInstance();
            _orderService = OrderService.GetInstance();
            _orderDetailService = OrderDetailService.GetInstance();
        }

        private void Load_Receipt()
        {
            DateTime date = DateTime.Now;
            List<Models.Receipt> receipts = _receiptService.FindAllByReceiptType((int)ReceiptType.Import);
            if (receipts.Count != 0)
            {
                int i = 0;
                foreach (var receipt in receipts)
                {
                    var orders = _orderService.FindAllByReceiptId(receipt.Id);
                    double total = 0;
                    int orderCompleted = 0;
                    if (orders.Count != 0)
                    {
                        orders.ToList().ForEach(o =>
                        {
                            if (o.Status == (int)OrderStatus.Completed)
                                orderCompleted++;
                            total += o.Price;
                        });
                    }

                    dgReceipts.Rows.Add(
                        i + 1,
                        $"{Models.Receipt.Prefix}_{receipt.Id}",
                        receipt.CreatedAt.ToString("dd/MM/yyyy"),
                        orderCompleted,
                        new TextCurrency
                        {
                            CultureInfor = TextCurrency.VIETNAM,
                            Value = total,
                            Format = TextCurrency.NO_DECIMAL
                        }.ToString(),
                        receipt.Id
                    );
                    i++;
                }
            }
        }

        private void dgReceipts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _rowIndex = e.RowIndex;
            var receiptId = dgReceipts.Rows[_rowIndex].Cells[5].Value;
            if (receiptId != null)
            {
                var orders = _orderService.FindAllByReceiptId((int)receiptId);
                if (orders.Count != 0)
                {
                    dgReceiptDetail.Rows.Clear();
                    foreach (var order in orders)
                    {
                        int productQuantity = _orderDetailService.CountProductByOrderId(order.Id);
                        dgReceiptDetail.Rows.Add(
                            order.Name,
                            productQuantity,
                            new TextCurrency
                            {
                                CultureInfor = TextCurrency.VIETNAM,
                                Value = order.Price,
                                Format = TextCurrency.NO_DECIMAL
                            }.ToString()
                        );
                    }
                }
                else
                {
                    dgReceiptDetail.Rows.Clear();
                    dgReceiptDetail.Rows.Add(
                        "Không có dữ liệu",
                        0,
                        new TextCurrency
                        {
                            CultureInfor = TextCurrency.VIETNAM,
                            Value = 0,
                            Format = TextCurrency.NO_DECIMAL
                        }.ToString()
                    );
                }
            }
        }

        private void Receive_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            Load_Receipt();
        }
    }
}
