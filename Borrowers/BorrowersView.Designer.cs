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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ContentPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Passport = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActiveLoans = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UnpaidFines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.chInActive = new System.Windows.Forms.CheckBox();
            this.chActive = new System.Windows.Forms.CheckBox();
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
            this.ContentPanel.Controls.Add(this.cbFilter);
            this.ContentPanel.Controls.Add(this.parrotGroupBox1);
            this.ContentPanel.Controls.Add(this.bigTextBox1);
            this.ContentPanel.Controls.Add(this.button1);
            this.ContentPanel.Controls.Add(this.dataGridView1);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(839, 57);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 30);
            this.button1.TabIndex = 43;
            this.button1.Text = "Add Borrower";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.FullName,
            this.Passport,
            this.Phone,
            this.ActiveLoans,
            this.UnpaidFines,
            this.IsActive});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.Location = new System.Drawing.Point(0, 92);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1000, 679);
            this.dataGridView1.TabIndex = 42;
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
            // cbFilter
            // 
            this.cbFilter.AutoResize = true;
            this.cbFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbFilter.Depth = 0;
            this.cbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbFilter.DropDownHeight = 218;
            this.cbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFilter.DropDownWidth = 134;
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
            this.cbFilter.Size = new System.Drawing.Size(134, 60);
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
            // BorrowersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "BorrowersView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
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
    }
}
