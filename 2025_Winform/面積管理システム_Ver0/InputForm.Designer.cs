namespace 面積管理システム_Ver0
{
    partial class InputForm
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
            rBtnSquare = new RadioButton();
            rBtnTriangle = new RadioButton();
            gbxShapeType = new GroupBox();
            lblLength = new Label();
            txtLength = new TextBox();
            btnOK = new Button();
            btnCancel = new Button();
            gbxShapeType.SuspendLayout();
            SuspendLayout();
            // 
            // rBtnSquare
            // 
            rBtnSquare.AutoSize = true;
            rBtnSquare.Checked = true;
            rBtnSquare.Location = new Point(30, 31);
            rBtnSquare.Name = "rBtnSquare";
            rBtnSquare.Size = new Size(61, 19);
            rBtnSquare.TabIndex = 1;
            rBtnSquare.TabStop = true;
            rBtnSquare.Text = "四角形";
            rBtnSquare.UseVisualStyleBackColor = true;
            // 
            // rBtnTriangle
            // 
            rBtnTriangle.AutoSize = true;
            rBtnTriangle.Location = new Point(125, 31);
            rBtnTriangle.Name = "rBtnTriangle";
            rBtnTriangle.Size = new Size(61, 19);
            rBtnTriangle.TabIndex = 2;
            rBtnTriangle.Text = "三角形";
            rBtnTriangle.UseVisualStyleBackColor = true;
            // 
            // gbxShapeType
            // 
            gbxShapeType.Controls.Add(rBtnSquare);
            gbxShapeType.Controls.Add(rBtnTriangle);
            gbxShapeType.Location = new Point(12, 12);
            gbxShapeType.Name = "gbxShapeType";
            gbxShapeType.Size = new Size(232, 72);
            gbxShapeType.TabIndex = 0;
            gbxShapeType.TabStop = false;
            gbxShapeType.Text = "種類";
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(19, 97);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(61, 15);
            lblLength.TabIndex = 2;
            lblLength.Text = "一辺の長さ";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(92, 94);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(150, 23);
            txtLength.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(46, 138);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(75, 23);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(142, 138);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // InputForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(264, 191);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(txtLength);
            Controls.Add(lblLength);
            Controls.Add(gbxShapeType);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "InputForm";
            Text = "図形追加";
            gbxShapeType.ResumeLayout(false);
            gbxShapeType.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rBtnSquare;
        private RadioButton rBtnTriangle;
        private GroupBox gbxShapeType;
        private Label lblLength;
        private TextBox txtLength;
        private Button btnOK;
        private Button btnCancel;
    }
}