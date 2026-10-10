namespace Loan_Desk.Equipment
{
    partial class frmAddNewEquipment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            this.btnSave = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnClose = new ReaLTaiizor.Controls.LostCancelButton();
            this.togIsActive = new ReaLTaiizor.Controls.ToggleButton();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.txtEquipmentName = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtEquipmentID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.numTotalQuantity = new ReaLTaiizor.Controls.CrownNumeric();
            this.numAvailableQuantity = new ReaLTaiizor.Controls.CrownNumeric();
            this.numDailyLateFee = new ReaLTaiizor.Controls.CrownNumeric();
            this.numReplecmentCost = new ReaLTaiizor.Controls.CrownNumeric();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyLateFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReplecmentCost)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.numReplecmentCost);
            this.panel1.Controls.Add(this.numDailyLateFee);
            this.panel1.Controls.Add(this.numAvailableQuantity);
            this.panel1.Controls.Add(this.numTotalQuantity);
            this.panel1.Controls.Add(this.aloneNotice1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.togIsActive);
            this.panel1.Controls.Add(this.bigLabel8);
            this.panel1.Controls.Add(this.bigLabel7);
            this.panel1.Controls.Add(this.bigLabel6);
            this.panel1.Controls.Add(this.bigLabel4);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.txtEquipmentName);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.txtEquipmentID);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.bigLabel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 578);
            this.panel1.TabIndex = 0;
            // 
            // aloneNotice1
            // 
            this.aloneNotice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.aloneNotice1.BorderColor = System.Drawing.Color.White;
            this.aloneNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aloneNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.aloneNotice1.Enabled = false;
            this.aloneNotice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.aloneNotice1.Location = new System.Drawing.Point(475, 159);
            this.aloneNotice1.Margin = new System.Windows.Forms.Padding(4);
            this.aloneNotice1.Multiline = true;
            this.aloneNotice1.Name = "aloneNotice1";
            this.aloneNotice1.ReadOnly = true;
            this.aloneNotice1.Size = new System.Drawing.Size(97, 38);
            this.aloneNotice1.TabIndex = 91;
            this.aloneNotice1.Text = "unique";
            this.aloneNotice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(0, 516);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 62);
            this.btnSave.TabIndex = 90;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(392, 516);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 62);
            this.btnClose.TabIndex = 89;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // togIsActive
            // 
            this.togIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togIsActive.Location = new System.Drawing.Point(196, 415);
            this.togIsActive.Margin = new System.Windows.Forms.Padding(5);
            this.togIsActive.Name = "togIsActive";
            this.togIsActive.Size = new System.Drawing.Size(76, 33);
            this.togIsActive.TabIndex = 88;
            this.togIsActive.Toggled = true;
            this.togIsActive.Type = ReaLTaiizor.Controls.ToggleButton._Type.YesNo;
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel8.Location = new System.Drawing.Point(12, 425);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(85, 23);
            this.bigLabel8.TabIndex = 87;
            this.bigLabel8.Text = "IS ACTIVE";
            // 
            // bigLabel7
            // 
            this.bigLabel7.AutoSize = true;
            this.bigLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel7.Location = new System.Drawing.Point(12, 368);
            this.bigLabel7.Name = "bigLabel7";
            this.bigLabel7.Size = new System.Drawing.Size(160, 23);
            this.bigLabel7.TabIndex = 86;
            this.bigLabel7.Text = "REPLECMENT COST";
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel6.Location = new System.Drawing.Point(12, 321);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(126, 23);
            this.bigLabel6.TabIndex = 85;
            this.bigLabel6.Text = "DAILY LATE FEE";
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel4.Location = new System.Drawing.Point(12, 274);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(178, 23);
            this.bigLabel4.TabIndex = 83;
            this.bigLabel4.Text = "AVAILABLE QUANTITY";
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(12, 230);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(143, 23);
            this.bigLabel3.TabIndex = 81;
            this.bigLabel3.Text = "TOTAL QUANTITY";
            // 
            // txtEquipmentName
            // 
            this.txtEquipmentName.BackColor = System.Drawing.Color.Transparent;
            this.txtEquipmentName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtEquipmentName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtEquipmentName.FocusOnHover = true;
            this.txtEquipmentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEquipmentName.Location = new System.Drawing.Point(198, 161);
            this.txtEquipmentName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentName.MaxLength = 250;
            this.txtEquipmentName.Multiline = false;
            this.txtEquipmentName.Name = "txtEquipmentName";
            this.txtEquipmentName.ReadOnly = false;
            this.txtEquipmentName.Size = new System.Drawing.Size(269, 34);
            this.txtEquipmentName.TabIndex = 80;
            this.txtEquipmentName.Text = "EQUIPMENT NAME";
            this.txtEquipmentName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEquipmentName.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(12, 167);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(158, 23);
            this.bigLabel2.TabIndex = 79;
            this.bigLabel2.Text = "EQUIPMENT NAME";
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.BackColor = System.Drawing.Color.Transparent;
            this.txtEquipmentID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtEquipmentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtEquipmentID.Enabled = false;
            this.txtEquipmentID.FocusOnHover = false;
            this.txtEquipmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEquipmentID.Location = new System.Drawing.Point(196, 106);
            this.txtEquipmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentID.MaxLength = 25;
            this.txtEquipmentID.Multiline = false;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.ReadOnly = true;
            this.txtEquipmentID.Size = new System.Drawing.Size(269, 34);
            this.txtEquipmentID.TabIndex = 78;
            this.txtEquipmentID.Text = "EQUIPMENT ID";
            this.txtEquipmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEquipmentID.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(12, 112);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(127, 23);
            this.bigLabel1.TabIndex = 77;
            this.bigLabel1.Text = "EQUIPMENT ID";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(133, 9);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(315, 57);
            this.bigLabel5.TabIndex = 76;
            this.bigLabel5.Text = "Add Equipment";
            // 
            // numTotalQuantity
            // 
            this.numTotalQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numTotalQuantity.Location = new System.Drawing.Point(204, 230);
            this.numTotalQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotalQuantity.Name = "numTotalQuantity";
            this.numTotalQuantity.Size = new System.Drawing.Size(120, 26);
            this.numTotalQuantity.TabIndex = 98;
            this.numTotalQuantity.ThousandsSeparator = true;
            this.numTotalQuantity.ValueChanged += new System.EventHandler(this.numTotalQuantity_ValueChanged);
            // 
            // numAvailableQuantity
            // 
            this.numAvailableQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numAvailableQuantity.Location = new System.Drawing.Point(204, 274);
            this.numAvailableQuantity.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAvailableQuantity.Name = "numAvailableQuantity";
            this.numAvailableQuantity.Size = new System.Drawing.Size(120, 26);
            this.numAvailableQuantity.TabIndex = 99;
            this.numAvailableQuantity.ThousandsSeparator = true;
            this.numAvailableQuantity.ValueChanged += new System.EventHandler(this.numAvailableQuantity_ValueChanged);
            // 
            // numDailyLateFee
            // 
            this.numDailyLateFee.DecimalPlaces = 6;
            this.numDailyLateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numDailyLateFee.Location = new System.Drawing.Point(204, 319);
            this.numDailyLateFee.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numDailyLateFee.Name = "numDailyLateFee";
            this.numDailyLateFee.Size = new System.Drawing.Size(120, 26);
            this.numDailyLateFee.TabIndex = 100;
            // 
            // numReplecmentCost
            // 
            this.numReplecmentCost.DecimalPlaces = 6;
            this.numReplecmentCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numReplecmentCost.Location = new System.Drawing.Point(204, 365);
            this.numReplecmentCost.Maximum = new decimal(new int[] {
            50000,
            0,
            0,
            0});
            this.numReplecmentCost.Name = "numReplecmentCost";
            this.numReplecmentCost.Size = new System.Drawing.Size(120, 26);
            this.numReplecmentCost.TabIndex = 101;
            // 
            // frmAddNewEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 578);
            this.Controls.Add(this.panel1);
            this.Name = "frmAddNewEquipment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Equipment";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDailyLateFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numReplecmentCost)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.ForeverTextBox txtEquipmentName;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverTextBox txtEquipmentID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.ToggleButton togIsActive;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.LostCancelButton btnSave;
        private ReaLTaiizor.Controls.LostCancelButton btnClose;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
        private ReaLTaiizor.Controls.CrownNumeric numAvailableQuantity;
        private ReaLTaiizor.Controls.CrownNumeric numTotalQuantity;
        private ReaLTaiizor.Controls.CrownNumeric numReplecmentCost;
        private ReaLTaiizor.Controls.CrownNumeric numDailyLateFee;
    }
}