namespace DealmartAdmin.Views.ProductForms
{
    partial class EditProductForm
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
            saveProductBtn = new Button();
            productImageBox = new PictureBox();
            productImageEditBtn = new Button();
            productImageLabel = new Label();
            availableQtyNum = new NumericUpDown();
            availableQtyLabel = new Label();
            prodcutPriceNum = new NumericUpDown();
            productPriceLabel = new Label();
            productNameText = new TextBox();
            productNameLabel = new Label();
            deleteProductBtn = new Button();
            productCategoryText = new TextBox();
            productCategoryLabel = new Label();
            productDescriptionText = new TextBox();
            productDescriptionLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)productImageBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableQtyNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)prodcutPriceNum).BeginInit();
            SuspendLayout();
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(213, 392);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(264, 23);
            saveProductBtn.TabIndex = 21;
            saveProductBtn.Text = "Save Product";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // productImageBox
            // 
            productImageBox.Location = new Point(538, 39);
            productImageBox.Name = "productImageBox";
            productImageBox.Size = new Size(200, 178);
            productImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImageBox.TabIndex = 20;
            productImageBox.TabStop = false;
            productImageBox.Visible = false;
            // 
            // productImageEditBtn
            // 
            productImageEditBtn.Location = new Point(213, 335);
            productImageEditBtn.Name = "productImageEditBtn";
            productImageEditBtn.Size = new Size(120, 23);
            productImageEditBtn.TabIndex = 19;
            productImageEditBtn.Text = "Edit Image";
            productImageEditBtn.UseVisualStyleBackColor = true;
            productImageEditBtn.Click += productImageEditBtn_Click;
            // 
            // productImageLabel
            // 
            productImageLabel.AutoSize = true;
            productImageLabel.Location = new Point(62, 339);
            productImageLabel.Name = "productImageLabel";
            productImageLabel.Size = new Size(93, 15);
            productImageLabel.TabIndex = 18;
            productImageLabel.Text = "Product Image *";
            // 
            // availableQtyNum
            // 
            availableQtyNum.Location = new Point(213, 283);
            availableQtyNum.Name = "availableQtyNum";
            availableQtyNum.Size = new Size(120, 23);
            availableQtyNum.TabIndex = 17;
            // 
            // availableQtyLabel
            // 
            availableQtyLabel.AutoSize = true;
            availableQtyLabel.Location = new Point(62, 285);
            availableQtyLabel.Name = "availableQtyLabel";
            availableQtyLabel.Size = new Size(112, 15);
            availableQtyLabel.TabIndex = 16;
            availableQtyLabel.Text = "Available Quantity *";
            // 
            // prodcutPriceNum
            // 
            prodcutPriceNum.DecimalPlaces = 2;
            prodcutPriceNum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            prodcutPriceNum.Location = new Point(213, 232);
            prodcutPriceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            prodcutPriceNum.Name = "prodcutPriceNum";
            prodcutPriceNum.Size = new Size(120, 23);
            prodcutPriceNum.TabIndex = 15;
            prodcutPriceNum.ThousandsSeparator = true;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new Point(62, 234);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(86, 15);
            productPriceLabel.TabIndex = 14;
            productPriceLabel.Text = "Product Price *";
            // 
            // productNameText
            // 
            productNameText.Location = new Point(213, 39);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(264, 23);
            productNameText.TabIndex = 13;
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(62, 42);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(92, 15);
            productNameLabel.TabIndex = 12;
            productNameLabel.Text = "Product Name *";
            // 
            // deleteProductBtn
            // 
            deleteProductBtn.Location = new Point(538, 392);
            deleteProductBtn.Name = "deleteProductBtn";
            deleteProductBtn.Size = new Size(200, 23);
            deleteProductBtn.TabIndex = 22;
            deleteProductBtn.Text = "Delete Product";
            deleteProductBtn.UseVisualStyleBackColor = true;
            deleteProductBtn.Click += deleteProductBtn_Click;
            // 
            // productCategoryText
            // 
            productCategoryText.Location = new Point(213, 179);
            productCategoryText.Name = "productCategoryText";
            productCategoryText.Size = new Size(264, 23);
            productCategoryText.TabIndex = 26;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new Point(62, 182);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new Size(108, 15);
            productCategoryLabel.TabIndex = 25;
            productCategoryLabel.Text = "Product Category *";
            // 
            // productDescriptionText
            // 
            productDescriptionText.Location = new Point(213, 87);
            productDescriptionText.Multiline = true;
            productDescriptionText.Name = "productDescriptionText";
            productDescriptionText.ScrollBars = ScrollBars.Vertical;
            productDescriptionText.Size = new Size(264, 70);
            productDescriptionText.TabIndex = 24;
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new Point(62, 90);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new Size(120, 15);
            productDescriptionLabel.TabIndex = 23;
            productDescriptionLabel.Text = "Product Description *";
            // 
            // EditProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productCategoryText);
            Controls.Add(productCategoryLabel);
            Controls.Add(productDescriptionText);
            Controls.Add(productDescriptionLabel);
            Controls.Add(deleteProductBtn);
            Controls.Add(saveProductBtn);
            Controls.Add(productImageBox);
            Controls.Add(productImageEditBtn);
            Controls.Add(productImageLabel);
            Controls.Add(availableQtyNum);
            Controls.Add(availableQtyLabel);
            Controls.Add(prodcutPriceNum);
            Controls.Add(productPriceLabel);
            Controls.Add(productNameText);
            Controls.Add(productNameLabel);
            Name = "EditProductForm";
            Text = "Dealmart - Edit Product";
            FormClosing += EditProductForm_FormClosing;
            Controls.SetChildIndex(productNameLabel, 0);
            Controls.SetChildIndex(productNameText, 0);
            Controls.SetChildIndex(productPriceLabel, 0);
            Controls.SetChildIndex(prodcutPriceNum, 0);
            Controls.SetChildIndex(availableQtyLabel, 0);
            Controls.SetChildIndex(availableQtyNum, 0);
            Controls.SetChildIndex(productImageLabel, 0);
            Controls.SetChildIndex(productImageEditBtn, 0);
            Controls.SetChildIndex(productImageBox, 0);
            Controls.SetChildIndex(saveProductBtn, 0);
            Controls.SetChildIndex(deleteProductBtn, 0);
            Controls.SetChildIndex(productDescriptionLabel, 0);
            Controls.SetChildIndex(productDescriptionText, 0);
            Controls.SetChildIndex(productCategoryLabel, 0);
            Controls.SetChildIndex(productCategoryText, 0);
            ((System.ComponentModel.ISupportInitialize)productImageBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableQtyNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)prodcutPriceNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button saveProductBtn;
        private PictureBox productImageBox;
        private Button productImageEditBtn;
        private Label productImageLabel;
        private NumericUpDown availableQtyNum;
        private Label availableQtyLabel;
        private NumericUpDown prodcutPriceNum;
        private Label productPriceLabel;
        private TextBox productNameText;
        private Label productNameLabel;
        private Button deleteProductBtn;
        private TextBox productCategoryText;
        private Label productCategoryLabel;
        private TextBox productDescriptionText;
        private Label productDescriptionLabel;
    }
}