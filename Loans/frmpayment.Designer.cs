namespace Loan_Desk.Loans
{
    partial class frmpayment
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
            this.lostPanel2 = new ReaLTaiizor.Controls.LostPanel();
            this.labFee = new ReaLTaiizor.Controls.BigLabel();
            this.btnConfirm = new ReaLTaiizor.Controls.HopeButton();
            this.btnCancel = new ReaLTaiizor.Controls.HopeButton();
            this.foreverLabel5 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverTextBox3 = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverLabel2 = new ReaLTaiizor.Controls.ForeverLabel();
            this.foreverTextBox2 = new ReaLTaiizor.Controls.ForeverTextBox();
            this.foreverLabel1 = new ReaLTaiizor.Controls.ForeverLabel();
            this.txtBorrowerName = new ReaLTaiizor.Controls.ForeverTextBox();
            this.lostPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lostPanel2
            // 
            this.lostPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.lostPanel2.Controls.Add(this.labFee);
            this.lostPanel2.Controls.Add(this.btnConfirm);
            this.lostPanel2.Controls.Add(this.btnCancel);
            this.lostPanel2.Controls.Add(this.foreverLabel5);
            this.lostPanel2.Controls.Add(this.foreverTextBox3);
            this.lostPanel2.Controls.Add(this.foreverLabel2);
            this.lostPanel2.Controls.Add(this.foreverTextBox2);
            this.lostPanel2.Controls.Add(this.foreverLabel1);
            this.lostPanel2.Controls.Add(this.txtBorrowerName);
            this.lostPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lostPanel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lostPanel2.ForeColor = System.Drawing.Color.White;
            this.lostPanel2.Location = new System.Drawing.Point(0, 0);
            this.lostPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.lostPanel2.Name = "lostPanel2";
            this.lostPanel2.Padding = new System.Windows.Forms.Padding(6);
            this.lostPanel2.ShowText = false;
            this.lostPanel2.Size = new System.Drawing.Size(800, 450);
            this.lostPanel2.TabIndex = 3;
            this.lostPanel2.Text = "lostPanel2";
            // 
            // labFee
            // 
            this.labFee.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labFee.BackColor = System.Drawing.Color.Transparent;
            this.labFee.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.labFee.ForeColor = System.Drawing.Color.GreenYellow;
            this.labFee.Location = new System.Drawing.Point(113, 21);
            this.labFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labFee.Name = "labFee";
            this.labFee.Size = new System.Drawing.Size(560, 58);
            this.labFee.TabIndex = 17;
            this.labFee.Text = "$250.00";
            this.labFee.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnConfirm.ButtonType = ReaLTaiizor.Util.HopeButtonType.Warning;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnConfirm.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnConfirm.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnConfirm.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnConfirm.Location = new System.Drawing.Point(651, 365);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(4);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnConfirm.Size = new System.Drawing.Size(145, 50);
            this.btnConfirm.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnConfirm.TabIndex = 16;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.TextColor = System.Drawing.Color.White;
            this.btnConfirm.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.btnCancel.ButtonType = ReaLTaiizor.Util.HopeButtonType.Danger;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.btnCancel.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnCancel.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.btnCancel.Location = new System.Drawing.Point(0, 365);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.btnCancel.Size = new System.Drawing.Size(145, 50);
            this.btnCancel.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "BACK";
            this.btnCancel.TextColor = System.Drawing.Color.White;
            this.btnCancel.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            // 
            // foreverLabel5
            // 
            this.foreverLabel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(40)))));
            this.foreverLabel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.foreverLabel5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.foreverLabel5.ForeColor = System.Drawing.Color.Silver;
            this.foreverLabel5.Location = new System.Drawing.Point(0, 419);
            this.foreverLabel5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreverLabel5.Name = "foreverLabel5";
            this.foreverLabel5.Size = new System.Drawing.Size(800, 31);
            this.foreverLabel5.TabIndex = 13;
            this.foreverLabel5.Text = "All your information is safe. You can read Terms of Service and our Privacy Polic" +
    "y.";
            this.foreverLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // foreverTextBox3
            // 
            this.foreverTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBox3.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.foreverTextBox3.FocusOnHover = false;
            this.foreverTextBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBox3.Location = new System.Drawing.Point(460, 196);
            this.foreverTextBox3.Margin = new System.Windows.Forms.Padding(4);
            this.foreverTextBox3.MaxLength = 3;
            this.foreverTextBox3.Multiline = false;
            this.foreverTextBox3.Name = "foreverTextBox3";
            this.foreverTextBox3.ReadOnly = false;
            this.foreverTextBox3.Size = new System.Drawing.Size(39, 34);
            this.foreverTextBox3.TabIndex = 4;
            this.foreverTextBox3.Text = "304";
            this.foreverTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBox3.UseSystemPasswordChar = false;
            // 
            // foreverLabel2
            // 
            this.foreverLabel2.AutoSize = true;
            this.foreverLabel2.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverLabel2.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel2.Location = new System.Drawing.Point(299, 166);
            this.foreverLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreverLabel2.Name = "foreverLabel2";
            this.foreverLabel2.Size = new System.Drawing.Size(204, 28);
            this.foreverLabel2.TabIndex = 3;
            this.foreverLabel2.Text = "Card Number -     CVC";
            // 
            // foreverTextBox2
            // 
            this.foreverTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.foreverTextBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverTextBox2.BorderColor = System.Drawing.Color.Yellow;
            this.foreverTextBox2.FocusOnHover = false;
            this.foreverTextBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.foreverTextBox2.Location = new System.Drawing.Point(285, 196);
            this.foreverTextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.foreverTextBox2.MaxLength = 25;
            this.foreverTextBox2.Multiline = false;
            this.foreverTextBox2.Name = "foreverTextBox2";
            this.foreverTextBox2.ReadOnly = false;
            this.foreverTextBox2.Size = new System.Drawing.Size(168, 34);
            this.foreverTextBox2.TabIndex = 2;
            this.foreverTextBox2.Text = "1355 1489 3219 9841";
            this.foreverTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.foreverTextBox2.UseSystemPasswordChar = false;
            // 
            // foreverLabel1
            // 
            this.foreverLabel1.AutoSize = true;
            this.foreverLabel1.BackColor = System.Drawing.Color.Transparent;
            this.foreverLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.foreverLabel1.ForeColor = System.Drawing.Color.LightGray;
            this.foreverLabel1.Location = new System.Drawing.Point(308, 90);
            this.foreverLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.foreverLabel1.Name = "foreverLabel1";
            this.foreverLabel1.Size = new System.Drawing.Size(167, 28);
            this.foreverLabel1.TabIndex = 1;
            this.foreverLabel1.Text = "Cardholder Name";
            // 
            // txtBorrowerName
            // 
            this.txtBorrowerName.BackColor = System.Drawing.Color.Transparent;
            this.txtBorrowerName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.txtBorrowerName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.txtBorrowerName.FocusOnHover = false;
            this.txtBorrowerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txtBorrowerName.Location = new System.Drawing.Point(290, 120);
            this.txtBorrowerName.Margin = new System.Windows.Forms.Padding(4);
            this.txtBorrowerName.MaxLength = 100;
            this.txtBorrowerName.Multiline = false;
            this.txtBorrowerName.Name = "txtBorrowerName";
            this.txtBorrowerName.ReadOnly = false;
            this.txtBorrowerName.Size = new System.Drawing.Size(202, 34);
            this.txtBorrowerName.TabIndex = 0;
            this.txtBorrowerName.Text = "John Doe";
            this.txtBorrowerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBorrowerName.UseSystemPasswordChar = false;
            // 
            // frmpayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lostPanel2);
            this.MaximumSize = new System.Drawing.Size(818, 497);
            this.MinimumSize = new System.Drawing.Size(818, 497);
            this.Name = "frmpayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmpayment";
            this.lostPanel2.ResumeLayout(false);
            this.lostPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.LostPanel lostPanel2;
        private ReaLTaiizor.Controls.BigLabel labFee;
        private ReaLTaiizor.Controls.HopeButton btnConfirm;
        private ReaLTaiizor.Controls.HopeButton btnCancel;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel5;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox3;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel2;
        private ReaLTaiizor.Controls.ForeverTextBox foreverTextBox2;
        private ReaLTaiizor.Controls.ForeverLabel foreverLabel1;
        private ReaLTaiizor.Controls.ForeverTextBox txtBorrowerName;
    }
}