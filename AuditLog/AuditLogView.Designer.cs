namespace Loan_Desk.AuditLog
{
    partial class AuditLogView
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
            this.bigTextBox1 = new ReaLTaiizor.Controls.BigTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActioneDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actione = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EntityID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Details = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.BottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.ContentPanel.BottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ContentPanel.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.ContentPanel.Controls.Add(this.bigTextBox1);
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
            this.bigTextBox1.Location = new System.Drawing.Point(4, 34);
            this.bigTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bigTextBox1.MaxLength = 32767;
            this.bigTextBox1.Multiline = false;
            this.bigTextBox1.Name = "bigTextBox1";
            this.bigTextBox1.ReadOnly = false;
            this.bigTextBox1.Size = new System.Drawing.Size(333, 46);
            this.bigTextBox1.TabIndex = 47;
            this.bigTextBox1.Text = "Search ID, User ID or Entity ID";
            this.bigTextBox1.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.bigTextBox1.UseSystemPasswordChar = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
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
            this.UserID,
            this.ActioneDate,
            this.Actione,
            this.EntityType,
            this.EntityID,
            this.Details});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(0, 91);
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
            this.dataGridView1.TabIndex = 1;
            // 
            // ID
            // 
            this.ID.HeaderText = "Audit Log ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.HeaderText = "User ID";
            this.UserID.MinimumWidth = 6;
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // ActioneDate
            // 
            this.ActioneDate.HeaderText = "ActioneDate";
            this.ActioneDate.MinimumWidth = 6;
            this.ActioneDate.Name = "ActioneDate";
            this.ActioneDate.ReadOnly = true;
            // 
            // Actione
            // 
            this.Actione.HeaderText = "ActioneDate";
            this.Actione.MinimumWidth = 6;
            this.Actione.Name = "Actione";
            this.Actione.ReadOnly = true;
            // 
            // EntityType
            // 
            this.EntityType.HeaderText = "Entity Type";
            this.EntityType.MinimumWidth = 6;
            this.EntityType.Name = "EntityType";
            this.EntityType.ReadOnly = true;
            // 
            // EntityID
            // 
            this.EntityID.HeaderText = "Entity ID";
            this.EntityID.MinimumWidth = 6;
            this.EntityID.Name = "EntityID";
            this.EntityID.ReadOnly = true;
            // 
            // Details
            // 
            this.Details.HeaderText = "Details";
            this.Details.MinimumWidth = 6;
            this.Details.Name = "Details";
            this.Details.ReadOnly = true;
            // 
            // AuditLogView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ContentPanel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuditLogView";
            this.Size = new System.Drawing.Size(1000, 770);
            this.ContentPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.ParrotGradientPanel ContentPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ReaLTaiizor.Controls.BigTextBox bigTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActioneDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actione;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityType;
        private System.Windows.Forms.DataGridViewTextBoxColumn EntityID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Details;
    }
}
