namespace 面積管理システム_Ver0
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
            lvwArea = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            lblTotal = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lvwArea
            // 
            lvwArea.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lvwArea.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2 });
            lvwArea.FullRowSelect = true;
            lvwArea.Location = new Point(10, 15);
            lvwArea.MultiSelect = false;
            lvwArea.Name = "lvwArea";
            lvwArea.Size = new Size(270, 350);
            lvwArea.TabIndex = 0;
            lvwArea.UseCompatibleStateImageBehavior = false;
            lvwArea.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "図形名称";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "面積（㎡）";
            columnHeader2.Width = 150;
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(285, 20);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(44, 15);
            lblTotal.TabIndex = 1;
            lblTotal.Text = "Total：";
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(306, 59);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 37);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "追加";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(306, 102);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 37);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "削除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 381);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(lblTotal);
            Controls.Add(lvwArea);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainForm";
            Text = "面積管理システム";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView lvwArea;
        private Label lblTotal;
        private Button btnAdd;
        private Button btnDelete;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
    }
}
