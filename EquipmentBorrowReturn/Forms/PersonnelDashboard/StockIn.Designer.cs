namespace EquipmentBorrowReturn.Forms.PersonnelDashboard
{
    partial class StockIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIn));
            this.stockINDataGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.equipmenttypefilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentconditionfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EquipmentTypeRefresh = new System.Windows.Forms.PictureBox();
            this.EquipmentConditionRefresh = new System.Windows.Forms.PictureBox();
            this.exportwordbtn = new Guna.UI2.WinForms.Guna2Button();
            this.exportexcelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.stockINDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentConditionRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // stockINDataGrid
            // 
            this.stockINDataGrid.AllowUserToAddRows = false;
            this.stockINDataGrid.AllowUserToDeleteRows = false;
            this.stockINDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockINDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.stockINDataGrid.Location = new System.Drawing.Point(4, 4);
            this.stockINDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.stockINDataGrid.Name = "stockINDataGrid";
            this.stockINDataGrid.RowHeadersVisible = false;
            this.stockINDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockINDataGrid.Size = new System.Drawing.Size(1666, 643);
            this.stockINDataGrid.TabIndex = 98;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.stockINDataGrid);
            this.panel2.Location = new System.Drawing.Point(14, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1674, 651);
            this.panel2.TabIndex = 113;
            // 
            // equipmenttypefilter
            // 
            this.equipmenttypefilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmenttypefilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmenttypefilter.FormattingEnabled = true;
            this.equipmenttypefilter.Items.AddRange(new object[] {
            "Display",
            "Cable",
            "Tools",
            "Accessory",
            "Video",
            "Audio"});
            this.equipmenttypefilter.Location = new System.Drawing.Point(14, 727);
            this.equipmenttypefilter.Name = "equipmenttypefilter";
            this.equipmenttypefilter.Size = new System.Drawing.Size(275, 33);
            this.equipmenttypefilter.TabIndex = 127;
            this.equipmenttypefilter.TextChanged += new System.EventHandler(this.EquipmentType_Filter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 695);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 126;
            this.label1.Text = "Filter By Equipment Type:";
            // 
            // equipmentconditionfilter
            // 
            this.equipmentconditionfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentconditionfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentconditionfilter.FormattingEnabled = true;
            this.equipmentconditionfilter.Items.AddRange(new object[] {
            "New",
            "Good",
            "Fair"});
            this.equipmentconditionfilter.Location = new System.Drawing.Point(362, 727);
            this.equipmentconditionfilter.Name = "equipmentconditionfilter";
            this.equipmentconditionfilter.Size = new System.Drawing.Size(275, 33);
            this.equipmentconditionfilter.TabIndex = 129;
            this.equipmentconditionfilter.TextChanged += new System.EventHandler(this.EquipmentCondition_Filter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 695);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 17);
            this.label2.TabIndex = 128;
            this.label2.Text = "Filter By Equipment Condition:";
            // 
            // EquipmentTypeRefresh
            // 
            this.EquipmentTypeRefresh.Image = ((System.Drawing.Image)(resources.GetObject("EquipmentTypeRefresh.Image")));
            this.EquipmentTypeRefresh.Location = new System.Drawing.Point(295, 728);
            this.EquipmentTypeRefresh.Name = "EquipmentTypeRefresh";
            this.EquipmentTypeRefresh.Size = new System.Drawing.Size(37, 32);
            this.EquipmentTypeRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EquipmentTypeRefresh.TabIndex = 130;
            this.EquipmentTypeRefresh.TabStop = false;
            this.EquipmentTypeRefresh.Click += new System.EventHandler(this.EquipmentTypeClick);
            // 
            // EquipmentConditionRefresh
            // 
            this.EquipmentConditionRefresh.Image = ((System.Drawing.Image)(resources.GetObject("EquipmentConditionRefresh.Image")));
            this.EquipmentConditionRefresh.Location = new System.Drawing.Point(643, 728);
            this.EquipmentConditionRefresh.Name = "EquipmentConditionRefresh";
            this.EquipmentConditionRefresh.Size = new System.Drawing.Size(37, 32);
            this.EquipmentConditionRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EquipmentConditionRefresh.TabIndex = 131;
            this.EquipmentConditionRefresh.TabStop = false;
            this.EquipmentConditionRefresh.Click += new System.EventHandler(this.EquipmentConditionClick);
            // 
            // exportwordbtn
            // 
            this.exportwordbtn.CheckedState.Parent = this.exportwordbtn;
            this.exportwordbtn.CustomImages.Parent = this.exportwordbtn;
            this.exportwordbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportwordbtn.ForeColor = System.Drawing.Color.White;
            this.exportwordbtn.HoverState.Parent = this.exportwordbtn;
            this.exportwordbtn.Location = new System.Drawing.Point(1293, 715);
            this.exportwordbtn.Name = "exportwordbtn";
            this.exportwordbtn.ShadowDecoration.Parent = this.exportwordbtn;
            this.exportwordbtn.Size = new System.Drawing.Size(180, 45);
            this.exportwordbtn.TabIndex = 133;
            this.exportwordbtn.Text = "Export Word";
            this.exportwordbtn.Click += new System.EventHandler(this.exportwordbtn_Click);
            // 
            // exportexcelbtn
            // 
            this.exportexcelbtn.CheckedState.Parent = this.exportexcelbtn;
            this.exportexcelbtn.CustomImages.Parent = this.exportexcelbtn;
            this.exportexcelbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportexcelbtn.ForeColor = System.Drawing.Color.White;
            this.exportexcelbtn.HoverState.Parent = this.exportexcelbtn;
            this.exportexcelbtn.Location = new System.Drawing.Point(1508, 715);
            this.exportexcelbtn.Name = "exportexcelbtn";
            this.exportexcelbtn.ShadowDecoration.Parent = this.exportexcelbtn;
            this.exportexcelbtn.Size = new System.Drawing.Size(180, 45);
            this.exportexcelbtn.TabIndex = 132;
            this.exportexcelbtn.Text = "Export Excel";
            this.exportexcelbtn.Click += new System.EventHandler(this.exportexcelbtn_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "equipmentnumber";
            this.Column1.HeaderText = "Equipment Number";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "equipmentname";
            this.Column2.HeaderText = "Equipment Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "equipmentquantity";
            this.Column3.HeaderText = "Available Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "equipmenttype";
            this.Column4.HeaderText = "Equipment Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "equipmentcondition";
            this.Column5.HeaderText = "Condition";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "image";
            this.Column6.HeaderText = "Image";
            this.Column6.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column6.Name = "Column6";
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "addedby_admin";
            this.Column7.HeaderText = "Added By Admin";
            this.Column7.Name = "Column7";
            // 
            // StockIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportwordbtn);
            this.Controls.Add(this.exportexcelbtn);
            this.Controls.Add(this.EquipmentConditionRefresh);
            this.Controls.Add(this.EquipmentTypeRefresh);
            this.Controls.Add(this.equipmentconditionfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipmenttypefilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Name = "StockIn";
            this.Size = new System.Drawing.Size(1706, 785);
            this.Load += new System.EventHandler(this.StockIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stockINDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentTypeRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EquipmentConditionRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView stockINDataGrid;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox equipmenttypefilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox equipmentconditionfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox EquipmentTypeRefresh;
        private System.Windows.Forms.PictureBox EquipmentConditionRefresh;
        private Guna.UI2.WinForms.Guna2Button exportwordbtn;
        private Guna.UI2.WinForms.Guna2Button exportexcelbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}
