using DealmartAdmin.Models;
using DealmartAdmin.Services;

namespace DealmartAdmin.Views.OrderForms
{
    public partial class ViewOrdersForm : BaseForm
    {
        private readonly OrderService orderService = new OrderService();

        private List<Order> orders;

        public ViewOrdersForm()
        {
            InitializeComponent();

            this.orderListView.View = View.Details;

            orderListView.Columns.Add("Order Id");
            orderListView.Columns.Add("Buyer Id");
            orderListView.Columns.Add("Buyer Address");
            orderListView.Columns.Add("Total Order Price");

            LoadDataAsync();

        }

        private async void LoadDataAsync()
        {
            var orderList = await orderService.GetOrders();

            this.orders = orderList;

            if (orderList != null)
            {
                foreach (var item in orderList)
                {
                    if (!item.OrderAccepted)
                    {
                        decimal totalPrice = 0;

                        foreach (var orderItem in item.OrderItemDetails)
                        {
                            decimal itemPrice = orderItem.ProductDetails.Price;
                            int itemQty = int.Parse(orderItem.Quantity);

                            decimal itemTotal = itemPrice * itemQty;

                            totalPrice += itemTotal;
                        }


                        orderListView.Items.Add(new ListViewItem(
                            new string[]
                            {
                            item.Id.ToString(),
                            item.BuyerId,
                            item.Address,
                            totalPrice.ToString()
                            }));
                    }

                }
            }
        }

        private void ViewOrdersForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void orderListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (orderListView.SelectedItems.Count == 1)
            {
                viewBtn.Enabled = true;
            }
            else
            {
                viewBtn.Enabled = false;
            }
        }

        private void SizeLastColumn(System.Windows.Forms.ListView lv)
        {
            int x = lv.Width / 7 == 0 ? 1 : lv.Width / 7;
            lv.Columns[0].Width = 0;
            lv.Columns[1].Width = x * 2;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = x * 2;
        }

        private void ViewOrdersForm_Load(object sender, EventArgs e)
        {
            SizeLastColumn(orderListView);
        }

        private void viewBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = orderListView.SelectedItems[0];
            string id = selectedItem.SubItems[0].Text;

            Order order = orders.Find(o => o.Id == id);

            var orderDetailsForm = new OrderDetailsForm(order);

            orderDetailsForm.StartPosition = FormStartPosition.Manual;
            orderDetailsForm.Location = this.Location;
            orderDetailsForm.Show();

            this.Hide();
        }
    }
}
