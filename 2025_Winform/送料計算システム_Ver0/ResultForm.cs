namespace 送料計算システム_First
{
    public partial class ResultForm : Form
    {
        private string _size;
        private string _price;

        public ResultForm(PackageSize size, int price)
        {
            _size = size.ToString();
            _price = price.ToString("N0");

            InitializeComponent();
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            lblSize.Text = $@"サイズ：{_size}";
            lblPrice.Text = $@"料金：{_price}円";
        }

        private void btbClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
