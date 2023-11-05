namespace DealmartAdmin.Views
{
    partial class BaseForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mainmenuStrip = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            homeToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            viewProductsToolStripMenuItem = new ToolStripMenuItem();
            addProductToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            viewOrdersToolStripMenuItem = new ToolStripMenuItem();
            mainmenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // mainmenuStrip
            // 
            mainmenuStrip.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, productToolStripMenuItem, orderToolStripMenuItem });
            mainmenuStrip.Location = new Point(0, 0);
            mainmenuStrip.Name = "mainmenuStrip";
            mainmenuStrip.Size = new Size(800, 24);
            mainmenuStrip.TabIndex = 1;
            mainmenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { homeToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // homeToolStripMenuItem
            // 
            homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            homeToolStripMenuItem.Size = new Size(107, 22);
            homeToolStripMenuItem.Text = "Home";
            homeToolStripMenuItem.Click += homeToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(107, 22);
            exitToolStripMenuItem.Text = "Exit";
            exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewProductsToolStripMenuItem, addProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            // 
            // viewProductsToolStripMenuItem
            // 
            viewProductsToolStripMenuItem.Name = "viewProductsToolStripMenuItem";
            viewProductsToolStripMenuItem.Size = new Size(149, 22);
            viewProductsToolStripMenuItem.Text = "View Products";
            viewProductsToolStripMenuItem.Click += viewProductsToolStripMenuItem_Click;
            // 
            // addProductToolStripMenuItem
            // 
            addProductToolStripMenuItem.Name = "addProductToolStripMenuItem";
            addProductToolStripMenuItem.Size = new Size(149, 22);
            addProductToolStripMenuItem.Text = "Add Product";
            addProductToolStripMenuItem.Click += addProductToolStripMenuItem_Click;
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { viewOrdersToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(49, 20);
            orderToolStripMenuItem.Text = "Order";
            // 
            // viewOrdersToolStripMenuItem
            // 
            viewOrdersToolStripMenuItem.Name = "viewOrdersToolStripMenuItem";
            viewOrdersToolStripMenuItem.Size = new Size(180, 22);
            viewOrdersToolStripMenuItem.Text = "View Orders";
            viewOrdersToolStripMenuItem.Click += viewOrdersToolStripMenuItem_Click;
            // 
            // BaseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainmenuStrip);
            Name = "BaseForm";
            Text = "BaseForm";
            FormClosing += BaseForm_FormClosing;
            mainmenuStrip.ResumeLayout(false);
            mainmenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mainmenuStrip;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem homeToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem viewProductsToolStripMenuItem;
        private ToolStripMenuItem addProductToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem viewOrdersToolStripMenuItem;
    }
}