namespace DealmartAdmin.Views.OrderForms
{
    partial class ViewOrdersForm
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
            viewBtn = new Button();
            orderListView = new ListView();
            SuspendLayout();
            // 
            // viewBtn
            // 
            viewBtn.Enabled = false;
            viewBtn.Location = new Point(660, 382);
            viewBtn.Name = "viewBtn";
            viewBtn.Size = new Size(116, 23);
            viewBtn.TabIndex = 5;
            viewBtn.Text = "View Order";
            viewBtn.UseVisualStyleBackColor = true;
            viewBtn.Click += viewBtn_Click;
            // 
            // orderListView
            // 
            orderListView.Alignment = ListViewAlignment.SnapToGrid;
            orderListView.AutoArrange = false;
            orderListView.FullRowSelect = true;
            orderListView.LabelWrap = false;
            orderListView.Location = new Point(0, 46);
            orderListView.MultiSelect = false;
            orderListView.Name = "orderListView";
            orderListView.RightToLeft = RightToLeft.No;
            orderListView.Size = new Size(800, 324);
            orderListView.TabIndex = 4;
            orderListView.TileSize = new Size(300, 10);
            orderListView.UseCompatibleStateImageBehavior = false;
            orderListView.View = View.Tile;
            orderListView.SelectedIndexChanged += orderListView_SelectedIndexChanged;
            // 
            // ViewOrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(viewBtn);
            Controls.Add(orderListView);
            Name = "ViewOrdersForm";
            Text = "Dealmart  - View Orders";
            FormClosing += ViewOrdersForm_FormClosing;
            Load += ViewOrdersForm_Load;
            Controls.SetChildIndex(orderListView, 0);
            Controls.SetChildIndex(viewBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button viewBtn;
        private ListView orderListView;
    }
}