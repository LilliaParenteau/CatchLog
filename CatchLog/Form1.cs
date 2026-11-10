
using Microsoft.Data.SqlClient;
using System.Data;

namespace CatchLog
{
    public partial class Form1 : Form
    {
        private int? editingCatchID = null;

        public Form1()
        {
            InitializeComponent();

            txtSpecies.MaxLength = 100;
            txtLocation.MaxLength = 150;
            txtBait.MaxLength = 100;

            Load -= Form1_Load;
            Load += Form1_Load;

            btnAddCatch.Click -= btnAddCatch_Click;
            btnAddCatch.Click += btnAddCatch_Click;
        }

        private bool ValidateCatch(out decimal length, out decimal weight)
        {
            length = 0;
            weight = 0;

            if (dtpCatchDate.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Catch date cannot be in the future.");
                dtpCatchDate.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtSpecies.Text))
            {
                MessageBox.Show("Please enter the fish species.");
                txtSpecies.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocation.Text))
            {
                MessageBox.Show("Please enter the catch location.");
                txtLocation.Focus();
                return false;
            }

            if (!decimal.TryParse(txtLength.Text, out length) || length <= 0)
            {
                MessageBox.Show("Please enter a length greater than zero.");
                txtLength.Focus();
                return false;
            }

            if (!decimal.TryParse(txtWeight.Text, out weight) || weight <= 0)
            {
                MessageBox.Show("Please enter a weight greater than zero.");
                txtWeight.Focus();
                return false;
            }

            if (length > 999999.99m || decimal.Round(length, 2) != length)
            {
                MessageBox.Show("Length must be no more than 999999.99 inches and use at most two decimal places.");
                txtLength.Focus();
                return false;
            }

            if (weight > 999999.99m || decimal.Round(weight, 2) != weight)
            {
                MessageBox.Show("Weight must be no more than 999999.99 pounds and use at most two decimal places.");
                txtWeight.Focus();
                return false;
            }

            return true;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadCatches();
        }

        private void LoadCatches(string searchText = "")
        {
            try
            {
                DataTable catches = CatchDB.GetCatches(searchText);

                dgvCatches.Rows.Clear();

                foreach (DataRow row in catches.Rows)
                {
                    dgvCatches.Rows.Add(
                        ((DateTime)row["CatchDate"]).ToShortDateString(),
                        row["Species"],
                        row["Location"],
                        row["Bait"],
                        row["LengthInches"],
                        row["WeightPounds"],
                        row["CatchID"]
                    );
                }
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Could not load catches. Check that LocalDB is available.",
                    "Database error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void btnAddCatch_Click(object? sender, EventArgs e)
        {
            if (!ValidateCatch(out decimal length, out decimal weight))
            {
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

            LoadCatches(txtSearch.Text.Trim());

            txtSpecies.Clear();
            txtLocation.Clear();
            txtBait.Clear();
            txtLength.Clear();
            txtWeight.Clear();
            txtSpecies.Focus();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            LoadCatches(txtSearch.Text.Trim());
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            txtSearch.Clear();
            LoadCatches();
        }

        private void btnDeleteSelected_Click(object sender, EventArgs e)
        {
            if (dgvCatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a catch to delete.");
                return;
            }

            int catchID = Convert.ToInt32(
                dgvCatches.SelectedRows[0].Cells["CatchID"].Value
            );

            DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this catch?",
                "Confirm Delete",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    CatchDB.DeleteCatch(catchID);
                    LoadCatches(txtSearch.Text.Trim());
                }
                catch (SqlException)
                {
                    MessageBox.Show("Could not delete the catch.");
                }
            }
        }

        private void btnEditSelected_Click(object sender, EventArgs e)
        {
            if (dgvCatches.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a catch to edit.");
                return;
            }

            DataGridViewRow row = dgvCatches.SelectedRows[0];

            editingCatchID = Convert.ToInt32(row.Cells["CatchID"].Value);

            dtpCatchDate.Value = Convert.ToDateTime(row.Cells[0].Value);
            txtSpecies.Text = row.Cells[1].Value?.ToString() ?? "";
            txtLocation.Text = row.Cells[2].Value?.ToString() ?? "";
            txtBait.Text = row.Cells[3].Value?.ToString() ?? "";
            txtLength.Text = row.Cells[4].Value?.ToString() ?? "";
            txtWeight.Text = row.Cells[5].Value?.ToString() ?? "";

            btnSaveChanges.Enabled = true;
            btnAddCatch.Enabled = false;
            btnCancelEdit.Enabled = true;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            if (editingCatchID == null)
            {
                MessageBox.Show("Please select a catch to edit first.");
                return;
            }

            if (!ValidateCatch(out decimal length, out decimal weight))
            {
                return;
            }

            try
            {
                CatchDB.UpdateCatch(
                    editingCatchID.Value,
                    dtpCatchDate.Value.Date,
                    txtSpecies.Text.Trim(),
                    txtLocation.Text.Trim(),
                    txtBait.Text.Trim(),
                    length,
                    weight
                );
            }
            catch (SqlException)
            {
                MessageBox.Show(
                    "Could not update the catch. Please try again.",
                    "Database error"
                );
                return;
            }

            editingCatchID = null;
            btnSaveChanges.Enabled = false;
            btnAddCatch.Enabled = true;
            btnCancelEdit.Enabled = false;

            dgvCatches.ClearSelection();

            txtSpecies.Clear();
            txtLocation.Clear();
            txtBait.Clear();
            txtLength.Clear();
            txtWeight.Clear();

            LoadCatches(txtSearch.Text.Trim());

            MessageBox.Show("Catch updated successfully.");
        }

        private void btnCancelEdit_Click(object sender, EventArgs e)
        {
            editingCatchID = null;

            btnSaveChanges.Enabled = false;
            btnAddCatch.Enabled = true;
            btnCancelEdit.Enabled = false;

            dtpCatchDate.Value = DateTime.Today;

            txtSpecies.Clear();
            txtLocation.Clear();
            txtBait.Clear();
            txtLength.Clear();
            txtWeight.Clear();

            dgvCatches.ClearSelection();
            txtSpecies.Focus();
        }
    }
}
