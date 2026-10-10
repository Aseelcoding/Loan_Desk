namespace Loan_Desk.Equipment
{
    partial class EquipmentView
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
            this.ContentPanel = new ReaLTaiizor.Controls.ParrotGradientPanel();
            this.cbFilter = new ReaLTaiizor.Controls.MaterialComboBox();
            this.parrotGroupBox1 = new ReaLTaiizor.Controls.ParrotGroupBox();
            this.chInActive = new System.Windows.Forms.CheckBox();
            this.chActive = new System.Windows.Forms.CheckBox();
            this.txtBarSearch = new ReaLTaiizor.Controls.BigTextBox();
            this.btnAddEquipment = new System.Windows.Forms.Button();
            this.dgvEq = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipmentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DailyLateFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplacementCost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsActive = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ContentPanel.SuspendLayout();
            this.parrotGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContentPanel.Controls.Add(this.cbFilter);
            this.ContentPanel.Controls.Add(this.parrotGroupBox1);
            this.ContentPanel.Controls.Add(this.txtBarSearch);
            this.ContentPanel.Controls.Add(this.btnAddEquipment);
            this.ContentPanel.Controls.Add(this.dgvEq);
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
            "Equipment ID",
            "Equipment",
            "Quantity",
            "Avaliable Quantity",
            "Replacement Cost"});
            this.cbFilter.Location = new System.Drawing.Point(306, 25);
            this.cbFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbFilter.MaxDropDownItems = 4;
            this.cbFilter.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbFilter.Name = "cbFilter";
            this.cbFilter.Size = new System.Drawing.Size(227, 60);
            this.cbFilter.StartIndex = 0;
            this.cbFilter.TabIndex = 50;
            // 
            // parrotGroupBox1
            // 
            this.parrotGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.parrotGroupBox1.BorderWidth = 1;
            this.parrotGroupBox1.Controls.Add(this.chInActive);
            this.parrotGroupBox1.Controls.Add(this.chActive);
            this.parrotGroupBox1.Location = new System.Drawing.Point(622, 36);
            this.parrotGroupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.Name = "parrotGroupBox1";
            this.parrotGroupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.parrotGroupBox1.ShowText = false;
            this.parrotGroupBox1.Size = new System.Drawing.Size(184, 47);
            this.parrotGroupBox1.TabIndex = 49;
            this.parrotGroupBox1.TabStop = false;
            this.parrotGroupBox1.Text = "parrotGroupBox1";
            this.parrotGroupBox1.TextColor = System.Drawing.Color.DodgerBlue;
            // 
            // chInActive
            // 
            this.chInActive.AutoSize = true;
            this.chInActive.Location = new System.Drawing.Point(96, 16);
            this.chInActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chInActive.Name = "chInActive";
            this.chInActive.Size = new System.Drawing.Size(76, 20);
            this.chInActive.TabIndex = 3;
            this.chInActive.Text = "InActive";
            this.chInActive.UseVisualStyleBackColor = true;
            // 
            // chActive
            // 
            this.chActive.AutoSize = true;
            this.chActive.Location = new System.Drawing.Point(7, 16);
            this.chActive.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chActive.Name = "chActive";
            this.chActive.Size = new System.Drawing.Size(66, 20);
            this.chActive.TabIndex = 2;
            this.chActive.Text = "Active";
            this.chActive.UseVisualStyleBackColor = true;
            // 
            // txtBarSearch
            // 
            this.txtBarSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtBarSearch.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txtBarSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtBarSearch.Image = null;
            this.txtBarSearch.Location = new System.Drawing.Point(4, 32);
            this.txtBarSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtBarSearch.MaxLength = 255;
            this.txtBarSearch.Multiline = false;
            this.txtBarSearch.Name = "txtBarSearch";
            this.txtBarSearch.PlaceholderText = "Search Equipment";
            this.txtBarSearch.ReadOnly = false;
            this.txtBarSearch.Size = new System.Drawing.Size(295, 46);
            this.txtBarSearch.TabIndex = 48;
            this.txtBarSearch.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtBarSearch.UseSystemPasswordChar = false;
            // 
            // btnAddEquipment
            // 
            this.btnAddEquipment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.btnAddEquipment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEquipment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddEquipment.Image = global::Loan_Desk.Properties.Resources.add_25;
            this.btnAddEquipment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddEquipment.Location = new System.Drawing.Point(813, 46);
            this.btnAddEquipment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAddEquipment.Name = "btnAddEquipment";
            this.btnAddEquipment.Size = new System.Drawing.Size(172, 30);
            this.btnAddEquipment.TabIndex = 47;
            this.btnAddEquipment.Text = "Add Equipment";
            this.btnAddEquipment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddEquipment.UseVisualStyleBackColor = false;
            this.btnAddEquipment.Click += new System.EventHandler(this.btnAddEquipment_Click);
            // 
            // dgvEq
            // 
            this.dgvEq.AllowUserToAddRows = false;
            this.dgvEq.AllowUserToDeleteRows = false;
            this.dgvEq.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEq.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvEq.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEq.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.EquipmentName,
            this.TotalQuantity,
            this.AvailableQuantity,
            this.DailyLateFee,
            this.ReplacementCost,
            this.IsActive});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEq.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvEq.Location = new System.Drawing.Point(-3, 89);
            this.dgvEq.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvEq.Name = "dgvEq";
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEq.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvEq.RowHeadersWidth = 51;
            this.dgvEq.RowTemplate.Height = 24;
            this.dgvEq.Size = new System.Drawing.Size(1000, 679);
            this.dgvEq.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Equipment ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // EquipmentName
            // 
            this.EquipmentName.HeaderText = "Equipment";
            this.EquipmentName.MinimumWidth = 6;
            this.EquipmentName.Name = "EquipmentName";
            this.EquipmentName.ReadOnly = true;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.HeaderText = "Quantity";
            this.TotalQuantity.MinimumWidth = 6;
            this.TotalQuantity.Name = "TotalQuantity";
            this.TotalQuantity.ReadOnly = true;
            // 
            // AvailableQuantity
            // 
            this.AvailableQuantity.HeaderText = "Available Quantity";
            this.AvailableQuantity.MinimumWidth = 6;
            this.AvailableQuantity.Name = "AvailableQuantity";
            this.AvailableQuantity.ReadOnly = true;
            // 
            // DailyLateFee
            // 
            this.DailyLateFee.HeaderText = "Daily Late Fee";
            this.DailyLateFee.MinimumWidth = 6;
            this.DailyLateFee.Name = "DailyLateFee";
            this.DailyLateFee.ReadOnly = true;
            // 
            // ReplacementCost
            // 
            this.ReplacementCost.HeaderText = "Replacement Cost";
            this.ReplacementCost.MinimumWidth = 6;
            this.ReplacementCost.Name = "ReplacementCost";
            this.ReplacementCost.ReadOnly = true;
            // 
            // IsActive
            // 
            this.IsActive.HeaderText = "Active";
            this.IsActive.MinimumWidth = 6;
            this.IsActive.Name = "IsActive";
            this.IsActive.ReadOnly = true;
            // 
            // EquipmentView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EquipmentView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.Load += new System.EventHandler(this.EquipmentView_Load);
            this.ContentPanel.ResumeLayout(false);
            this.parrotGroupBox1.ResumeLayout(false);
            this.parrotGroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private System.Windows.Forms.DataGridView dgvEq;
        private ReaLTaiizor.Controls.ParrotGroupBox parrotGroupBox1;
        private ReaLTaiizor.Controls.BigTextBox txtBarSearch;
        private System.Windows.Forms.Button btnAddEquipment;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipmentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvailableQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn DailyLateFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplacementCost;
        private System.Windows.Forms.DataGridViewCheckBoxColumn IsActive;
        private System.Windows.Forms.CheckBox chActive;
        private System.Windows.Forms.CheckBox chInActive;
        private ReaLTaiizor.Controls.MaterialComboBox cbFilter;
    }
}
