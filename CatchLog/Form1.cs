namespace CatchLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddCatch_Click(object sender, EventArgs e)
        {
            if (dtpCatchDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Catch date cannot be in the future.");
                dtpCatchDate.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSpecies.Text))
            {
                MessageBox.Show("Please enter the fish species.");
                txtSpecies.Focus();
                return;
            }

            if (!decimal.TryParse(txtLength.Text, out decimal length) || length <= 0)
            {
                MessageBox.Show("Please enter a length greater than zero.");
                txtLength.Focus();
                return;
            }

            if (!decimal.TryParse(txtWeight.Text, out decimal weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a weight greater than zero.");
                txtWeight.Focus();
                return;
            }

            MessageBox.Show("The catch details are valid. Saving is not available yet.");
        }
    }
}
