namespace DealmartAdmin.Views.ProductForms
{
    partial class ViewProductsForm
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
            productListView = new ListView();
            editBtn = new Button();
            SuspendLayout();
            // 
            // productListView
            // 
            productListView.Alignment = ListViewAlignment.SnapToGrid;
            productListView.AutoArrange = false;
            productListView.FullRowSelect = true;
            productListView.LabelWrap = false;
            productListView.Location = new Point(0, 65);
            productListView.MultiSelect = false;
            productListView.Name = "productListView";
            productListView.RightToLeft = RightToLeft.No;
            productListView.Size = new Size(800, 324);
            productListView.TabIndex = 2;
            productListView.TileSize = new Size(300, 10);
            productListView.UseCompatibleStateImageBehavior = false;
            productListView.View = View.Tile;
            productListView.SelectedIndexChanged += productListView_SelectedIndexChanged;
            // 
            // editBtn
            // 
            editBtn.Enabled = false;
            editBtn.Location = new Point(660, 401);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(116, 23);
            editBtn.TabIndex = 3;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            editBtn.Click += editBtn_Click;
            // 
            // ViewProductsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(editBtn);
            Controls.Add(productListView);
            Name = "ViewProductsForm";
            Text = "Dealmart - View Products";
            Load += ViewProductsForm_Load;
            Controls.SetChildIndex(productListView, 0);
            Controls.SetChildIndex(editBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView productListView;
        private Button editBtn;
    }
}