namespace Loan_Desk.Loans
{
    partial class frmAddLoan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnAdd = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnClose = new ReaLTaiizor.Controls.LostCancelButton();
            this.cmbEquipments = new System.Windows.Forms.ComboBox();
            this.cmbBorrowers = new System.Windows.Forms.ComboBox();
            this.numQuantity = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            this.numAvailableQuantity = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.cmbEquipments);
            this.panel2.Controls.Add(this.cmbBorrowers);
            this.panel2.Controls.Add(this.numQuantity);
            this.panel2.Controls.Add(this.bigLabel9);
            this.panel2.Controls.Add(this.numAvailableQuantity);
            this.panel2.Controls.Add(this.bigLabel3);
            this.panel2.Controls.Add(this.bigLabel6);
            this.panel2.Controls.Add(this.bigLabel7);
            this.panel2.Controls.Add(this.bigLabel8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 578);
            this.panel2.TabIndex = 103;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.SeaGreen;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.Image = null;
            this.btnAdd.Location = new System.Drawing.Point(0, 516);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 62);
            this.btnAdd.TabIndex = 107;
            this.btnAdd.Text = "SAVE";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(352, 516);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 62);
            this.btnClose.TabIndex = 106;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // cmbEquipments
            // 
            this.cmbEquipments.DropDownHeight = 180;
            this.cmbEquipments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEquipments.DropDownWidth = 280;
            this.cmbEquipments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbEquipments.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipments.FormattingEnabled = true;
            this.cmbEquipments.IntegralHeight = false;
            this.cmbEquipments.Location = new System.Drawing.Point(28, 257);
            this.cmbEquipments.Name = "cmbEquipments";
            this.cmbEquipments.Size = new System.Drawing.Size(373, 31);
            this.cmbEquipments.TabIndex = 105;
            this.cmbEquipments.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbEquipments_DrawItem);
            this.cmbEquipments.SelectedIndexChanged += new System.EventHandler(this.cmbEquipments_SelectedIndexChanged);
            // 
            // cmbBorrowers
            // 
            this.cmbBorrowers.DropDownHeight = 180;
            this.cmbBorrowers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBorrowers.DropDownWidth = 280;
            this.cmbBorrowers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBorrowers.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBorrowers.FormattingEnabled = true;
            this.cmbBorrowers.IntegralHeight = false;
            this.cmbBorrowers.ItemHeight = 23;
            this.cmbBorrowers.Location = new System.Drawing.Point(28, 151);
            this.cmbBorrowers.Name = "cmbBorrowers";
            this.cmbBorrowers.Size = new System.Drawing.Size(373, 31);
            this.cmbBorrowers.TabIndex = 104;
            this.cmbBorrowers.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmbBorrowers_DrawItem);
            this.cmbBorrowers.SelectedIndexChanged += new System.EventHandler(this.cmbBorrowers_SelectedIndexChanged);
            // 
            // numQuantity
            // 
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numQuantity.Location = new System.Drawing.Point(217, 418);
            this.numQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 26);
            this.numQuantity.TabIndex = 103;
            this.numQuantity.ThousandsSeparator = true;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bigLabel9
            // 
            this.bigLabel9.AutoSize = true;
            this.bigLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel9.Location = new System.Drawing.Point(14, 418);
            this.bigLabel9.Name = "bigLabel9";
            this.bigLabel9.Size = new System.Drawing.Size(91, 23);
            this.bigLabel9.TabIndex = 102;
            this.bigLabel9.Text = "QUANTITY";
            // 
            // numAvailableQuantity
            // 
            this.numAvailableQuantity.Enabled = false;
            this.numAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numAvailableQuantity.Location = new System.Drawing.Point(217, 370);
            this.numAvailableQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAvailableQuantity.Name = "numAvailableQuantity";
            this.numAvailableQuantity.ReadOnly = true;
            this.numAvailableQuantity.Size = new System.Drawing.Size(120, 26);
            this.numAvailableQuantity.TabIndex = 101;
            this.numAvailableQuantity.ThousandsSeparator = true;
            this.numAvailableQuantity.ValueChanged += new System.EventHandler(this.numAvailableQuantity_ValueChanged);
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(14, 370);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(178, 23);
            this.bigLabel3.TabIndex = 100;
            this.bigLabel3.Text = "AVAILABLE QUANTITY";
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bigLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel6.Location = new System.Drawing.Point(23, 226);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(107, 28);
            this.bigLabel6.TabIndex = 97;
            this.bigLabel6.Text = "Equipment";
            // 
            // bigLabel7
            // 
            this.bigLabel7.AutoSize = true;
            this.bigLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.bigLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel7.Location = new System.Drawing.Point(23, 119);
            this.bigLabel7.Name = "bigLabel7";
            this.bigLabel7.Size = new System.Drawing.Size(123, 28);
            this.bigLabel7.TabIndex = 94;
            this.bigLabel7.Text = "BORROWER ";
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel8.Location = new System.Drawing.Point(162, 9);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(204, 57);
            this.bigLabel8.TabIndex = 93;
            this.bigLabel8.Text = "Add Loan";
            // 
            // frmAddLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 578);
            this.Controls.Add(this.panel2);
            this.MaximumSize = new System.Drawing.Size(550, 625);
            this.MinimumSize = new System.Drawing.Size(550, 625);
            this.Name = "frmAddLoan";
            this.Text = "AddLoan";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private ReaLTaiizor.Controls.LostCancelButton btnAdd;
        private ReaLTaiizor.Controls.LostCancelButton btnClose;
        private System.Windows.Forms.ComboBox cmbEquipments;
        private System.Windows.Forms.ComboBox cmbBorrowers;
        private ReaLTaiizor.Controls.CrownNumeric numQuantity;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.CrownNumeric numAvailableQuantity;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
    }
}