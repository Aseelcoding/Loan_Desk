namespace Loan_Desk.Users
{
    partial class frmAddUser
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
            this.togIsActive = new ReaLTaiizor.Controls.ToggleButton();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.txtUserID = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtUsername = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.btnSave = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnClose = new ReaLTaiizor.Controls.LostCancelButton();
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.RadbtnAdmin = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.RadbtnStaff = new ReaLTaiizor.Controls.ParrotRadioButton();
            this.txtPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            this.SuspendLayout();
            // 
            // togIsActive
            // 
            this.togIsActive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.togIsActive.Location = new System.Drawing.Point(129, 269);
            this.togIsActive.Margin = new System.Windows.Forms.Padding(5);
            this.togIsActive.Name = "togIsActive";
            this.togIsActive.Size = new System.Drawing.Size(76, 33);
            this.togIsActive.TabIndex = 74;
            this.togIsActive.Toggled = false;
            this.togIsActive.Type = ReaLTaiizor.Controls.ToggleButton._Type.YesNo;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel3.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel3.Location = new System.Drawing.Point(6, 277);
            this.bigLabel3.Name = "bigLabel3";
            this.bigLabel3.Size = new System.Drawing.Size(85, 23);
            this.bigLabel3.TabIndex = 73;
            this.bigLabel3.Text = "IS ACTIVE";
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(4, 219);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(95, 23);
            this.bigLabel2.TabIndex = 71;
            this.bigLabel2.Text = "USER ROLE";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Transparent;
            this.txtUserID.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtUserID.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtUserID.Enabled = false;
            this.txtUserID.FocusOnHover = false;
            this.txtUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUserID.Location = new System.Drawing.Point(129, 79);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4);
            this.txtUserID.MaxLength = 25;
            this.txtUserID.Multiline = false;
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(269, 34);
            this.txtUserID.TabIndex = 69;
            this.txtUserID.Text = "USER ID";
            this.txtUserID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUserID.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(4, 85);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(72, 23);
            this.bigLabel1.TabIndex = 68;
            this.bigLabel1.Text = "USER ID";
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtUsername.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtUsername.FocusOnHover = true;
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtUsername.Location = new System.Drawing.Point(129, 121);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.MaxLength = 25;
            this.txtUsername.Multiline = false;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = false;
            this.txtUsername.Size = new System.Drawing.Size(269, 34);
            this.txtUsername.TabIndex = 67;
            this.txtUsername.Text = "Username";
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUsername.UseSystemPasswordChar = false;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel4.Location = new System.Drawing.Point(4, 127);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(98, 23);
            this.bigLabel4.TabIndex = 66;
            this.bigLabel4.Text = "USERNAME";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(-1, 340);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 62);
            this.btnSave.TabIndex = 65;
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
            this.btnClose.Location = new System.Drawing.Point(361, 340);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 62);
            this.btnClose.TabIndex = 64;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(157, 9);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(198, 57);
            this.bigLabel5.TabIndex = 75;
            this.bigLabel5.Text = "Add User";
            // 
            // RadbtnAdmin
            // 
            this.RadbtnAdmin.Checked = false;
            this.RadbtnAdmin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadbtnAdmin.ForeColor = System.Drawing.Color.White;
            this.RadbtnAdmin.Location = new System.Drawing.Point(129, 219);
            this.RadbtnAdmin.Name = "RadbtnAdmin";
            this.RadbtnAdmin.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.RadbtnAdmin.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RadbtnAdmin.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RadbtnAdmin.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.RadbtnAdmin.Size = new System.Drawing.Size(100, 23);
            this.RadbtnAdmin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.RadbtnAdmin.TabIndex = 76;
            this.RadbtnAdmin.Text = "Admin";
            this.RadbtnAdmin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // RadbtnStaff
            // 
            this.RadbtnStaff.Checked = true;
            this.RadbtnStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RadbtnStaff.ForeColor = System.Drawing.Color.White;
            this.RadbtnStaff.Location = new System.Drawing.Point(255, 219);
            this.RadbtnStaff.Name = "RadbtnStaff";
            this.RadbtnStaff.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.RadbtnStaff.RadioColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RadbtnStaff.RadioHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(76)))), ((int)(((byte)(85)))));
            this.RadbtnStaff.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            this.RadbtnStaff.Size = new System.Drawing.Size(100, 23);
            this.RadbtnStaff.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.RadbtnStaff.TabIndex = 77;
            this.RadbtnStaff.Text = "Staff";
            this.RadbtnStaff.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtPassword.FocusOnHover = true;
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtPassword.Location = new System.Drawing.Point(129, 163);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.MaxLength = 20;
            this.txtPassword.Multiline = false;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.ReadOnly = false;
            this.txtPassword.Size = new System.Drawing.Size(269, 34);
            this.txtPassword.TabIndex = 79;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // bigLabel6
            // 
            this.bigLabel6.AutoSize = true;
            this.bigLabel6.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel6.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel6.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel6.Location = new System.Drawing.Point(4, 169);
            this.bigLabel6.Name = "bigLabel6";
            this.bigLabel6.Size = new System.Drawing.Size(99, 23);
            this.bigLabel6.TabIndex = 78;
            this.bigLabel6.Text = "PASSWORD";
            // 
            // frmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.bigLabel6);
            this.Controls.Add(this.RadbtnStaff);
            this.Controls.Add(this.RadbtnAdmin);
            this.Controls.Add(this.bigLabel5);
            this.Controls.Add(this.togIsActive);
            this.Controls.Add(this.bigLabel3);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.bigLabel4);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.MaximumSize = new System.Drawing.Size(560, 446);
            this.MinimumSize = new System.Drawing.Size(560, 446);
            this.Name = "frmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.ToggleButton togIsActive;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverTextBox txtUserID;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtUsername;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.LostCancelButton btnSave;
        private ReaLTaiizor.Controls.LostCancelButton btnClose;
        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.ParrotRadioButton RadbtnAdmin;
        private ReaLTaiizor.Controls.ParrotRadioButton RadbtnStaff;
        private ReaLTaiizor.Controls.ForeverTextBox txtPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
    }
}