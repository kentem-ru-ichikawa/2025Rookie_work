namespace 送料計算システム_First
{
    public partial class ResultForm : Form
    {
        private string _size;
        private string _lengthSize;
        private string _weightSize;
        private string _price;

        public ResultForm(PackageSize size, PackageSize lengthSize, PackageSize weightSize, int price)
        {
            _size = size.ToString();
            _lengthSize = lengthSize.ToString();
            _weightSize = weightSize.ToString();
            _price = price.ToString("N0");

            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            lblSize.Text = $@"サイズ：{_size}";
            lblLengthSize.Text = $@"辺長サイズ：{_lengthSize}";
            lblWeighrSize.Text = $@"重量サイズ：{_weightSize}";
            lblPrice.Text = $@"料金：{_price}円";
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
