using DealmartAdmin.Views.OrderForms;
using DealmartAdmin.Views.ProductForms;

namespace DealmartAdmin.Views
{
    public partial class BaseForm : Form
    {
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void addProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addProductForm = new AddProductForm();

            addProductForm.StartPosition = FormStartPosition.Manual;
            addProductForm.Location = this.Location;
            addProductForm.Show();

            this.Hide();
        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mainForm = new MainForm();

            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = this.Location;
            mainForm.Show();

            this.Hide();
        }

        private void viewProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewProductForm = new ViewProductsForm();

            viewProductForm.StartPosition = FormStartPosition.Manual;
            viewProductForm.Location = this.Location;
            viewProductForm.Show();

            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void viewOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var viewOrdersForm = new ViewOrdersForm();

            viewOrdersForm.StartPosition = FormStartPosition.Manual;
            viewOrdersForm.Location = this.Location;
            viewOrdersForm.Show();

            this.Hide();
        }
    }
}
