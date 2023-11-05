namespace DealmartAdmin.Views.ProductForms
{
    partial class AddProductForm
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
            productNameLabel = new Label();
            productNameText = new TextBox();
            productPriceLabel = new Label();
            prodcutPriceNum = new NumericUpDown();
            availableQtyLabel = new Label();
            availableQtyNum = new NumericUpDown();
            productImageLabel = new Label();
            productImageSelectBtn = new Button();
            productImageFileDialog = new OpenFileDialog();
            productImageBox = new PictureBox();
            saveProductBtn = new Button();
            productDescriptionText = new TextBox();
            productDescriptionLabel = new Label();
            productCategoryText = new TextBox();
            productCategoryLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)prodcutPriceNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)availableQtyNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productImageBox).BeginInit();
            SuspendLayout();
            // 
            // productNameLabel
            // 
            productNameLabel.AutoSize = true;
            productNameLabel.Location = new Point(77, 50);
            productNameLabel.Name = "productNameLabel";
            productNameLabel.Size = new Size(92, 15);
            productNameLabel.TabIndex = 2;
            productNameLabel.Text = "Product Name *";
            // 
            // productNameText
            // 
            productNameText.Location = new Point(228, 47);
            productNameText.Name = "productNameText";
            productNameText.Size = new Size(264, 23);
            productNameText.TabIndex = 3;
            // 
            // productPriceLabel
            // 
            productPriceLabel.AutoSize = true;
            productPriceLabel.Location = new Point(77, 234);
            productPriceLabel.Name = "productPriceLabel";
            productPriceLabel.Size = new Size(86, 15);
            productPriceLabel.TabIndex = 4;
            productPriceLabel.Text = "Product Price *";
            // 
            // prodcutPriceNum
            // 
            prodcutPriceNum.DecimalPlaces = 2;
            prodcutPriceNum.Increment = new decimal(new int[] { 10, 0, 0, 0 });
            prodcutPriceNum.Location = new Point(228, 232);
            prodcutPriceNum.Maximum = new decimal(new int[] { 1410065408, 2, 0, 0 });
            prodcutPriceNum.Name = "prodcutPriceNum";
            prodcutPriceNum.Size = new Size(120, 23);
            prodcutPriceNum.TabIndex = 5;
            prodcutPriceNum.ThousandsSeparator = true;
            // 
            // availableQtyLabel
            // 
            availableQtyLabel.AutoSize = true;
            availableQtyLabel.Location = new Point(77, 285);
            availableQtyLabel.Name = "availableQtyLabel";
            availableQtyLabel.Size = new Size(112, 15);
            availableQtyLabel.TabIndex = 6;
            availableQtyLabel.Text = "Available Quantity *";
            // 
            // availableQtyNum
            // 
            availableQtyNum.Location = new Point(228, 283);
            availableQtyNum.Name = "availableQtyNum";
            availableQtyNum.Size = new Size(120, 23);
            availableQtyNum.TabIndex = 7;
            // 
            // productImageLabel
            // 
            productImageLabel.AutoSize = true;
            productImageLabel.Location = new Point(77, 339);
            productImageLabel.Name = "productImageLabel";
            productImageLabel.Size = new Size(93, 15);
            productImageLabel.TabIndex = 8;
            productImageLabel.Text = "Product Image *";
            // 
            // productImageSelectBtn
            // 
            productImageSelectBtn.Location = new Point(228, 335);
            productImageSelectBtn.Name = "productImageSelectBtn";
            productImageSelectBtn.Size = new Size(120, 23);
            productImageSelectBtn.TabIndex = 9;
            productImageSelectBtn.Text = "Select Image";
            productImageSelectBtn.UseVisualStyleBackColor = true;
            productImageSelectBtn.Click += productImageSelectBtn_Click;
            // 
            // productImageFileDialog
            // 
            productImageFileDialog.FileName = "productImageFileDialog";
            // 
            // productImageBox
            // 
            productImageBox.Location = new Point(564, 47);
            productImageBox.Name = "productImageBox";
            productImageBox.Size = new Size(200, 178);
            productImageBox.SizeMode = PictureBoxSizeMode.StretchImage;
            productImageBox.TabIndex = 10;
            productImageBox.TabStop = false;
            productImageBox.Visible = false;
            // 
            // saveProductBtn
            // 
            saveProductBtn.Location = new Point(228, 394);
            saveProductBtn.Name = "saveProductBtn";
            saveProductBtn.Size = new Size(264, 23);
            saveProductBtn.TabIndex = 11;
            saveProductBtn.Text = "Save Product";
            saveProductBtn.UseVisualStyleBackColor = true;
            saveProductBtn.Click += saveProductBtn_Click;
            // 
            // productDescriptionText
            // 
            productDescriptionText.Location = new Point(228, 90);
            productDescriptionText.Multiline = true;
            productDescriptionText.Name = "productDescriptionText";
            productDescriptionText.ScrollBars = ScrollBars.Vertical;
            productDescriptionText.Size = new Size(264, 70);
            productDescriptionText.TabIndex = 13;
            // 
            // productDescriptionLabel
            // 
            productDescriptionLabel.AutoSize = true;
            productDescriptionLabel.Location = new Point(77, 93);
            productDescriptionLabel.Name = "productDescriptionLabel";
            productDescriptionLabel.Size = new Size(120, 15);
            productDescriptionLabel.TabIndex = 12;
            productDescriptionLabel.Text = "Product Description *";
            // 
            // productCategoryText
            // 
            productCategoryText.Location = new Point(228, 182);
            productCategoryText.Name = "productCategoryText";
            productCategoryText.Size = new Size(264, 23);
            productCategoryText.TabIndex = 15;
            // 
            // productCategoryLabel
            // 
            productCategoryLabel.AutoSize = true;
            productCategoryLabel.Location = new Point(77, 185);
            productCategoryLabel.Name = "productCategoryLabel";
            productCategoryLabel.Size = new Size(108, 15);
            productCategoryLabel.TabIndex = 14;
            productCategoryLabel.Text = "Product Category *";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(productCategoryText);
            Controls.Add(productCategoryLabel);
            Controls.Add(productDescriptionText);
            Controls.Add(productDescriptionLabel);
            Controls.Add(saveProductBtn);
            Controls.Add(productImageBox);
            Controls.Add(productImageSelectBtn);
            Controls.Add(productImageLabel);
            Controls.Add(availableQtyNum);
            Controls.Add(availableQtyLabel);
            Controls.Add(prodcutPriceNum);
            Controls.Add(productPriceLabel);
            Controls.Add(productNameText);
            Controls.Add(productNameLabel);
            Name = "AddProductForm";
            Text = "Dealmart  - Add Product";
            Controls.SetChildIndex(productNameLabel, 0);
            Controls.SetChildIndex(productNameText, 0);
            Controls.SetChildIndex(productPriceLabel, 0);
            Controls.SetChildIndex(prodcutPriceNum, 0);
            Controls.SetChildIndex(availableQtyLabel, 0);
            Controls.SetChildIndex(availableQtyNum, 0);
            Controls.SetChildIndex(productImageLabel, 0);
            Controls.SetChildIndex(productImageSelectBtn, 0);
            Controls.SetChildIndex(productImageBox, 0);
            Controls.SetChildIndex(saveProductBtn, 0);
            Controls.SetChildIndex(productDescriptionLabel, 0);
            Controls.SetChildIndex(productDescriptionText, 0);
            Controls.SetChildIndex(productCategoryLabel, 0);
            Controls.SetChildIndex(productCategoryText, 0);
            ((System.ComponentModel.ISupportInitialize)prodcutPriceNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)availableQtyNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)productImageBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label productNameLabel;
        private TextBox productNameText;
        private Label productPriceLabel;
        private NumericUpDown prodcutPriceNum;
        private Label availableQtyLabel;
        private NumericUpDown availableQtyNum;
        private Label productImageLabel;
        private Button productImageSelectBtn;
        private OpenFileDialog productImageFileDialog;
        private PictureBox productImageBox;
        private Button saveProductBtn;
        private TextBox productDescriptionText;
        private Label productDescriptionLabel;
        private TextBox productCategoryText;
        private Label productCategoryLabel;
    }
}