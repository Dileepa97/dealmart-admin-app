using DealmartAdmin.Models;
using DealmartAdmin.Services;

namespace DealmartAdmin.Views.OrderForms
{
    public partial class OrderDetailsForm : BaseForm
    {
        private Order order;

        private readonly OrderService orderService = new OrderService();

        public OrderDetailsForm(Order order)
        {
            InitializeComponent();

            this.order = order;

            this.orderProducListView.View = View.Details;

            orderProducListView.Columns.Add("Product Name");
            orderProducListView.Columns.Add("Price (P)");
            orderProducListView.Columns.Add("Quantity (Q)");
            orderProducListView.Columns.Add("P * Q");

            LoadData();

            SizeLastColumn(orderProducListView);
        }

        private void LoadData()
        {
            buyerIdVal.Text = order.BuyerId;
            buyerAddVal.Text = order.Address;

            decimal totalPrice = 0;

            foreach (var orderItem in order.OrderItemDetails)
            {
                decimal itemPrice = orderItem.ProductDetails.Price;
                int itemQty = int.Parse(orderItem.Quantity);

                decimal itemTotal = itemPrice * itemQty;

                totalPrice += itemTotal;

                orderProducListView.Items.Add(new ListViewItem(
                        new string[]
                        {
                            orderItem.ProductDetails.Title,
                            itemPrice.ToString(),
                            itemQty.ToString(),
                            itemTotal.ToString()
                        }));
            }

            totalPriceVal.Text = totalPrice.ToString();
        }

        private void SizeLastColumn(System.Windows.Forms.ListView lv)
        {
            int x = lv.Width / 5 == 0 ? 1 : lv.Width / 5;
            lv.Columns[0].Width = x * 2;
            lv.Columns[1].Width = x;
            lv.Columns[2].Width = x;
            lv.Columns[3].Width = x;
        }

        private void OrderDetailsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private async void acceptOrderBtn_Click(object sender, EventArgs e)
        {
            acceptOrderBtn.Enabled = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                order.OrderAccepted = true;

                var res = await orderService.UpdateOrder(order);

                if (res)
                {
                    var viewOrdersForm = new ViewOrdersForm();

                    viewOrdersForm.StartPosition = FormStartPosition.Manual;
                    viewOrdersForm.Location = this.Location;
                    viewOrdersForm.Show();

                    this.Hide();
                }
            }

            acceptOrderBtn.Enabled = true;
        }
    }
}
