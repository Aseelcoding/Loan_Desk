namespace Loan_Desk.Users
{
    partial class UsersView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.parrotGradientPanel1 = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cbFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.txtBarSearch = new ReaLTaiizor.Controls.BigTextBox();
            this.dgvUsers = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.chActive = new System.Windows.Forms.CheckBox();
            this.chInActive = new System.Windows.Forms.CheckBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.parrotGradientPanel1.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // parrotGradientPanel1
            // 
            this.parrotGradientPanel1.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.parrotGradientPanel1.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGradientPanel1.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotGradientPanel1.Controls.Add(this.cbFilter);
            this.parrotGradientPanel1.Controls.Add(this.parrotGroupBox1);
            this.parrotGradientPanel1.Controls.Add(this.txtBarSearch);
            this.parrotGradientPanel1.Controls.Add(this.btnAddUser);
            this.parrotGradientPanel1.Controls.Add(this.dgvUsers);
            this.parrotGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotGradientPanel1.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.parrotGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parrotGradientPanel1.Name = "parrotGradientPanel1";
            this.parrotGradientPanel1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotGradientPanel1.PrimerColor = System.Drawing.Color.White;
            this.parrotGradientPanel1.Size = new System.Drawing.Size(1000, 770);
            this.parrotGradientPanel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotGradientPanel1.Style = ReaLTaiizor.Controls.ParrotGradientPanel.GradientStyle.Corners;
            this.parrotGradientPanel1.TabIndex = 2;
            this.parrotGradientPanel1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.parrotGradientPanel1.TopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.parrotGradientPanel1.TopRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
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
            "User ID",
            "Username",
            "Role"});
            this.cbFilter.Location = new System.Drawing.Point(340, 27);
            this.cbFilter.MaxDropDownItems = 4;
            this.cbFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(134, 60);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 48;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.chInActive);
            this.parrotGroupBox1.Controls.Add(this.chActive);
            this.parrotGroupBox1.Location = new System.Drawing.Point(533, 40);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.ShowText = false;
            this.parrotGroupBox1.Size = new System.Drawing.Size(252, 47);
            this.parrotGroupBox1.TabIndex = 46;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "parrotGroupBox1";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBarSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBarSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtBarSearch.Image = null;
            this.txtBarSearch.Location = new System.Drawing.Point(0, 37);
            this.txtBarSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarSearch.MaxLength = 50;
            this.txtBarSearch.Multiline = false;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.ReadOnly = false;
            this.txtBarSearch.Size = new System.Drawing.Size(333, 46);
            this.txtBarSearch.TabIndex = 41;
            this.txtBarSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarSearch.UseSystemPasswordChar = false;
            this.txtBarSearch.TextChanged += new System.EventHandler(this.txtBarSearch_TextChanged);
            // 
            // dgvUsers
            // 
            this.dgvUsers.AllowUserToAddRows = false;
            this.dgvUsers.AllowUserToDeleteRows = false;
            this.dgvUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Username,
            this.Role,
            this.IsActive});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsers.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvUsers.Location = new System.Drawing.Point(0, 92);
            this.dgvUsers.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvUsers.Name = "dgvUsers";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvUsers.RowHeadersWidth = 51;
            this.dgvUsers.RowTemplate.Height = 24;
            this.dgvUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsers.ShowCellErrors = false;
            this.dgvUsers.ShowCellToolTips = false;
            this.dgvUsers.ShowRowErrors = false;
            this.dgvUsers.Size = new System.Drawing.Size(1000, 679);
            this.dgvUsers.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.HeaderText = "User ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            // 
            // Role
            // 
            this.Role.HeaderText = "User Role";
            this.Role.MinimumWidth = 6;
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // chActive
            // 
            this.chActive.AutoSize = true;
            this.chActive.Location = new System.Drawing.Point(18, 13);
            this.chActive.Name = "chActive";
            this.chActive.Size = new System.Drawing.Size(66, 20);
            this.chActive.TabIndex = 1;
            this.chActive.Text = "Active";
            this.chActive.UseVisualStyleBackColor = true;
            // 
            // chInActive
            // 
            this.chInActive.AutoSize = true;
            this.chInActive.Location = new System.Drawing.Point(135, 13);
            this.chInActive.Name = "chInActive";
            this.chInActive.Size = new System.Drawing.Size(76, 20);
            this.chInActive.TabIndex = 2;
            this.chInActive.Text = "InActive";
            this.chInActive.UseVisualStyleBackColor = true;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.btnAddUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Location = new System.Drawing.Point(853, 53);
            this.btnAddUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(132, 30);
            this.btnAddUser.TabIndex = 1;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // UsersView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.parrotGradientPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UsersView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.Load += new System.EventHandler(this.UsersView_Load);
            this.parrotGradientPanel1.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel parrotGradientPanel1;
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.Button btnAddUser;
        private ReaLTaiizor.Controls.BigTextBox txtBarSearch;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilter;
        private System.Windows.Forms.CheckBox chInActive;
        private System.Windows.Forms.CheckBox chActive;
    }
}
