namespace Loan_Desk.Borrowers
{
    partial class frmAddNewBorrower
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
            this.panel1 = new ReaLTaiizor.Controls.Panel();
            this.aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            this.btnSave = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnClose = new ReaLTaiizor.Controls.LostCancelButton();
            this.togIsActive = new ReaLTaiizor.Controls.ToggleButton();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.txtPassport = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtFullName = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.txtUserID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.panel1.Controls.Add(this.aloneNotice1);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.togIsActive);
            this.panel1.Controls.Add(this.bigLabel3);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.bigLabel6);
            this.panel1.Controls.Add(this.txtPassport);
            this.panel1.Controls.Add(this.bigLabel2);
            this.panel1.Controls.Add(this.txtFullName);
            this.panel1.Controls.Add(this.bigLabel4);
            this.panel1.Controls.Add(this.txtUserID);
            this.panel1.Controls.Add(this.bigLabel1);
            this.panel1.Controls.Add(this.bigLabel5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(542, 399);
            this.panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.panel1.TabIndex = 0;
            this.panel1.Text = "panel1";
            // 
            // aloneNotice1
            // 
            this.aloneNotice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.aloneNotice1.BorderColor = System.Drawing.Color.White;
            this.aloneNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aloneNotice1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.aloneNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.aloneNotice1.Enabled = false;
            this.aloneNotice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            this.aloneNotice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.aloneNotice1.Location = new System.Drawing.Point(418, 170);
            this.aloneNotice1.Margin = new System.Windows.Forms.Padding(4);
            this.aloneNotice1.MaxLength = 20;
            this.aloneNotice1.Multiline = true;
            this.aloneNotice1.Name = "aloneNotice1";
            this.aloneNotice1.ReadOnly = true;
            this.aloneNotice1.Size = new System.Drawing.Size(111, 34);
            this.aloneNotice1.TabIndex = 94;
            this.aloneNotice1.Text = "UNIQUE";
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
            this.btnSave.Location = new System.Drawing.Point(-5, 337);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 62);
            this.btnSave.TabIndex = 93;
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
            this.btnClose.Location = new System.Drawing.Point(362, 337);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 62);
            this.btnClose.TabIndex = 92;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // togIsActive
            // 
            this.togIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togIsActive.Location = new System.Drawing.Point(148, 266);
            this.togIsActive.Margin = new System.Windows.Forms.Padding(5);
            this.togIsActive.Name = "togIsActive";
            this.togIsActive.Size = new System.Drawing.Size(76, 33);
            this.togIsActive.TabIndex = 91;
            this.togIsActive.Toggled = false;
            this.togIsActive.Type = ReaLTaiizor.Controls.ToggleButton._Type.YesNo;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(8, 271);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(85, 23);
            this.bigLabel3.TabIndex = 90;
            this.bigLabel3.Text = "IS ACTIVE";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtPhone.ForeColor = System.Drawing.Color.Silver;
            this.txtPhone.Location = new System.Drawing.Point(137, 221);
            this.txtPhone.Mask = "+(999) 000-000000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(269, 22);
            this.txtPhone.TabIndex = 89;
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel6.Location = new System.Drawing.Point(12, 221);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(67, 23);
            this.bigLabel6.TabIndex = 88;
            this.bigLabel6.Text = "PHONE";
            // 
            // txtPassport
            // 
            this.txtPassport.BackColor = System.Drawing.Color.Transparent;
            this.txtPassport.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtPassport.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtPassport.FocusOnHover = true;
            this.txtPassport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassport.Location = new System.Drawing.Point(137, 170);
            this.txtPassport.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassport.MaxLength = 25;
            this.txtPassport.Multiline = false;
            this.txtPassport.Name = "txtPassport";
            this.txtPassport.ReadOnly = false;
            this.txtPassport.Size = new System.Drawing.Size(269, 34);
            this.txtPassport.TabIndex = 87;
            this.txtPassport.Text = "A0000";
            this.txtPassport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassport.UseSystemPasswordChar = false;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(8, 176);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(89, 23);
            this.bigLabel2.TabIndex = 86;
            this.bigLabel2.Text = "PASSPORT";
            // 
            // txtFullName
            // 
            this.txtFullName.BackColor = System.Drawing.Color.Transparent;
            this.txtFullName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtFullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtFullName.FocusOnHover = true;
            this.txtFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtFullName.Location = new System.Drawing.Point(137, 130);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtFullName.MaxLength = 25;
            this.txtFullName.Multiline = false;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.ReadOnly = false;
            this.txtFullName.Size = new System.Drawing.Size(269, 34);
            this.txtFullName.TabIndex = 85;
            this.txtFullName.Text = "FULL NAME";
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.UseSystemPasswordChar = false;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel4.Location = new System.Drawing.Point(2, 136);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(99, 23);
            this.bigLabel4.TabIndex = 84;
            this.bigLabel4.Text = "FULL NAME";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Transparent;
            this.txtUserID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtUserID.Enabled = false;
            this.txtUserID.FocusOnHover = false;
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserID.Location = new System.Drawing.Point(137, 82);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.MaxLength = 25;
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(269, 34);
            this.txtUserID.TabIndex = 83;
            this.txtUserID.Text = "BORROWER ID";
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(0, 88);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(123, 23);
            this.bigLabel1.TabIndex = 82;
            this.bigLabel1.Text = "BORROWER ID";
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(110, 5);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(285, 57);
            this.bigLabel5.TabIndex = 81;
            this.bigLabel5.Text = "Add Borrower";
            // 
            // frmAddNewBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(560, 446);
            this.MinimumSize = new System.Drawing.Size(560, 446);
            this.Name = "frmAddNewBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewBorrower";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtUserID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.ForeverTextBox txtFullName;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.ForeverTextBox txtPassport;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.ToggleButton togIsActive;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.LostCancelButton btnSave;
        private ReaLTaiizor.Controls.LostCancelButton btnClose;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
    }
}