namespace 面積管理システム_Ver0
{
    public partial class InputForm : Form
    {
        public ShapeType Type { get; set; }
        public string Area { get; set; }

        public InputForm()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // 入力値を取得(エラーチェックとメッセージ表示もする)
            double dLength;
            if (!double.TryParse(txtLength.Text, out dLength) || dLength <= 0.0)
            {
                MessageBox.Show("入力値が不正です。");
                return;
            }

            // 図形判定と面積計算
            if (rBtnSquare.Checked)
            {
                Type = ShapeType.四角形;
                Area = (Math.Pow(dLength, 2)).ToString();
            }
            else
            {
                Type = ShapeType.三角形;
                Area = (Math.Pow(dLength, 2) * Math.Sqrt(3.0) / 4.0).ToString();
            }

            // ダイアログを閉じる
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
