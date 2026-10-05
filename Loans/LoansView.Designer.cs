namespace Loan_Desk.Loans
{
    partial class LoansView
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContentPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BorrowerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoanedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FinePaid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.foreverRadioButton2 = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.foreverRadioButton1 = new ReaLTaiizor.Controls.ForeverRadioButton();
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.parrotGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContentPanel.Controls.Add(this.dataGridView1);
            this.ContentPanel.Controls.Add(this.parrotGroupBox1);
            this.ContentPanel.Controls.Add(this.bigTextBox1);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.ContentPanel.Location = new System.Drawing.Point(0, 0);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.ContentPanel.PrimerColor = System.Drawing.Color.White;
            this.ContentPanel.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.ContentPanel.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ContentPanel.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EquipmentID,
            this.BorrowerID,
            this.UserID,
            this.Quantity,
            this.LoanedAt,
            this.DueAt,
            this.ReturnedAt,
            this.Status,
            this.LateFee,
            this.FinePaid});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(3, 91);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 679);
            this.dataGridView1.TabIndex = 50;
            // 
            // ID
            // 
            this.ID.HeaderText = "Loan ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EquipmentID
            // 
            this.EquipmentID.HeaderText = "Equipment ID";
            this.EquipmentID.MinimumWidth = 6;
            this.EquipmentID.Name = "EquipmentID";
            this.EquipmentID.ReadOnly = true;
            // 
            // BorrowerID
            // 
            this.BorrowerID.HeaderText = "Borrower ID";
            this.BorrowerID.MinimumWidth = 6;
            this.BorrowerID.Name = "BorrowerID";
            this.BorrowerID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // LoanedAt
            // 
            this.LoanedAt.HeaderText = "Loaned At";
            this.LoanedAt.MinimumWidth = 6;
            this.LoanedAt.Name = "LoanedAt";
            this.LoanedAt.ReadOnly = true;
            // 
            // DueAt
            // 
            this.DueAt.HeaderText = "Due At";
            this.DueAt.MinimumWidth = 6;
            this.DueAt.Name = "DueAt";
            this.DueAt.ReadOnly = true;
            // 
            // ReturnedAt
            // 
            this.ReturnedAt.HeaderText = "Returned At";
            this.ReturnedAt.MinimumWidth = 6;
            this.ReturnedAt.Name = "ReturnedAt";
            this.ReturnedAt.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // LateFee
            // 
            this.LateFee.HeaderText = "Late Fee";
            this.LateFee.MinimumWidth = 6;
            this.LateFee.Name = "LateFee";
            this.LateFee.ReadOnly = true;
            // 
            // FinePaid
            // 
            this.FinePaid.HeaderText = "Fine Paid";
            this.FinePaid.MinimumWidth = 6;
            this.FinePaid.Name = "FinePaid";
            this.FinePaid.ReadOnly = true;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.foreverRadioButton2);
            this.parrotGroupBox1.Controls.Add(this.foreverRadioButton1);
            this.parrotGroupBox1.Location = new System.Drawing.Point(345, 38);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parrotGroupBox1.ShowText = false;
            this.parrotGroupBox1.Size = new System.Drawing.Size(267, 47);
            this.parrotGroupBox1.TabIndex = 49;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "parrotGroupBox1";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // foreverRadioButton2
            // 
            this.foreverRadioButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverRadioButton2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverRadioButton2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverRadioButton2.Checked = false;
            this.foreverRadioButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverRadioButton2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverRadioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverRadioButton2.Location = new System.Drawing.Point(136, 12);
            this.foreverRadioButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foreverRadioButton2.Name = "foreverRadioButton2";
            this.foreverRadioButton2.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.foreverRadioButton2.Size = new System.Drawing.Size(99, 22);
            this.foreverRadioButton2.TabIndex = 2;
            this.foreverRadioButton2.Text = "InActive";
            // 
            // foreverRadioButton1
            // 
            this.foreverRadioButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.foreverRadioButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.foreverRadioButton1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.foreverRadioButton1.Checked = false;
            this.foreverRadioButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foreverRadioButton1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.foreverRadioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.foreverRadioButton1.Location = new System.Drawing.Point(9, 12);
            this.foreverRadioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foreverRadioButton1.Name = "foreverRadioButton1";
            this.foreverRadioButton1.Options = ReaLTaiizor.Controls.ForeverRadioButton._Options.Style1;
            this.foreverRadioButton1.Size = new System.Drawing.Size(99, 22);
            this.foreverRadioButton1.TabIndex = 1;
            this.foreverRadioButton1.Text = "Active";
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bigTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(4, 34);
            this.bigTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(333, 46);
            this.bigTextBox1.TabIndex = 48;
            this.bigTextBox1.Text = "Search Loan , Borrower or Item";
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(857, 50);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 47;
            this.button1.Text = "Add Loan";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // LoansView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "LoansView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.parrotGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.ForeverRadioButton foreverRadioButton2;
        private ReaLTaiizor.Controls.ForeverRadioButton foreverRadioButton1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoanedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReturnedAt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn LateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn FinePaid;
    }
}
