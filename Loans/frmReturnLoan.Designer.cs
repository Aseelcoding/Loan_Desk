namespace Loan_Desk.Loans
{
    partial class frmReturnLoan
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
            this.btnPayFine = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnSave = new ReaLTaiizor.Controls.LostCancelButton();
            this.toglPaymentStatus = new ReaLTaiizor.Controls.ToggleButton();
            this.bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            this.labFee = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            this.numOverdueDays = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            this.txtReturnDate = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            this.moonLabel3 = new ReaLTaiizor.Controls.MoonLabel();
            this.moonLabel2 = new ReaLTaiizor.Controls.MoonLabel();
            this.moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            this.txtDueDate = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.txtLoanDate = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.numQuantity = new ReaLTaiizor.Controls.CrownNumeric();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.txtLoanID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.txtEquipmentID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtBorrowerID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdueDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.btnPayFine);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.toglPaymentStatus);
            this.panel1.Controls.Add(this.bigLabel11);
            this.panel1.Controls.Add(this.labFee);
            this.panel1.Controls.Add(this.bigLabel9);
            this.panel1.Controls.Add(this.numOverdueDays);
            this.panel1.Controls.Add(this.bigLabel8);
            this.panel1.Controls.Add(this.txtReturnDate);
            this.panel1.Controls.Add(this.bigLabel7);
            this.panel1.Controls.Add(this.moonLabel3);
            this.panel1.Controls.Add(this.moonLabel2);
            this.panel1.Controls.Add(this.moonLabel1);
            this.panel1.Controls.Add(this.txtDueDate);
            this.panel1.Controls.Add(this.bigLabel6);
            this.panel1.Controls.Add(this.txtLoanDate);
            this.panel1.Controls.Add(this.bigLabel5);
            this.panel1.Controls.Add(this.numQuantity);
            this.panel1.Controls.Add(this.bigLabel4);
            this.panel1.Controls.Add(this.txtLoanID);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.txtEquipmentID);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.txtBorrowerID);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnPayFine
            // 
            this.btnPayFine.BackColor = System.Drawing.Color.SlateGray;
            this.btnPayFine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPayFine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayFine.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnPayFine.ForeColor = System.Drawing.Color.White;
            this.btnPayFine.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPayFine.Image = null;
            this.btnPayFine.Location = new System.Drawing.Point(426, 388);
            this.btnPayFine.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnPayFine.Name = "btnPayFine";
            this.btnPayFine.Size = new System.Drawing.Size(142, 62);
            this.btnPayFine.TabIndex = 117;
            this.btnPayFine.Text = "PAY FINE";
            this.btnPayFine.Click += new System.EventHandler(this.btnPayFine_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(0, 388);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5, 5, 10, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(322, 62);
            this.btnSave.TabIndex = 116;
            this.btnSave.Text = "CONFIRM RETURN";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toglPaymentStatus
            // 
            this.toglPaymentStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.toglPaymentStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toglPaymentStatus.Enabled = false;
            this.toglPaymentStatus.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toglPaymentStatus.Location = new System.Drawing.Point(633, 215);
            this.toglPaymentStatus.Margin = new System.Windows.Forms.Padding(5);
            this.toglPaymentStatus.Name = "toglPaymentStatus";
            this.toglPaymentStatus.Size = new System.Drawing.Size(76, 33);
            this.toglPaymentStatus.TabIndex = 115;
            this.toglPaymentStatus.Toggled = false;
            this.toglPaymentStatus.Type = ReaLTaiizor.Controls.ToggleButton._Type.CheckMark;
            // 
            // bigLabel11
            // 
            this.bigLabel11.AutoSize = true;
            this.bigLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel11.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel11.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel11.Location = new System.Drawing.Point(422, 221);
            this.bigLabel11.Name = "bigLabel11";
            this.bigLabel11.Size = new System.Drawing.Size(186, 23);
            this.bigLabel11.TabIndex = 114;
            this.bigLabel11.Text = "FINE PAYMENT STATUS";
            // 
            // labFee
            // 
            this.labFee.BackColor = System.Drawing.Color.Transparent;
            this.labFee.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.labFee.ForeColor = System.Drawing.Color.GreenYellow;
            this.labFee.Location = new System.Drawing.Point(624, 169);
            this.labFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFee.Name = "labFee";
            this.labFee.Size = new System.Drawing.Size(163, 41);
            this.labFee.TabIndex = 113;
            this.labFee.Text = "$250.00";
            this.labFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bigLabel9
            // 
            this.bigLabel9.AutoSize = true;
            this.bigLabel9.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel9.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel9.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel9.Location = new System.Drawing.Point(420, 178);
            this.bigLabel9.Name = "bigLabel9";
            this.bigLabel9.Size = new System.Drawing.Size(182, 23);
            this.bigLabel9.TabIndex = 112;
            this.bigLabel9.Text = "CALCULATED LATE FEE";
            // 
            // numOverdueDays
            // 
            this.numOverdueDays.Enabled = false;
            this.numOverdueDays.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numOverdueDays.Location = new System.Drawing.Point(564, 115);
            this.numOverdueDays.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numOverdueDays.Name = "numOverdueDays";
            this.numOverdueDays.ReadOnly = true;
            this.numOverdueDays.Size = new System.Drawing.Size(233, 26);
            this.numOverdueDays.TabIndex = 111;
            this.numOverdueDays.ThousandsSeparator = true;
            // 
            // bigLabel8
            // 
            this.bigLabel8.AutoSize = true;
            this.bigLabel8.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel8.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel8.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel8.Location = new System.Drawing.Point(420, 121);
            this.bigLabel8.Name = "bigLabel8";
            this.bigLabel8.Size = new System.Drawing.Size(131, 23);
            this.bigLabel8.TabIndex = 110;
            this.bigLabel8.Text = "OVERDUE DAYS";
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.txtReturnDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtReturnDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtReturnDate.Enabled = false;
            this.txtReturnDate.FocusOnHover = false;
            this.txtReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtReturnDate.Location = new System.Drawing.Point(563, 62);
            this.txtReturnDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnDate.MaxLength = 50;
            this.txtReturnDate.Multiline = false;
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.ReadOnly = true;
            this.txtReturnDate.Size = new System.Drawing.Size(233, 34);
            this.txtReturnDate.TabIndex = 109;
            this.txtReturnDate.Text = "RETURN DATE";
            this.txtReturnDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtReturnDate.UseSystemPasswordChar = false;
            // 
            // bigLabel7
            // 
            this.bigLabel7.AutoSize = true;
            this.bigLabel7.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel7.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel7.Location = new System.Drawing.Point(420, 71);
            this.bigLabel7.Name = "bigLabel7";
            this.bigLabel7.Size = new System.Drawing.Size(118, 23);
            this.bigLabel7.TabIndex = 108;
            this.bigLabel7.Text = "RETURN DATE";
            // 
            // moonLabel3
            // 
            this.moonLabel3.AutoSize = true;
            this.moonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moonLabel3.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel3.Location = new System.Drawing.Point(8, 345);
            this.moonLabel3.Name = "moonLabel3";
            this.moonLabel3.Size = new System.Drawing.Size(83, 25);
            this.moonLabel3.TabIndex = 107;
            this.moonLabel3.Text = "3.Action";
            // 
            // moonLabel2
            // 
            this.moonLabel2.AutoSize = true;
            this.moonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moonLabel2.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel2.Location = new System.Drawing.Point(410, 23);
            this.moonLabel2.Name = "moonLabel2";
            this.moonLabel2.Size = new System.Drawing.Size(205, 25);
            this.moonLabel2.TabIndex = 106;
            this.moonLabel2.Text = "2.Late Fee information";
            // 
            // moonLabel1
            // 
            this.moonLabel1.AutoSize = true;
            this.moonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.moonLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.moonLabel1.ForeColor = System.Drawing.Color.Gray;
            this.moonLabel1.Location = new System.Drawing.Point(8, 23);
            this.moonLabel1.Name = "moonLabel1";
            this.moonLabel1.Size = new System.Drawing.Size(225, 25);
            this.moonLabel1.TabIndex = 105;
            this.moonLabel1.Text = "1.Basic Loan information";
            // 
            // txtDueDate
            // 
            this.txtDueDate.BackColor = System.Drawing.Color.Transparent;
            this.txtDueDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtDueDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtDueDate.Enabled = false;
            this.txtDueDate.FocusOnHover = false;
            this.txtDueDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtDueDate.Location = new System.Drawing.Point(141, 285);
            this.txtDueDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDueDate.MaxLength = 50;
            this.txtDueDate.Multiline = false;
            this.txtDueDate.Name = "txtDueDate";
            this.txtDueDate.ReadOnly = true;
            this.txtDueDate.Size = new System.Drawing.Size(233, 34);
            this.txtDueDate.TabIndex = 104;
            this.txtDueDate.Text = "DUE DATE";
            this.txtDueDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDueDate.UseSystemPasswordChar = false;
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel6.Location = new System.Drawing.Point(7, 291);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(88, 23);
            this.bigLabel6.TabIndex = 103;
            this.bigLabel6.Text = "DUE DATE";
            // 
            // txtLoanDate
            // 
            this.txtLoanDate.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanDate.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtLoanDate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtLoanDate.Enabled = false;
            this.txtLoanDate.FocusOnHover = false;
            this.txtLoanDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLoanDate.Location = new System.Drawing.Point(141, 243);
            this.txtLoanDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanDate.MaxLength = 50;
            this.txtLoanDate.Multiline = false;
            this.txtLoanDate.Name = "txtLoanDate";
            this.txtLoanDate.ReadOnly = true;
            this.txtLoanDate.Size = new System.Drawing.Size(233, 34);
            this.txtLoanDate.TabIndex = 102;
            this.txtLoanDate.Text = "LOAN DATE";
            this.txtLoanDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoanDate.UseSystemPasswordChar = false;
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel5.Location = new System.Drawing.Point(7, 249);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(99, 23);
            this.bigLabel5.TabIndex = 101;
            this.bigLabel5.Text = "LOAN DATE";
            // 
            // numQuantity
            // 
            this.numQuantity.Enabled = false;
            this.numQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.numQuantity.Location = new System.Drawing.Point(141, 199);
            this.numQuantity.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.ReadOnly = true;
            this.numQuantity.Size = new System.Drawing.Size(233, 26);
            this.numQuantity.TabIndex = 100;
            this.numQuantity.ThousandsSeparator = true;
            this.numQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel4.Location = new System.Drawing.Point(7, 202);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(91, 23);
            this.bigLabel4.TabIndex = 99;
            this.bigLabel4.Text = "QUANTITY";
            // 
            // txtLoanID
            // 
            this.txtLoanID.BackColor = System.Drawing.Color.Transparent;
            this.txtLoanID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtLoanID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtLoanID.Enabled = false;
            this.txtLoanID.FocusOnHover = false;
            this.txtLoanID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtLoanID.Location = new System.Drawing.Point(141, 65);
            this.txtLoanID.Margin = new System.Windows.Forms.Padding(4);
            this.txtLoanID.MaxLength = 25;
            this.txtLoanID.Multiline = false;
            this.txtLoanID.Name = "txtLoanID";
            this.txtLoanID.ReadOnly = true;
            this.txtLoanID.Size = new System.Drawing.Size(233, 34);
            this.txtLoanID.TabIndex = 89;
            this.txtLoanID.Text = "LOAN ID";
            this.txtLoanID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtLoanID.UseSystemPasswordChar = false;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(7, 76);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(76, 23);
            this.bigLabel3.TabIndex = 88;
            this.bigLabel3.Text = "LOAN ID";
            // 
            // txtEquipmentID
            // 
            this.txtEquipmentID.BackColor = System.Drawing.Color.Transparent;
            this.txtEquipmentID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtEquipmentID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtEquipmentID.Enabled = false;
            this.txtEquipmentID.FocusOnHover = false;
            this.txtEquipmentID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtEquipmentID.Location = new System.Drawing.Point(141, 149);
            this.txtEquipmentID.Margin = new System.Windows.Forms.Padding(4);
            this.txtEquipmentID.MaxLength = 25;
            this.txtEquipmentID.Multiline = false;
            this.txtEquipmentID.Name = "txtEquipmentID";
            this.txtEquipmentID.ReadOnly = true;
            this.txtEquipmentID.Size = new System.Drawing.Size(233, 34);
            this.txtEquipmentID.TabIndex = 87;
            this.txtEquipmentID.Text = "EQUIPMENT ID";
            this.txtEquipmentID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEquipmentID.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(7, 160);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(127, 23);
            this.bigLabel2.TabIndex = 86;
            this.bigLabel2.Text = "EQUIPMENT ID";
            // 
            // txtBorrowerID
            // 
            this.txtBorrowerID.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowerID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBorrowerID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtBorrowerID.Enabled = false;
            this.txtBorrowerID.FocusOnHover = false;
            this.txtBorrowerID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBorrowerID.Location = new System.Drawing.Point(141, 107);
            this.txtBorrowerID.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrowerID.MaxLength = 25;
            this.txtBorrowerID.Multiline = false;
            this.txtBorrowerID.Name = "txtBorrowerID";
            this.txtBorrowerID.ReadOnly = true;
            this.txtBorrowerID.Size = new System.Drawing.Size(233, 34);
            this.txtBorrowerID.TabIndex = 85;
            this.txtBorrowerID.Text = "BORROWER ID";
            this.txtBorrowerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBorrowerID.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(7, 118);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(123, 23);
            this.bigLabel1.TabIndex = 84;
            this.bigLabel1.Text = "BORROWER ID";
            // 
            // frmReturnLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmReturnLoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReturn";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOverdueDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtBorrowerID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtLoanID;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.ForeverTextBox txtEquipmentID;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.CrownNumeric numQuantity;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.ForeverTextBox txtDueDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.ForeverTextBox txtLoanDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.CrownNumeric numOverdueDays;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.ForeverTextBox txtReturnDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.MoonLabel moonLabel3;
        private ReaLTaiizor.Controls.MoonLabel moonLabel2;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel labFee;
        private ReaLTaiizor.Controls.ToggleButton toglPaymentStatus;
        private ReaLTaiizor.Controls.LostCancelButton btnPayFine;
        private ReaLTaiizor.Controls.LostCancelButton btnSave;
    }
}