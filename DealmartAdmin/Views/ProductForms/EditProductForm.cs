using DealmartAdmin.Models;
using DealmartAdmin.Services;

namespace DealmartAdmin.Views.ProductForms
{
    public partial class EditProductForm : BaseForm
    {
        private readonly ProductService productService = new ProductService();

        private readonly string id;
        private Product productSelected;

        private string image = null;

        public EditProductForm(string id)
        {
            InitializeComponent();
            this.id = id;

            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            var product = await productService.GetProduct(id);

            if (product != null)
            {
                this.productSelected = product;

                productNameText.Text = product.Title;
                prodcutPriceNum.Value = product.Price;
                availableQtyNum.Value = product.Quantity;
                productDescriptionText.Text = product.Description;
                productCategoryText.Text = product.Category;
                this.image = product.Image;

                string base64String = product.Image;
                byte[] imageBytes = Convert.FromBase64String(base64String);

                MemoryStream ms = new MemoryStream(imageBytes);

                Image productImage = Image.FromStream(ms);
                productImageBox.Image = productImage;
                productImageBox.Visible = true;
            }
        }

        private async void deleteProductBtn_Click(object sender, EventArgs e)
        {
            saveProductBtn.Enabled = false;
            deleteProductBtn.Enabled = false;

            DialogResult dialogResult = MessageBox.Show("Are you sure?", "Confirmation", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                var res = await productService.DeleteProduct(this.productSelected.Id);

                if (res)
                {
                    var viewProductForm = new ViewProductsForm();

                    viewProductForm.StartPosition = FormStartPosition.Manual;
                    viewProductForm.Location = this.Location;
                    viewProductForm.Show();

                    this.Hide();
                }
            }

            saveProductBtn.Enabled = true;
            deleteProductBtn.Enabled = true;
        }

        private void EditProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productImageEditBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select an image file";
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.bmp) | *.jpg; *.jpeg; *.png; *.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFileName = openFileDialog.FileName;

                PictureBox productPictureBox = this.productImageBox;
                productPictureBox.Image = new Bitmap(selectedFileName);
                productPictureBox.Visible = true;

                var selectedImage = Image.FromFile(selectedFileName);

                MemoryStream ms = new MemoryStream();

                selectedImage.Save(ms, selectedImage.RawFormat);
                byte[] imageBytes = ms.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);

                this.image = base64String;
            }
        }

        private async void saveProductBtn_Click(object sender, EventArgs e)
        {
            if (productNameText.Text == "")
            {
                MessageBox.Show("Product Name is required", "Invalid", MessageBoxButtons.OK);
                return;
            }
            else if (productDescriptionText.Text == "")
            {
                MessageBox.Show("Product Description is required", "Invalid", MessageBoxButtons.OK);
                return;
            }
            else if (productCategoryText.Text == "")
            {
                MessageBox.Show("Product Category is required", "Invalid", MessageBoxButtons.OK);
                return;
            }
            else if (prodcutPriceNum.Value <= 0)
            {
                MessageBox.Show("Product Price value is invalid", "Invalid", MessageBoxButtons.OK);
                return;
            }
            else if (availableQtyNum.Value <= 0)
            {
                MessageBox.Show("Product Quantity value is invalid", "Invalid", MessageBoxButtons.OK);
                return;
            }
            else if (this.image == null)
            {
                MessageBox.Show("Product Image is required", "Invalid", MessageBoxButtons.OK);
                return;
            }

            saveProductBtn.Enabled = false;
            deleteProductBtn.Enabled = false;

            var product = new Product
            {
                Id = id,
                Title = productNameText.Text,
                Description = productDescriptionText.Text,
                Quantity = (int)availableQtyNum.Value,
                Sold = productSelected.Sold,
                Category = productCategoryText.Text,
                Price = prodcutPriceNum.Value,
                Image = this.image
            };

            var res = await productService.UpdateProduct(product);

            if (res)
            {
                var viewProductForm = new ViewProductsForm();

                viewProductForm.StartPosition = FormStartPosition.Manual;
                viewProductForm.Location = this.Location;
                viewProductForm.Show();

                this.Hide();
            }
            else
            {
                saveProductBtn.Enabled = true;
                deleteProductBtn.Enabled = true;
            }
        }
    }
}
