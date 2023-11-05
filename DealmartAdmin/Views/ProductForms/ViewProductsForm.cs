using DealmartAdmin.Services;

namespace DealmartAdmin.Views.ProductForms
{
    public partial class ViewProductsForm : BaseForm
    {

        private readonly ProductService productService = new ProductService();

        public ViewProductsForm()
        {
            InitializeComponent();

            this.productListView.View = View.Details;

            productListView.Columns.Add("Product Id");
            productListView.Columns.Add("Product Name");
            productListView.Columns.Add("Product Category");
            productListView.Columns.Add("Product Price");
            productListView.Columns.Add("Is Available");
            productListView.Columns.Add("Available Quantity");

            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var productList = await productService.GetProducts();

            if (productList != null)
            {
                foreach (var item in productList)
                {
                    bool isAvailable = false;
                    int availableQuantity = item.Quantity - item.Sold;

                    if (availableQuantity > 0)
                    {
                        isAvailable = true;
                    }

                    productListView.Items.Add(new ListViewItem(
                        new string[] {
                            item.Id.ToString(),
                            item.Title, item.Category,
                            item.Price.ToString(),
                            isAvailable.ToString(),
                            availableQuantity.ToString()
                        }));
                }
            }
        }


        private void ViewProductsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (productListView.SelectedItems.Count == 1)
            {
                editBtn.Enabled = true;
            }
            else
            {
                editBtn.Enabled = false;
            }
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            ListViewItem selectedItem = productListView.SelectedItems[0];
            string id = selectedItem.SubItems[0].Text;

            var editProductForm = new EditProductForm(id);

            editProductForm.StartPosition = FormStartPosition.Manual;
            editProductForm.Location = this.Location;
            editProductForm.Show();

            this.Hide();
        }

        private void ViewProductsForm_Load(object sender, EventArgs e)
        {
            SizeLastColumn(productListView);
        }

        private void SizeLastColumn(System.Windows.Forms.ListView lv)
        {
            int x = lv.Width / 12 == 0 ? 1 : lv.Width / 12;
            lv.Columns[0].Width = 0;
            lv.Columns[1].Width = x * 3;
            lv.Columns[2].Width = x * 3;
            lv.Columns[3].Width = x * 2;
            lv.Columns[4].Width = x * 2;
            lv.Columns[5].Width = x * 2;
        }
    }
}
