namespace 送料計算システム_First
{
    partial class ResultForm
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
            btbClose = new Button();
            lblPrice = new Label();
            lblWeighrSize = new Label();
            lblLengthSize = new Label();
            lblSize = new Label();
            SuspendLayout();
            // 
            // btbClose
            // 
            btbClose.Location = new Point(145, 175);
            btbClose.Name = "btbClose";
            btbClose.Size = new Size(75, 23);
            btbClose.TabIndex = 0;
            btbClose.Text = "閉じる";
            btbClose.UseVisualStyleBackColor = true;
            btbClose.Click += btbClose_Click;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(34, 141);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(31, 15);
            lblPrice.TabIndex = 3;
            lblPrice.Text = "送料";
            // 
            // lblWeighrSize
            // 
            lblWeighrSize.AutoSize = true;
            lblWeighrSize.Location = new Point(44, 108);
            lblWeighrSize.Name = "lblWeighrSize";
            lblWeighrSize.Size = new Size(71, 15);
            lblWeighrSize.TabIndex = 2;
            lblWeighrSize.Text = "重量サイズ：";
            // 
            // lblLengthSize
            // 
            lblLengthSize.AutoSize = true;
            lblLengthSize.Location = new Point(44, 75);
            lblLengthSize.Name = "lblLengthSize";
            lblLengthSize.Size = new Size(71, 15);
            lblLengthSize.TabIndex = 1;
            lblLengthSize.Text = "辺長サイズ：";
            // 
            // lblSize
            // 
            lblSize.AutoSize = true;
            lblSize.Location = new Point(34, 42);
            lblSize.Name = "lblSize";
            lblSize.Size = new Size(47, 15);
            lblSize.TabIndex = 0;
            lblSize.Text = "サイズ：";
            // 
            // ResultForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(234, 211);
            Controls.Add(btbClose);
            Controls.Add(lblPrice);
            Controls.Add(lblWeighrSize);
            Controls.Add(lblLengthSize);
            Controls.Add(lblSize);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ResultForm";
            Text = "結果";
            Load += this.ResultForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btbClose;
        private Label lblPrice;
        private Label lblWeighrSize;
        private Label lblLengthSize;
        private Label lblSize;
    }
}