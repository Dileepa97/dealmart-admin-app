using DealmartAdmin.DTOs;
using DealmartAdmin.Services;

namespace DealmartAdmin.Views.ProductForms
{
    public partial class AddProductForm : BaseForm
    {
        private readonly ProductService productService = new ProductService();

        private string image = null;

        public AddProductForm()
        {
            InitializeComponent();
        }

        private void AddProductForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void productImageSelectBtn_Click(object sender, EventArgs e)
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

            var product = new ProductCreateDto
            {
                Title = productNameText.Text,
                Description = productDescriptionText.Text,
                Quantity = (int)availableQtyNum.Value,
                Category = productCategoryText.Text,
                Price = prodcutPriceNum.Value,
                Image = this.image
            };

            var res = await productService.CreateProduct(product);

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
            }
        }
    }
}
