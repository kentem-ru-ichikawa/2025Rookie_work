namespace 送料計算システム_First
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
            txtWeight = new TextBox();
            lblWeight = new Label();
            lblWeightUnit = new Label();
            lblLength = new Label();
            lblLengthUnit = new Label();
            lblWidth = new Label();
            lblWidthUnit = new Label();
            lblHeight = new Label();
            lblHeightUnit = new Label();
            txtLength = new TextBox();
            txtWidth = new TextBox();
            txtHeight = new TextBox();
            btnCalc = new Button();
            SuspendLayout();
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(133, 67);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(157, 23);
            txtWeight.TabIndex = 0;
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(75, 70);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(31, 15);
            lblWeight.TabIndex = 1;
            lblWeight.Text = "重量";
            // 
            // lblWeightUnit
            // 
            lblWeightUnit.AutoSize = true;
            lblWeightUnit.Location = new Point(310, 70);
            lblWeightUnit.Name = "lblWeightUnit";
            lblWeightUnit.Size = new Size(20, 15);
            lblWeightUnit.TabIndex = 2;
            lblWeightUnit.Text = "kg";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(75, 127);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(31, 15);
            lblLength.TabIndex = 3;
            lblLength.Text = "縦幅";
            // 
            // lblLengthUnit
            // 
            lblLengthUnit.AutoSize = true;
            lblLengthUnit.Location = new Point(310, 127);
            lblLengthUnit.Name = "lblLengthUnit";
            lblLengthUnit.Size = new Size(23, 15);
            lblLengthUnit.TabIndex = 4;
            lblLengthUnit.Text = "cm";
            // 
            // lblWidth
            // 
            lblWidth.AutoSize = true;
            lblWidth.Location = new Point(75, 184);
            lblWidth.Name = "lblWidth";
            lblWidth.Size = new Size(31, 15);
            lblWidth.TabIndex = 5;
            lblWidth.Text = "横幅";
            // 
            // lblWidthUnit
            // 
            lblWidthUnit.AutoSize = true;
            lblWidthUnit.Location = new Point(310, 184);
            lblWidthUnit.Name = "lblWidthUnit";
            lblWidthUnit.Size = new Size(23, 15);
            lblWidthUnit.TabIndex = 6;
            lblWidthUnit.Text = "cm";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.Location = new Point(75, 241);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(27, 15);
            lblHeight.TabIndex = 7;
            lblHeight.Text = "高さ";
            // 
            // lblHeightUnit
            // 
            lblHeightUnit.AutoSize = true;
            lblHeightUnit.Location = new Point(310, 241);
            lblHeightUnit.Name = "lblHeightUnit";
            lblHeightUnit.Size = new Size(23, 15);
            lblHeightUnit.TabIndex = 8;
            lblHeightUnit.Text = "cm";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(133, 123);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(157, 23);
            txtLength.TabIndex = 1;
            // 
            // txtWidth
            // 
            txtWidth.Location = new Point(133, 179);
            txtWidth.Name = "txtWidth";
            txtWidth.Size = new Size(157, 23);
            txtWidth.TabIndex = 2;
            // 
            // txtHeight
            // 
            txtHeight.Location = new Point(133, 235);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(157, 23);
            txtHeight.TabIndex = 3;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(287, 284);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 5;
            btnCalc.Text = "計算";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 361);
            Controls.Add(btnCalc);
            Controls.Add(txtHeight);
            Controls.Add(txtWidth);
            Controls.Add(txtLength);
            Controls.Add(lblHeightUnit);
            Controls.Add(lblHeight);
            Controls.Add(lblWidthUnit);
            Controls.Add(lblWidth);
            Controls.Add(lblLengthUnit);
            Controls.Add(lblLength);
            Controls.Add(lblWeightUnit);
            Controls.Add(lblWeight);
            Controls.Add(txtWeight);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "送料計算システム";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtWeight;
        private Label lblWeight;
        private Label lblWeightUnit;
        private Label lblLength;
        private Label lblLengthUnit;
        private Label lblWidth;
        private Label lblWidthUnit;
        private Label lblHeight;
        private Label lblHeightUnit;
        private TextBox txtLength;
        private TextBox txtWidth;
        private TextBox txtHeight;
        private Button btnCalc;
    }
}
