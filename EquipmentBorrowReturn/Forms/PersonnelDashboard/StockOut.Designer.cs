namespace EquipmentBorrowReturn.Forms.PersonnelDashboard
{
    partial class StockOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockOut));
            this.panel3 = new System.Windows.Forms.Panel();
            this.stockOutDataGrid = new System.Windows.Forms.DataGridView();
            this.equipmentstatusrefresh = new System.Windows.Forms.PictureBox();
            this.equipmentstatusfilter = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentconditionrefresh = new System.Windows.Forms.PictureBox();
            this.equipmentconditionfilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmenttyperefresh = new System.Windows.Forms.PictureBox();
            this.equipmenttypefilter = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exportwordbtn = new Guna.UI2.WinForms.Guna2Button();
            this.exportexcelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentstatusrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentconditionrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmenttyperefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.stockOutDataGrid);
            this.panel3.Location = new System.Drawing.Point(15, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1681, 652);
            this.panel3.TabIndex = 123;
            // 
            // stockOutDataGrid
            // 
            this.stockOutDataGrid.AllowUserToAddRows = false;
            this.stockOutDataGrid.AllowUserToDeleteRows = false;
            this.stockOutDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockOutDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column8});
            this.stockOutDataGrid.Location = new System.Drawing.Point(4, 4);
            this.stockOutDataGrid.Margin = new System.Windows.Forms.Padding(4);
            this.stockOutDataGrid.Name = "stockOutDataGrid";
            this.stockOutDataGrid.RowHeadersVisible = false;
            this.stockOutDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.stockOutDataGrid.Size = new System.Drawing.Size(1673, 644);
            this.stockOutDataGrid.TabIndex = 98;
            // 
            // equipmentstatusrefresh
            // 
            this.equipmentstatusrefresh.Image = ((System.Drawing.Image)(resources.GetObject("equipmentstatusrefresh.Image")));
            this.equipmentstatusrefresh.Location = new System.Drawing.Point(300, 720);
            this.equipmentstatusrefresh.Name = "equipmentstatusrefresh";
            this.equipmentstatusrefresh.Size = new System.Drawing.Size(37, 32);
            this.equipmentstatusrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentstatusrefresh.TabIndex = 126;
            this.equipmentstatusrefresh.TabStop = false;
            this.equipmentstatusrefresh.Click += new System.EventHandler(this.EquipmentStatus_Click);
            // 
            // equipmentstatusfilter
            // 
            this.equipmentstatusfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentstatusfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentstatusfilter.FormattingEnabled = true;
            this.equipmentstatusfilter.Items.AddRange(new object[] {
            "Lost",
            "Damaged",
            "Borrowed"});
            this.equipmentstatusfilter.Location = new System.Drawing.Point(19, 720);
            this.equipmentstatusfilter.Name = "equipmentstatusfilter";
            this.equipmentstatusfilter.Size = new System.Drawing.Size(275, 33);
            this.equipmentstatusfilter.TabIndex = 125;
            this.equipmentstatusfilter.TextChanged += new System.EventHandler(this.EquipmentStatus_Filter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 698);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 17);
            this.label1.TabIndex = 124;
            this.label1.Text = "Filter By Equipment Status";
            // 
            // equipmentconditionrefresh
            // 
            this.equipmentconditionrefresh.Image = ((System.Drawing.Image)(resources.GetObject("equipmentconditionrefresh.Image")));
            this.equipmentconditionrefresh.Location = new System.Drawing.Point(663, 720);
            this.equipmentconditionrefresh.Name = "equipmentconditionrefresh";
            this.equipmentconditionrefresh.Size = new System.Drawing.Size(37, 32);
            this.equipmentconditionrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentconditionrefresh.TabIndex = 129;
            this.equipmentconditionrefresh.TabStop = false;
            this.equipmentconditionrefresh.Click += new System.EventHandler(this.EquipmentCondition_Click);
            // 
            // equipmentconditionfilter
            // 
            this.equipmentconditionfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentconditionfilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentconditionfilter.FormattingEnabled = true;
            this.equipmentconditionfilter.Items.AddRange(new object[] {
            "New",
            "Good",
            "Fair",
            "Damaged"});
            this.equipmentconditionfilter.Location = new System.Drawing.Point(382, 720);
            this.equipmentconditionfilter.Name = "equipmentconditionfilter";
            this.equipmentconditionfilter.Size = new System.Drawing.Size(275, 33);
            this.equipmentconditionfilter.TabIndex = 128;
            this.equipmentconditionfilter.TextChanged += new System.EventHandler(this.EquipmentCondition_Filter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(379, 698);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 17);
            this.label2.TabIndex = 127;
            this.label2.Text = "Filter By Equipment Condition";
            // 
            // equipmenttyperefresh
            // 
            this.equipmenttyperefresh.Image = ((System.Drawing.Image)(resources.GetObject("equipmenttyperefresh.Image")));
            this.equipmenttyperefresh.Location = new System.Drawing.Point(1021, 720);
            this.equipmenttyperefresh.Name = "equipmenttyperefresh";
            this.equipmenttyperefresh.Size = new System.Drawing.Size(37, 32);
            this.equipmenttyperefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmenttyperefresh.TabIndex = 132;
            this.equipmenttyperefresh.TabStop = false;
            this.equipmenttyperefresh.Click += new System.EventHandler(this.EquipmentType_Click);
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
            this.equipmenttypefilter.Location = new System.Drawing.Point(740, 720);
            this.equipmenttypefilter.Name = "equipmenttypefilter";
            this.equipmenttypefilter.Size = new System.Drawing.Size(275, 33);
            this.equipmenttypefilter.TabIndex = 131;
            this.equipmenttypefilter.TextChanged += new System.EventHandler(this.EquipmentType_Filter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 698);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 17);
            this.label3.TabIndex = 130;
            this.label3.Text = "Filter By Equipment Type";
            // 
            // exportwordbtn
            // 
            this.exportwordbtn.CheckedState.Parent = this.exportwordbtn;
            this.exportwordbtn.CustomImages.Parent = this.exportwordbtn;
            this.exportwordbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportwordbtn.ForeColor = System.Drawing.Color.White;
            this.exportwordbtn.HoverState.Parent = this.exportwordbtn;
            this.exportwordbtn.Location = new System.Drawing.Point(1297, 708);
            this.exportwordbtn.Name = "exportwordbtn";
            this.exportwordbtn.ShadowDecoration.Parent = this.exportwordbtn;
            this.exportwordbtn.Size = new System.Drawing.Size(180, 45);
            this.exportwordbtn.TabIndex = 135;
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
            this.exportexcelbtn.Location = new System.Drawing.Point(1512, 708);
            this.exportexcelbtn.Name = "exportexcelbtn";
            this.exportexcelbtn.ShadowDecoration.Parent = this.exportexcelbtn;
            this.exportexcelbtn.Size = new System.Drawing.Size(180, 45);
            this.exportexcelbtn.TabIndex = 134;
            this.exportexcelbtn.Text = "Export Excel";
            this.exportexcelbtn.Click += new System.EventHandler(this.exportexcelbtn_Click);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "equipment_number";
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
            this.Column3.DataPropertyName = "stockout_quantity";
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "stockout_type";
            this.Column4.HeaderText = "Equipment Type";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "equipment_condition";
            this.Column5.HeaderText = "Condition";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "equipment_status";
            this.Column6.HeaderText = "Status";
            this.Column6.Name = "Column6";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "lastborrower_name";
            this.Column8.HeaderText = "Last Borrower";
            this.Column8.Name = "Column8";
            // 
            // StockOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportwordbtn);
            this.Controls.Add(this.exportexcelbtn);
            this.Controls.Add(this.equipmenttyperefresh);
            this.Controls.Add(this.equipmenttypefilter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.equipmentconditionrefresh);
            this.Controls.Add(this.equipmentconditionfilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.equipmentstatusrefresh);
            this.Controls.Add(this.equipmentstatusfilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Name = "StockOut";
            this.Size = new System.Drawing.Size(1706, 785);
            this.Load += new System.EventHandler(this.StockOut_Load);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.stockOutDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentstatusrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentconditionrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.equipmenttyperefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView stockOutDataGrid;
        private System.Windows.Forms.PictureBox equipmentstatusrefresh;
        private System.Windows.Forms.ComboBox equipmentstatusfilter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox equipmentconditionrefresh;
        private System.Windows.Forms.ComboBox equipmentconditionfilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox equipmenttyperefresh;
        private System.Windows.Forms.ComboBox equipmenttypefilter;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button exportwordbtn;
        private Guna.UI2.WinForms.Guna2Button exportexcelbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}
