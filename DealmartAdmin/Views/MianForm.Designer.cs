namespace DealmartAdmin
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            welcomeTextLabel = new Label();
            myStoreLabel = new Label();
            instructionLabel = new Label();
            SuspendLayout();
            // 
            // welcomeTextLabel
            // 
            welcomeTextLabel.AutoSize = true;
            welcomeTextLabel.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point);
            welcomeTextLabel.Location = new Point(207, 98);
            welcomeTextLabel.Name = "welcomeTextLabel";
            welcomeTextLabel.Size = new Size(397, 86);
            welcomeTextLabel.TabIndex = 3;
            welcomeTextLabel.Text = "Welcome !!!";
            // 
            // myStoreLabel
            // 
            myStoreLabel.AutoSize = true;
            myStoreLabel.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point);
            myStoreLabel.Location = new Point(154, 205);
            myStoreLabel.Name = "myStoreLabel";
            myStoreLabel.Size = new Size(499, 65);
            myStoreLabel.TabIndex = 4;
            myStoreLabel.Text = "Dealmart Admin Panel";
            // 
            // instructionLabel
            // 
            instructionLabel.AutoSize = true;
            instructionLabel.Font = new Font("Segoe UI", 16.25F, FontStyle.Italic, GraphicsUnit.Point);
            instructionLabel.Location = new Point(212, 392);
            instructionLabel.Name = "instructionLabel";
            instructionLabel.Size = new Size(372, 30);
            instructionLabel.TabIndex = 5;
            instructionLabel.Text = "(Please use top file menu to navigate)";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(instructionLabel);
            Controls.Add(myStoreLabel);
            Controls.Add(welcomeTextLabel);
            Name = "MainForm";
            Text = "Dealmart - Admin Panel";
            FormClosing += MainForm_FormClosing;
            Controls.SetChildIndex(welcomeTextLabel, 0);
            Controls.SetChildIndex(myStoreLabel, 0);
            Controls.SetChildIndex(instructionLabel, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label welcomeTextLabel;
        private Label myStoreLabel;
        private Label instructionLabel;
    }
}