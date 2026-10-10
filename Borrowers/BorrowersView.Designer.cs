namespace Loan_Desk.Borrowers
{
    partial class BorrowersView
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
            this.cbFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.chInActive = new System.Windows.Forms.CheckBox();
            this.chActive = new System.Windows.Forms.CheckBox();
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.btnAddBorrower = new System.Windows.Forms.Button();
            this.dgvB = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveLoans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnpaidFines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContextOperation = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            this.btnUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.btnDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.ContentPanel.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).BeginInit();
            this.ContextOperation.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContentPanel.Controls.Add(this.cbFilter);
            this.ContentPanel.Controls.Add(this.parrotGroupBox1);
            this.ContentPanel.Controls.Add(this.bigTextBox1);
            this.ContentPanel.Controls.Add(this.btnAddBorrower);
            this.ContentPanel.Controls.Add(this.dgvB);
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
            this.cbFilter.DropDownWidth = 146;
            this.cbFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbFilter.FormattingEnabled = true;
            this.cbFilter.Hint = "Filter";
            this.cbFilter.IntegralHeight = false;
            this.cbFilter.ItemHeight = 54;
            this.cbFilter.Items.AddRange(new object[] {
            "Borrower ID",
            "Name",
            "Passport",
            "Phone"});
            this.cbFilter.Location = new System.Drawing.Point(348, 27);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.MaxDropDownItems = 4;
            this.cbFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(146, 60);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 50;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.chInActive);
            this.parrotGroupBox1.Controls.Add(this.chActive);
            this.parrotGroupBox1.Location = new System.Drawing.Point(541, 39);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.ShowText = false;
            this.parrotGroupBox1.Size = new System.Drawing.Size(252, 47);
            this.parrotGroupBox1.TabIndex = 49;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "parrotGroupBox1";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // chInActive
            // 
            this.chInActive.AutoSize = true;
            this.chInActive.Location = new System.Drawing.Point(135, 14);
            this.chInActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chInActive.Name = "chInActive";
            this.chInActive.Size = new System.Drawing.Size(76, 20);
            this.chInActive.TabIndex = 2;
            this.chInActive.Text = "InActive";
            this.chInActive.UseVisualStyleBackColor = true;
            // 
            // chActive
            // 
            this.chActive.AutoSize = true;
            this.chActive.Location = new System.Drawing.Point(19, 14);
            this.chActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chActive.Name = "chActive";
            this.chActive.Size = new System.Drawing.Size(66, 20);
            this.chActive.TabIndex = 1;
            this.chActive.Text = "Active";
            this.chActive.UseVisualStyleBackColor = true;
            // 
            // bigTextBox1
            // 
            this.bigTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox1.Font = new System.Drawing.Font("Tahoma", 11F);
            this.bigTextBox1.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox1.Image = null;
            this.bigTextBox1.Location = new System.Drawing.Point(4, 36);
            this.bigTextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.PlaceholderText = "Search for ID,Name,Passport or Phone";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(333, 46);
            this.bigTextBox1.TabIndex = 44;
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            // 
            // btnAddBorrower
            // 
            this.btnAddBorrower.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddBorrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBorrower.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBorrower.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.btnAddBorrower.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBorrower.Location = new System.Drawing.Point(839, 57);
            this.btnAddBorrower.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddBorrower.Name = "btnAddBorrower";
            this.btnAddBorrower.Size = new System.Drawing.Size(159, 30);
            this.btnAddBorrower.TabIndex = 43;
            this.btnAddBorrower.Text = "Add Borrower";
            this.btnAddBorrower.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBorrower.UseVisualStyleBackColor = false;
            this.btnAddBorrower.Click += new System.EventHandler(this.btnAddBorrower_Click);
            // 
            // dgvB
            // 
            this.dgvB.AllowUserToAddRows = false;
            this.dgvB.AllowUserToDeleteRows = false;
            this.dgvB.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Passport,
            this.Phone,
            this.ActiveLoans,
            this.UnpaidFines,
            this.IsActive});
            this.dgvB.ContextMenuStrip = this.ContextOperation;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvB.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvB.Location = new System.Drawing.Point(0, 92);
            this.dgvB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvB.MultiSelect = false;
            this.dgvB.Name = "dgvB";
            this.dgvB.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvB.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvB.RowHeadersWidth = 51;
            this.dgvB.RowTemplate.Height = 24;
            this.dgvB.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvB.ShowCellErrors = false;
            this.dgvB.ShowCellToolTips = false;
            this.dgvB.ShowEditingIcon = false;
            this.dgvB.ShowRowErrors = false;
            this.dgvB.Size = new System.Drawing.Size(1000, 679);
            this.dgvB.TabIndex = 42;
            // 
            // ID
            // 
            this.ID.HeaderText = "Borrower ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Passport
            // 
            this.Passport.HeaderText = "Passport";
            this.Passport.MinimumWidth = 6;
            this.Passport.Name = "Passport";
            this.Passport.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.MinimumWidth = 6;
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // ActiveLoans
            // 
            this.ActiveLoans.HeaderText = "Active Loans";
            this.ActiveLoans.MinimumWidth = 6;
            this.ActiveLoans.Name = "ActiveLoans";
            this.ActiveLoans.ReadOnly = true;
            // 
            // UnpaidFines
            // 
            this.UnpaidFines.HeaderText = "Unpaid Fines";
            this.UnpaidFines.MinimumWidth = 6;
            this.UnpaidFines.Name = "UnpaidFines";
            this.UnpaidFines.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Status";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // ContextOperation
            // 
            this.ContextOperation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.ContextOperation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ContextOperation.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ContextOperation.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUpdate,
            this.btnDelete,
            this.btnActivate});
            this.ContextOperation.Name = "crownContextMenuStrip1";
            this.ContextOperation.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.ContextOperation.Size = new System.Drawing.Size(215, 110);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnUpdate.Image = global::Loan_Desk.Properties.Resources.update_20;
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(214, 26);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnDelete.Image = global::Loan_Desk.Properties.Resources.delete_20;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(214, 26);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnActivate
            // 
            this.btnActivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.btnActivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.btnActivate.Image = global::Loan_Desk.Properties.Resources.active_20;
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(214, 26);
            this.btnActivate.Text = "Activate";
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // BorrowersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BorrowersView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvB)).EndInit();
            this.ContextOperation.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private System.Windows.Forms.Button btnAddBorrower;
        private System.Windows.Forms.DataGridView dgvB;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Passport;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActiveLoans;
        private System.Windows.Forms.DataGridViewTextBoxColumn UnpaidFines;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilter;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private System.Windows.Forms.CheckBox chInActive;
        private System.Windows.Forms.CheckBox chActive;
        private ReaLTaiizor.Controls.CrownContextMenuStrip ContextOperation;
        private System.Windows.Forms.ToolStripMenuItem btnUpdate;
        private System.Windows.Forms.ToolStripMenuItem btnDelete;
        private System.Windows.Forms.ToolStripMenuItem btnActivate;
    }
}
