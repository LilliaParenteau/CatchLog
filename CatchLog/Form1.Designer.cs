namespace CatchLog
{
    partial class Form1
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            lblCatchDate = new Label();
            dtpCatchDate = new DateTimePicker();
            lblSpecies = new Label();
            txtSpecies = new TextBox();
            lblLocation = new Label();
            lblBait = new Label();
            txtLocation = new TextBox();
            txtBait = new TextBox();
            lblLength = new Label();
            lblWeight = new Label();
            txtLength = new TextBox();
            txtWeight = new TextBox();
            btnAddCatch = new Button();
            dgvCatches = new DataGridView();
            CatchDate = new DataGridViewTextBoxColumn();
            Species = new DataGridViewTextBoxColumn();
            Location = new DataGridViewTextBoxColumn();
            Bait = new DataGridViewTextBoxColumn();
            Length = new DataGridViewTextBoxColumn();
            Weight = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvCatches).BeginInit();
            SuspendLayout();
            // 
            // lblCatchDate
            // 
            lblCatchDate.AutoSize = true;
            lblCatchDate.Location = new Point(19, 20);
            lblCatchDate.Margin = new Padding(1, 0, 1, 0);
            lblCatchDate.Name = "lblCatchDate";
            lblCatchDate.Size = new Size(80, 19);
            lblCatchDate.TabIndex = 0;
            lblCatchDate.Text = "Catch Date:";
            // 
            // dtpCatchDate
            // 
            dtpCatchDate.Format = DateTimePickerFormat.Short;
            dtpCatchDate.Location = new Point(101, 20);
            dtpCatchDate.Margin = new Padding(1);
            dtpCatchDate.Name = "dtpCatchDate";
            dtpCatchDate.Size = new Size(188, 25);
            dtpCatchDate.TabIndex = 1;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(21, 55);
            lblSpecies.Margin = new Padding(1, 0, 1, 0);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(56, 19);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(101, 55);
            txtSpecies.Margin = new Padding(1);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(188, 25);
            txtSpecies.TabIndex = 3;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(21, 93);
            lblLocation.Margin = new Padding(1, 0, 1, 0);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(64, 19);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location:";
            // 
            // lblBait
            // 
            lblBait.AutoSize = true;
            lblBait.Location = new Point(21, 133);
            lblBait.Margin = new Padding(1, 0, 1, 0);
            lblBait.Name = "lblBait";
            lblBait.Size = new Size(35, 19);
            lblBait.TabIndex = 5;
            lblBait.Text = "Bait:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(101, 93);
            txtLocation.Margin = new Padding(1);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(188, 25);
            txtLocation.TabIndex = 6;
            // 
            // txtBait
            // 
            txtBait.Location = new Point(101, 133);
            txtBait.Margin = new Padding(1);
            txtBait.Name = "txtBait";
            txtBait.Size = new Size(188, 25);
            txtBait.TabIndex = 7;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(19, 214);
            lblLength.Margin = new Padding(1, 0, 1, 0);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(78, 19);
            lblLength.TabIndex = 8;
            lblLength.Text = "Length (in):";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(19, 256);
            lblWeight.Margin = new Padding(1, 0, 1, 0);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(78, 19);
            lblWeight.TabIndex = 9;
            lblWeight.Text = "Weight (lb):";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(99, 214);
            txtLength.Margin = new Padding(1);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(90, 25);
            txtLength.TabIndex = 10;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(99, 256);
            txtWeight.Margin = new Padding(1);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(90, 25);
            txtWeight.TabIndex = 11;
            // 
            // btnAddCatch
            // 
            btnAddCatch.BackColor = SystemColors.Info;
            btnAddCatch.Cursor = Cursors.Hand;
            btnAddCatch.FlatStyle = FlatStyle.Flat;
            btnAddCatch.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddCatch.Location = new Point(149, 324);
            btnAddCatch.Margin = new Padding(1);
            btnAddCatch.Name = "btnAddCatch";
            btnAddCatch.Size = new Size(140, 28);
            btnAddCatch.TabIndex = 12;
            btnAddCatch.Text = "Add Catch";
            btnAddCatch.UseVisualStyleBackColor = false;
            btnAddCatch.Click += btnAddCatch_Click;
            // 
            // dgvCatches
            // 
            dgvCatches.AllowUserToAddRows = false;
            dgvCatches.AllowUserToDeleteRows = false;
            dgvCatches.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvCatches.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCatches.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvCatches.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvCatches.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCatches.Columns.AddRange(new DataGridViewColumn[] { CatchDate, Species, Location, Bait, Length, Weight });
            dgvCatches.Location = new Point(340, 20);
            dgvCatches.Margin = new Padding(1);
            dgvCatches.MultiSelect = false;
            dgvCatches.Name = "dgvCatches";
            dgvCatches.ReadOnly = true;
            dgvCatches.RowHeadersVisible = false;
            dgvCatches.RowHeadersWidth = 123;
            dgvCatches.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCatches.Size = new Size(640, 420);
            dgvCatches.TabIndex = 13;
            // 
            // CatchDate
            // 
            CatchDate.HeaderText = "Catch Date";
            CatchDate.MinimumWidth = 15;
            CatchDate.Name = "CatchDate";
            CatchDate.ReadOnly = true;
            // 
            // Species
            // 
            Species.HeaderText = "Species";
            Species.MinimumWidth = 15;
            Species.Name = "Species";
            Species.ReadOnly = true;
            // 
            // Location
            // 
            Location.HeaderText = "Location";
            Location.MinimumWidth = 15;
            Location.Name = "Location";
            Location.ReadOnly = true;
            // 
            // Bait
            // 
            Bait.HeaderText = "Bait";
            Bait.MinimumWidth = 15;
            Bait.Name = "Bait";
            Bait.ReadOnly = true;
            // 
            // Length
            // 
            Length.HeaderText = "Length (in)";
            Length.MinimumWidth = 15;
            Length.Name = "Length";
            Length.ReadOnly = true;
            // 
            // Weight
            // 
            Weight.HeaderText = "Weight (lb)";
            Weight.MinimumWidth = 15;
            Weight.Name = "Weight";
            Weight.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(1000, 460);
            Controls.Add(dgvCatches);
            Controls.Add(btnAddCatch);
            Controls.Add(txtWeight);
            Controls.Add(txtLength);
            Controls.Add(lblWeight);
            Controls.Add(lblLength);
            Controls.Add(txtBait);
            Controls.Add(txtLocation);
            Controls.Add(lblBait);
            Controls.Add(lblLocation);
            Controls.Add(txtSpecies);
            Controls.Add(lblSpecies);
            Controls.Add(dtpCatchDate);
            Controls.Add(lblCatchDate);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatchLog";
            ((System.ComponentModel.ISupportInitialize)dgvCatches).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCatchDate;
        private DateTimePicker dtpCatchDate;
        private Label lblSpecies;
        private TextBox txtSpecies;
        private Label lblLocation;
        private Label lblBait;
        private TextBox txtLocation;
        private TextBox txtBait;
        private Label lblLength;
        private Label lblWeight;
        private TextBox txtLength;
        private TextBox txtWeight;
        private Button btnAddCatch;
        private DataGridView dgvCatches;
        private DataGridViewTextBoxColumn CatchDate;
        private DataGridViewTextBoxColumn Species;
        private DataGridViewTextBoxColumn Location;
        private DataGridViewTextBoxColumn Bait;
        private DataGridViewTextBoxColumn Length;
        private DataGridViewTextBoxColumn Weight;
    }
}
