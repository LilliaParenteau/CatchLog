using Microsoft.Data.SqlClient;
using System.Data;

namespace CatchLog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtSpecies.MaxLength = 100;
            txtLocation.MaxLength = 150;
            txtBait.MaxLength = 100;

            // Connect each event once, even if the Designer already connected it.
            Load -= Form1_Load;
            Load += Form1_Load;

            btnAddCatch.Click -= btnAddCatch_Click;
            btnAddCatch.Click += btnAddCatch_Click;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            try
            {
                DataTable catches = CatchDB.GetCatches();

                dgvCatches.Rows.Clear();

                foreach (DataRow row in catches.Rows)
                {
                    dgvCatches.Rows.Add(
                        ((DateTime)row["CatchDate"]).ToShortDateString(),
                        row["Species"],
                        row["Location"],
                        row["Bait"],
                        row["LengthInches"],
                        row["WeightPounds"]
                    );
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Could not load catches. Check that LocalDB is available and Setup.sql has been run.",
                    "Database error"
                );
            }
        }

        private void btnAddCatch_Click(object? sender, EventArgs e)
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

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the catch location.");
                txtLocation.Focus();
                return;
            }

            if (!decimal.TryParse(txtLength.Text, out decimal length)
                || length <= 0)
            {
                MessageBox.Show("Please enter a length greater than zero.");
                txtLength.Focus();
                return;
            }

            if (!decimal.TryParse(txtWeight.Text, out decimal weight)
                || weight <= 0)
            {
                MessageBox.Show("Please enter a weight greater than zero.");
                txtWeight.Focus();
                return;
            }

            // Match the database's DECIMAL(8,2) measurement columns.
            if (length > 999999.99m || decimal.Round(length, 2) != length)
            {
                MessageBox.Show(
                    "Length must be no more than 999999.99 inches and use at most two decimal places."
                );
                txtLength.Focus();
                return;
            }

            if (weight > 999999.99m || decimal.Round(weight, 2) != weight)
            {
                MessageBox.Show(
                    "Weight must be no more than 999999.99 pounds and use at most two decimal places."
                );
                txtWeight.Focus();
                return;
            }

            string species = txtSpecies.Text.Trim();
            string location = txtLocation.Text.Trim();
            string bait = txtBait.Text.Trim();

            try
            {
                CatchDB.AddCatch(
                    dtpCatchDate.Value.Date,
                    species,
                    location,
                    bait,
                    length,
                    weight
                );
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "The catch could not be saved. Your entries have been kept so you can try again.",
                    "Database error"
                );
                return;
            }

            dgvCatches.Rows.Add(
                dtpCatchDate.Value.ToShortDateString(),
                species,
                location,
                bait,
                length,
                weight
            );

            txtSpecies.Clear();
            txtLocation.Clear();
            txtBait.Clear();
            txtLength.Clear();
            txtWeight.Clear();
            txtSpecies.Focus();
        }
    }
}