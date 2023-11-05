namespace DealmartAdmin.Views.OrderForms
{
    partial class OrderDetailsForm
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
            buyerIdLabel = new Label();
            buyerIdVal = new Label();
            buyerAddLabel = new Label();
            buyerAddVal = new Label();
            buyerDetailsLabel = new Label();
            productDetailsLabel = new Label();
            orderProducListView = new ListView();
            totalPriceLabel = new Label();
            totalPriceVal = new Label();
            acceptOrderBtn = new Button();
            SuspendLayout();
            // 
            // buyerIdLabel
            // 
            buyerIdLabel.AutoSize = true;
            buyerIdLabel.Location = new Point(92, 77);
            buyerIdLabel.Name = "buyerIdLabel";
            buyerIdLabel.Size = new Size(50, 15);
            buyerIdLabel.TabIndex = 0;
            buyerIdLabel.Text = "Buyer Id";
            // 
            // buyerIdVal
            // 
            buyerIdVal.AutoSize = true;
            buyerIdVal.Location = new Point(248, 77);
            buyerIdVal.Name = "buyerIdVal";
            buyerIdVal.Size = new Size(81, 15);
            buyerIdVal.TabIndex = 1;
            buyerIdVal.Text = "Buyer Id Value";
            // 
            // buyerAddLabel
            // 
            buyerAddLabel.AutoSize = true;
            buyerAddLabel.Location = new Point(92, 112);
            buyerAddLabel.Name = "buyerAddLabel";
            buyerAddLabel.Size = new Size(49, 15);
            buyerAddLabel.TabIndex = 2;
            buyerAddLabel.Text = "Address";
            // 
            // buyerAddVal
            // 
            buyerAddVal.AutoSize = true;
            buyerAddVal.Location = new Point(248, 112);
            buyerAddVal.Name = "buyerAddVal";
            buyerAddVal.Size = new Size(113, 15);
            buyerAddVal.TabIndex = 3;
            buyerAddVal.Text = "Buyer Address Value";
            // 
            // buyerDetailsLabel
            // 
            buyerDetailsLabel.AutoSize = true;
            buyerDetailsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            buyerDetailsLabel.Location = new Point(63, 33);
            buyerDetailsLabel.Name = "buyerDetailsLabel";
            buyerDetailsLabel.Size = new Size(90, 17);
            buyerDetailsLabel.TabIndex = 4;
            buyerDetailsLabel.Text = "Buyer Details";
            // 
            // productDetailsLabel
            // 
            productDetailsLabel.AutoSize = true;
            productDetailsLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            productDetailsLabel.Location = new Point(63, 194);
            productDetailsLabel.Name = "productDetailsLabel";
            productDetailsLabel.Size = new Size(109, 17);
            productDetailsLabel.TabIndex = 7;
            productDetailsLabel.Text = "Products Details";
            // 
            // orderProducListView
            // 
            orderProducListView.Location = new Point(63, 227);
            orderProducListView.Name = "orderProducListView";
            orderProducListView.Size = new Size(433, 126);
            orderProducListView.TabIndex = 8;
            orderProducListView.UseCompatibleStateImageBehavior = false;
            // 
            // totalPriceLabel
            // 
            totalPriceLabel.AutoSize = true;
            totalPriceLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            totalPriceLabel.Location = new Point(599, 194);
            totalPriceLabel.Name = "totalPriceLabel";
            totalPriceLabel.Size = new Size(73, 17);
            totalPriceLabel.TabIndex = 9;
            totalPriceLabel.Text = "Total Price";
            // 
            // totalPriceVal
            // 
            totalPriceVal.AutoSize = true;
            totalPriceVal.Location = new Point(599, 227);
            totalPriceVal.Name = "totalPriceVal";
            totalPriceVal.Size = new Size(92, 15);
            totalPriceVal.TabIndex = 10;
            totalPriceVal.Text = "Total Price Value";
            // 
            // acceptOrderBtn
            // 
            acceptOrderBtn.Location = new Point(63, 389);
            acceptOrderBtn.Name = "acceptOrderBtn";
            acceptOrderBtn.Size = new Size(127, 23);
            acceptOrderBtn.TabIndex = 11;
            acceptOrderBtn.Text = "Accept Order";
            acceptOrderBtn.UseVisualStyleBackColor = true;
            acceptOrderBtn.Click += acceptOrderBtn_Click;
            // 
            // OrderDetailsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(acceptOrderBtn);
            Controls.Add(totalPriceVal);
            Controls.Add(totalPriceLabel);
            Controls.Add(orderProducListView);
            Controls.Add(productDetailsLabel);
            Controls.Add(buyerDetailsLabel);
            Controls.Add(buyerAddVal);
            Controls.Add(buyerAddLabel);
            Controls.Add(buyerIdVal);
            Controls.Add(buyerIdLabel);
            Name = "OrderDetailsForm";
            Text = "Dealmart  - Order Details";
            FormClosing += OrderDetailsForm_FormClosing;
            Controls.SetChildIndex(buyerIdLabel, 0);
            Controls.SetChildIndex(buyerIdVal, 0);
            Controls.SetChildIndex(buyerAddLabel, 0);
            Controls.SetChildIndex(buyerAddVal, 0);
            Controls.SetChildIndex(buyerDetailsLabel, 0);
            Controls.SetChildIndex(productDetailsLabel, 0);
            Controls.SetChildIndex(orderProducListView, 0);
            Controls.SetChildIndex(totalPriceLabel, 0);
            Controls.SetChildIndex(totalPriceVal, 0);
            Controls.SetChildIndex(acceptOrderBtn, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label buyerIdLabel;
        private Label buyerIdVal;
        private Label buyerAddLabel;
        private Label buyerAddVal;
        private Label buyerDetailsLabel;
        private Label productDetailsLabel;
        private ListView orderProducListView;
        private Label totalPriceLabel;
        private Label totalPriceVal;
        private Button acceptOrderBtn;
    }
}