namespace 面積管理システム_Ver0
{
    public partial class MainForm : Form
    {
        private double _areaTotal = 0.0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm();
            var ret = inputForm.ShowDialog();
            if (ret == DialogResult.OK)
            {
                lvwArea.BeginUpdate();
                ListViewItem item = new ListViewItem([inputForm.Type.ToString(), inputForm.Area]);
                lvwArea.Items.Add(item);
                lvwArea.EndUpdate();

                CalculateTotal();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lvwArea.BeginUpdate();
            if (lvwArea.SelectedItems.Count > 0)
                lvwArea.Items.Remove(lvwArea.SelectedItems[0]);
            lvwArea.EndUpdate();

            CalculateTotal();
        }

        private void CalculateTotal()
        {
            _areaTotal = 0;
            foreach (ListViewItem itm in lvwArea.Items)
            {
                if (double.TryParse(itm.SubItems[1].Text, out double value))
                    _areaTotal += value;
            }
            lblTotal.Text = $"Total: {_areaTotal.ToString("F4")}";
        }
    }
}
