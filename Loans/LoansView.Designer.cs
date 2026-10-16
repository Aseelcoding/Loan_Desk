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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContentPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cbFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.chLost = new System.Windows.Forms.CheckBox();
            this.chReturned = new System.Windows.Forms.CheckBox();
            this.chActive = new System.Windows.Forms.CheckBox();
            this.dgvLo = new System.Windows.Forms.DataGridView();
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
            this.txtBarSearch = new ReaLTaiizor.Controls.BigTextBox();
            this.btnAddLoan = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContentPanel.Controls.Add(this.cbFilter);
            this.ContentPanel.Controls.Add(this.parrotGroupBox1);
            this.ContentPanel.Controls.Add(this.dgvLo);
            this.ContentPanel.Controls.Add(this.txtBarSearch);
            this.ContentPanel.Controls.Add(this.btnAddLoan);
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
            // cbFilter
            // 
            this.cbFilter.AutoResize = true;
            this.cbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilter.Depth = 0;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilter.DropDownHeight = 218;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 227;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Hint = "Filter";
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.ItemHeight = 54;
            this.cbFilter.Items.AddRange(new object[] {
            "ID",
            "Equipment ID",
            "Borrower ID ",
            "User ID",
            "Quantity",
            "Loaned At",
            "Due At",
            "Returned At ",
            "Status"});
            this.cbFilter.Location = new System.Drawing.Point(290, 27);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.MaxDropDownItems = 4;
            this.cbFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(227, 60);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 52;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.chLost);
            this.parrotGroupBox1.Controls.Add(this.chReturned);
            this.parrotGroupBox1.Controls.Add(this.chActive);
            this.parrotGroupBox1.Location = new System.Drawing.Point(620, 38);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.ShowText = false;
            this.parrotGroupBox1.Size = new System.Drawing.Size(230, 47);
            this.parrotGroupBox1.TabIndex = 51;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "parrotGroupBox1";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // chLost
            // 
            this.chLost.AutoSize = true;
            this.chLost.Location = new System.Drawing.Point(166, 18);
            this.chLost.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chLost.Name = "chLost";
            this.chLost.Size = new System.Drawing.Size(54, 20);
            this.chLost.TabIndex = 4;
            this.chLost.Text = "Lost";
            this.chLost.UseVisualStyleBackColor = true;
            this.chLost.CheckedChanged += new System.EventHandler(this.chLost_CheckedChanged);
            // 
            // chReturned
            // 
            this.chReturned.AutoSize = true;
            this.chReturned.Location = new System.Drawing.Point(76, 18);
            this.chReturned.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chReturned.Name = "chReturned";
            this.chReturned.Size = new System.Drawing.Size(84, 20);
            this.chReturned.TabIndex = 3;
            this.chReturned.Text = "Returned";
            this.chReturned.UseVisualStyleBackColor = true;
            this.chReturned.CheckedChanged += new System.EventHandler(this.chReturned_CheckedChanged);
            // 
            // chActive
            // 
            this.chActive.AutoSize = true;
            this.chActive.Location = new System.Drawing.Point(4, 18);
            this.chActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chActive.Name = "chActive";
            this.chActive.Size = new System.Drawing.Size(66, 20);
            this.chActive.TabIndex = 2;
            this.chActive.Text = "Active";
            this.chActive.UseVisualStyleBackColor = true;
            this.chActive.CheckedChanged += new System.EventHandler(this.chActive_CheckedChanged);
            // 
            // dgvLo
            // 
            this.dgvLo.AllowUserToAddRows = false;
            this.dgvLo.AllowUserToDeleteRows = false;
            this.dgvLo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvLo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLo.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvLo.Location = new System.Drawing.Point(3, 91);
            this.dgvLo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLo.MultiSelect = false;
            this.dgvLo.Name = "dgvLo";
            this.dgvLo.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLo.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvLo.RowHeadersWidth = 51;
            this.dgvLo.RowTemplate.Height = 24;
            this.dgvLo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLo.Size = new System.Drawing.Size(1000, 679);
            this.dgvLo.TabIndex = 50;
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
            // txtBarSearch
            // 
            this.txtBarSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBarSearch.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtBarSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtBarSearch.Image = null;
            this.txtBarSearch.Location = new System.Drawing.Point(4, 34);
            this.txtBarSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarSearch.MaxLength = 32767;
            this.txtBarSearch.Multiline = false;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.PlaceholderText = "Search Loan , Borrower or Item";
            this.txtBarSearch.ReadOnly = false;
            this.txtBarSearch.Size = new System.Drawing.Size(279, 42);
            this.txtBarSearch.TabIndex = 48;
            this.txtBarSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarSearch.UseSystemPasswordChar = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // btnAddLoan
            // 
            this.btnAddLoan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddLoan.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.btnAddLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddLoan.Location = new System.Drawing.Point(857, 50);
            this.btnAddLoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddLoan.Name = "btnAddLoan";
            this.btnAddLoan.Size = new System.Drawing.Size(132, 30);
            this.btnAddLoan.TabIndex = 47;
            this.btnAddLoan.Text = "Add Loan";
            this.btnAddLoan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddLoan.UseVisualStyleBackColor = false;
            this.btnAddLoan.Click += new System.EventHandler(this.btnAddLoan_Click);
            // 
            // LoansView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LoansView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private ReaLTaiizor.Controls.BigTextBox txtBarSearch;
        private System.Windows.Forms.Button btnAddLoan;
        private System.Windows.Forms.DataGridView dgvLo;
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
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private System.Windows.Forms.CheckBox chLost;
        private System.Windows.Forms.CheckBox chReturned;
        private System.Windows.Forms.CheckBox chActive;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilter;
    }
}
