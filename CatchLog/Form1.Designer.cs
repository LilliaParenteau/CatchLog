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
            SuspendLayout();
            // 
            // lblCatchDate
            // 
            lblCatchDate.AutoSize = true;
            lblCatchDate.Location = new Point(26, 41);
            lblCatchDate.Name = "lblCatchDate";
            lblCatchDate.Size = new Size(201, 48);
            lblCatchDate.TabIndex = 0;
            lblCatchDate.Text = "Catch Date:";
            // 
            // dtpCatchDate
            // 
            dtpCatchDate.Format = DateTimePickerFormat.Short;
            dtpCatchDate.Location = new Point(236, 41);
            dtpCatchDate.Name = "dtpCatchDate";
            dtpCatchDate.Size = new Size(440, 55);
            dtpCatchDate.TabIndex = 1;
            // 
            // lblSpecies
            // 
            lblSpecies.AutoSize = true;
            lblSpecies.Location = new Point(26, 126);
            lblSpecies.Name = "lblSpecies";
            lblSpecies.Size = new Size(147, 48);
            lblSpecies.TabIndex = 2;
            lblSpecies.Text = "Species:";
            // 
            // txtSpecies
            // 
            txtSpecies.Location = new Point(236, 126);
            txtSpecies.Name = "txtSpecies";
            txtSpecies.Size = new Size(440, 55);
            txtSpecies.TabIndex = 3;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Location = new Point(26, 212);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(163, 48);
            lblLocation.TabIndex = 4;
            lblLocation.Text = "Location:";
            // 
            // lblBait
            // 
            lblBait.AutoSize = true;
            lblBait.Location = new Point(26, 297);
            lblBait.Name = "lblBait";
            lblBait.Size = new Size(88, 48);
            lblBait.TabIndex = 5;
            lblBait.Text = "Bait:";
            // 
            // txtLocation
            // 
            txtLocation.Location = new Point(236, 212);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(440, 55);
            txtLocation.TabIndex = 6;
            // 
            // txtBait
            // 
            txtBait.Location = new Point(236, 297);
            txtBait.Name = "txtBait";
            txtBait.Size = new Size(440, 55);
            txtBait.TabIndex = 7;
            // 
            // lblLength
            // 
            lblLength.AutoSize = true;
            lblLength.Location = new Point(23, 441);
            lblLength.Name = "lblLength";
            lblLength.Size = new Size(198, 48);
            lblLength.TabIndex = 8;
            lblLength.Text = "Length (in):";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(23, 519);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(204, 48);
            lblWeight.TabIndex = 9;
            lblWeight.Text = "Weight (lb):";
            // 
            // txtLength
            // 
            txtLength.Location = new Point(236, 441);
            txtLength.Name = "txtLength";
            txtLength.Size = new Size(203, 55);
            txtLength.TabIndex = 10;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(236, 519);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(203, 55);
            txtWeight.TabIndex = 11;
            // 
            // btnAddCatch
            // 
            btnAddCatch.Location = new Point(367, 660);
            btnAddCatch.Name = "btnAddCatch";
            btnAddCatch.Size = new Size(309, 69);
            btnAddCatch.TabIndex = 12;
            btnAddCatch.Text = "Add Catch";
            btnAddCatch.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(20F, 48F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(735, 760);
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
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CatchLog";
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
    }
}
