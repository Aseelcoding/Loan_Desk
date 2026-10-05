namespace Loan_Desk.Users
{
    partial class frmUpdateUserPassword
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
            this.bigLabel5 = new ReaLTaiizor.Controls.BigLabel();
            this.txtOldPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            this.txtNewPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.txtConfirmPassword = new ReaLTaiizor.Controls.ForeverTextBox();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.btnSave = new ReaLTaiizor.Controls.LostCancelButton();
            this.btnClose = new ReaLTaiizor.Controls.LostCancelButton();
            this.aloneNotice1 = new ReaLTaiizor.Controls.AloneNotice();
            this.SuspendLayout();
            // 
            // bigLabel5
            // 
            this.bigLabel5.AutoSize = true;
            this.bigLabel5.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel5.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.bigLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel5.Location = new System.Drawing.Point(101, 9);
            this.bigLabel5.Name = "bigLabel5";
            this.bigLabel5.Size = new System.Drawing.Size(348, 57);
            this.bigLabel5.TabIndex = 77;
            this.bigLabel5.Text = "Update Password";
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtOldPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtOldPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtOldPassword.FocusOnHover = true;
            this.txtOldPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtOldPassword.Location = new System.Drawing.Point(160, 105);
            this.txtOldPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtOldPassword.MaxLength = 20;
            this.txtOldPassword.Multiline = false;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.ReadOnly = false;
            this.txtOldPassword.Size = new System.Drawing.Size(214, 34);
            this.txtOldPassword.TabIndex = 79;
            this.txtOldPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtOldPassword.UseSystemPasswordChar = true;
            // 
            // bigLabel4
            // 
            this.bigLabel4.AutoSize = true;
            this.bigLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel4.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel4.Location = new System.Drawing.Point(3, 111);
            this.bigLabel4.Name = "bigLabel4";
            this.bigLabel4.Size = new System.Drawing.Size(112, 23);
            this.bigLabel4.TabIndex = 78;
            this.bigLabel4.Text = "Old Password";
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtNewPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtNewPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtNewPassword.FocusOnHover = true;
            this.txtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtNewPassword.Location = new System.Drawing.Point(160, 154);
            this.txtNewPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtNewPassword.MaxLength = 20;
            this.txtNewPassword.Multiline = false;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.ReadOnly = false;
            this.txtNewPassword.Size = new System.Drawing.Size(214, 34);
            this.txtNewPassword.TabIndex = 81;
            this.txtNewPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNewPassword.UseSystemPasswordChar = true;
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel1.Location = new System.Drawing.Point(3, 160);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(119, 23);
            this.bigLabel1.TabIndex = 80;
            this.bigLabel1.Text = "New Password";
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.BackColor = System.Drawing.Color.Transparent;
            this.txtConfirmPassword.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtConfirmPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.txtConfirmPassword.FocusOnHover = true;
            this.txtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtConfirmPassword.Location = new System.Drawing.Point(160, 206);
            this.txtConfirmPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfirmPassword.MaxLength = 20;
            this.txtConfirmPassword.Multiline = false;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.ReadOnly = false;
            this.txtConfirmPassword.Size = new System.Drawing.Size(214, 34);
            this.txtConfirmPassword.TabIndex = 83;
            this.txtConfirmPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.bigLabel2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bigLabel2.Location = new System.Drawing.Point(3, 212);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(141, 23);
            this.bigLabel2.TabIndex = 82;
            this.bigLabel2.Text = "ConfirmPassword";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaGreen;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.Image = null;
            this.btnSave.Location = new System.Drawing.Point(1, 336);
            this.btnSave.Margin = new System.Windows.Forms.Padding(5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 62);
            this.btnSave.TabIndex = 89;
            this.btnSave.Text = "SAVE";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.HoverColor = System.Drawing.Color.MediumSeaGreen;
            this.btnClose.Image = null;
            this.btnClose.Location = new System.Drawing.Point(363, 336);
            this.btnClose.Margin = new System.Windows.Forms.Padding(5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(180, 62);
            this.btnClose.TabIndex = 88;
            this.btnClose.Text = "CLOSE";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // aloneNotice1
            // 
            this.aloneNotice1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(253)))), ((int)(((byte)(232)))));
            this.aloneNotice1.BorderColor = System.Drawing.Color.White;
            this.aloneNotice1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.aloneNotice1.Cursor = System.Windows.Forms.Cursors.Default;
            this.aloneNotice1.Enabled = false;
            this.aloneNotice1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(185)))), ((int)(((byte)(181)))), ((int)(((byte)(149)))));
            this.aloneNotice1.Location = new System.Drawing.Point(98, 268);
            this.aloneNotice1.Margin = new System.Windows.Forms.Padding(4);
            this.aloneNotice1.Multiline = true;
            this.aloneNotice1.Name = "aloneNotice1";
            this.aloneNotice1.ReadOnly = true;
            this.aloneNotice1.Size = new System.Drawing.Size(342, 59);
            this.aloneNotice1.TabIndex = 90;
            this.aloneNotice1.Text = "FIrst enter the Old password if it is the same.\r\n The password will be changed.";
            this.aloneNotice1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmUpdateUserPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ClientSize = new System.Drawing.Size(542, 399);
            this.Controls.Add(this.aloneNotice1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.bigLabel2);
            this.Controls.Add(this.txtNewPassword);
            this.Controls.Add(this.bigLabel1);
            this.Controls.Add(this.txtOldPassword);
            this.Controls.Add(this.bigLabel4);
            this.Controls.Add(this.bigLabel5);
            this.MaximumSize = new System.Drawing.Size(560, 446);
            this.MinimumSize = new System.Drawing.Size(560, 446);
            this.Name = "frmUpdateUserPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmUpdateUserPassword";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel5;
        private ReaLTaiizor.Controls.ForeverTextBox txtOldPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.ForeverTextBox txtNewPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtConfirmPassword;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.LostCancelButton btnSave;
        private ReaLTaiizor.Controls.LostCancelButton btnClose;
        private ReaLTaiizor.Controls.AloneNotice aloneNotice1;
    }
}