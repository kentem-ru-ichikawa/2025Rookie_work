namespace 送料計算システム_First
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // 各入力値を取得(エラーチェックとメッセージ表示もする)
            double weight;
            if (string.IsNullOrEmpty(txtWeight.Text) ||
                !double.TryParse(txtWeight.Text, out weight) ||
                weight < Const.WEIGHT_MIN || Const.WEIGHT_MAX < weight)
            {
                MessageBox.Show($"重量：{Const.ERROR_MESSAGE_INVALID}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double length;
            if (string.IsNullOrEmpty(txtLength.Text) ||
                !double.TryParse(txtLength.Text, out length) ||
                length < Const.SIZE_MIN)
            {
                MessageBox.Show($"縦幅：{Const.ERROR_MESSAGE_INVALID}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double width;
            if (string.IsNullOrEmpty(txtWidth.Text) ||
                !double.TryParse(txtWidth.Text, out width) ||
                width < Const.SIZE_MIN)
            {
                MessageBox.Show($"横幅：{Const.ERROR_MESSAGE_INVALID}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double height;
            if (string.IsNullOrEmpty(txtHeight.Text) ||
                !double.TryParse(txtHeight.Text, out height) ||
                height < Const.SIZE_MIN)
            {
                MessageBox.Show($"横幅：{Const.ERROR_MESSAGE_INVALID}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 入力値からサイズを判定
            // 3辺の合計
            var lengthSize = PackageSize.NONE;
            var total_length = length + width + height;
            if (total_length <= Const.SIZE_S_THREE_SIDES_LIMIT)
                lengthSize = PackageSize.S;
            else if (total_length > Const.SIZE_S_THREE_SIDES_LIMIT && total_length <= Const.SIZE_M_THREE_SIDES_LIMIT)
                lengthSize = PackageSize.M;
            else if (total_length > Const.SIZE_M_THREE_SIDES_LIMIT && total_length <= Const.SIZE_L_THREE_SIDES_LIMIT)
                lengthSize = PackageSize.L;
            else //total_length > Const.SIZE_MAX
            {
                MessageBox.Show($"3辺合計：{Const.ERROR_MESSAGE_INVALID_SIZE}", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 重量
            var weightSize = PackageSize.NONE;
            if (weight >= Const.WEIGHT_MIN && weight <= Const.SIZE_S_WEIGHT_LIMIT)
                weightSize = PackageSize.S;
            else if (weight > Const.SIZE_S_WEIGHT_LIMIT && weight <= Const.SIZE_M_WEIGHT_LIMIT)
                weightSize = PackageSize.M;
            else if (weight > Const.SIZE_M_WEIGHT_LIMIT && weight <= Const.SIZE_L_WEIGHT_LIMIT)
                weightSize = PackageSize.L;

            // 3辺合計と重量のサイズから結果サイズを決定
            var resultSize = PackageSize.NONE;
            if (lengthSize == PackageSize.NONE | weightSize == PackageSize.NONE)
                resultSize = PackageSize.NONE;
            else if (lengthSize <= PackageSize.S & weightSize <= PackageSize.S)
                resultSize = PackageSize.S;
            else if (lengthSize <= PackageSize.M & weightSize <= PackageSize.M)
                resultSize = PackageSize.M;
            else if (lengthSize <= PackageSize.L & weightSize <= PackageSize.L)
                resultSize = PackageSize.L;

            // 結果サイズから送料を決定
            var price = 0;
            if (resultSize == PackageSize.S)
                price = Const.SIZE_S_PRICE;
            else if (resultSize == PackageSize.M)
                price = Const.SIZE_M_PRICE;
            else if (resultSize == PackageSize.L)
                price = Const.SIZE_L_PRICE;
            else
            {
                MessageBox.Show(Const.ERROR_MESSAGE_INVALID_CALC, "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 結果ダイアログに必要な情報を渡して表示
            ResultForm resultForm = new ResultForm(resultSize, lengthSize, weightSize, price);
            resultForm.ShowDialog();
        }
    }
}
