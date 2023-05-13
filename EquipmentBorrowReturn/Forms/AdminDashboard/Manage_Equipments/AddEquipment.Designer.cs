namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Equipments
{
    partial class AddEquipment
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
            this.equipmenttypetxt = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.equipmentconditiontxt = new System.Windows.Forms.ComboBox();
            this.equipmentnumbertxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addbtn = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.equipmentquantitytxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.equipmentnametxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equipmentPicture = new System.Windows.Forms.PictureBox();
            this.browsepicbtn = new System.Windows.Forms.Button();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.equipmentadminidtxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.equipmentinfoDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.generatenumberbtn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPicture)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentinfoDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // equipmenttypetxt
            // 
            this.equipmenttypetxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmenttypetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmenttypetxt.FormattingEnabled = true;
            this.equipmenttypetxt.Items.AddRange(new object[] {
            "Audio",
            "Video",
            "Display",
            "Tools",
            "Cable",
            "Accessory"});
            this.equipmenttypetxt.Location = new System.Drawing.Point(128, 500);
            this.equipmenttypetxt.Name = "equipmenttypetxt";
            this.equipmenttypetxt.Size = new System.Drawing.Size(409, 28);
            this.equipmenttypetxt.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 572);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 91;
            this.label2.Text = "Condition:";
            // 
            // equipmentconditiontxt
            // 
            this.equipmentconditiontxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentconditiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentconditiontxt.FormattingEnabled = true;
            this.equipmentconditiontxt.Items.AddRange(new object[] {
            "New",
            "Good",
            "Fair",
            "Damaged"});
            this.equipmentconditiontxt.Location = new System.Drawing.Point(128, 568);
            this.equipmentconditiontxt.Name = "equipmentconditiontxt";
            this.equipmentconditiontxt.Size = new System.Drawing.Size(409, 28);
            this.equipmentconditiontxt.TabIndex = 90;
            // 
            // equipmentnumbertxt
            // 
            this.equipmentnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentnumbertxt.Location = new System.Drawing.Point(128, 466);
            this.equipmentnumbertxt.Name = "equipmentnumbertxt";
            this.equipmentnumbertxt.Size = new System.Drawing.Size(312, 28);
            this.equipmentnumbertxt.TabIndex = 89;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 88;
            this.label1.Text = "Number:";
            // 
            // addbtn
            // 
            this.addbtn.CheckedState.Parent = this.addbtn;
            this.addbtn.CustomImages.Parent = this.addbtn;
            this.addbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addbtn.ForeColor = System.Drawing.Color.White;
            this.addbtn.HoverState.Parent = this.addbtn;
            this.addbtn.Location = new System.Drawing.Point(381, 649);
            this.addbtn.Name = "addbtn";
            this.addbtn.ShadowDecoration.Parent = this.addbtn;
            this.addbtn.Size = new System.Drawing.Size(156, 50);
            this.addbtn.TabIndex = 84;
            this.addbtn.Text = "ADD";
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 504);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 24);
            this.label6.TabIndex = 83;
            this.label6.Text = "Type:";
            // 
            // equipmentquantitytxt
            // 
            this.equipmentquantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentquantitytxt.Location = new System.Drawing.Point(128, 534);
            this.equipmentquantitytxt.Name = "equipmentquantitytxt";
            this.equipmentquantitytxt.Size = new System.Drawing.Size(409, 28);
            this.equipmentquantitytxt.TabIndex = 82;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 538);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 24);
            this.label5.TabIndex = 81;
            this.label5.Text = "Quantity:";
            // 
            // equipmentnametxt
            // 
            this.equipmentnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentnametxt.Location = new System.Drawing.Point(128, 432);
            this.equipmentnametxt.Name = "equipmentnametxt";
            this.equipmentnametxt.Size = new System.Drawing.Size(409, 28);
            this.equipmentnametxt.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 436);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 24);
            this.label3.TabIndex = 78;
            this.label3.Text = "Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.equipmentPicture);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(140, 96);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(291, 277);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo";
            // 
            // equipmentPicture
            // 
            this.equipmentPicture.Location = new System.Drawing.Point(8, 23);
            this.equipmentPicture.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentPicture.Name = "equipmentPicture";
            this.equipmentPicture.Size = new System.Drawing.Size(275, 246);
            this.equipmentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentPicture.TabIndex = 69;
            this.equipmentPicture.TabStop = false;
            // 
            // browsepicbtn
            // 
            this.browsepicbtn.BackColor = System.Drawing.Color.White;
            this.browsepicbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.browsepicbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.browsepicbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.browsepicbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browsepicbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.browsepicbtn.Location = new System.Drawing.Point(211, 379);
            this.browsepicbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.browsepicbtn.Name = "browsepicbtn";
            this.browsepicbtn.Size = new System.Drawing.Size(156, 36);
            this.browsepicbtn.TabIndex = 94;
            this.browsepicbtn.Text = "Browse Picture";
            this.browsepicbtn.UseVisualStyleBackColor = false;
            this.browsepicbtn.Click += new System.EventHandler(this.browsepicbtn_Click);
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.generatenumberbtn);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.equipmentadminidtxt);
            this.guna2GroupBox1.Controls.Add(this.groupBox2);
            this.guna2GroupBox1.Controls.Add(this.browsepicbtn);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.equipmentnametxt);
            this.guna2GroupBox1.Controls.Add(this.equipmenttypetxt);
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.equipmentquantitytxt);
            this.guna2GroupBox1.Controls.Add(this.equipmentconditiontxt);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.equipmentnumbertxt);
            this.guna2GroupBox1.Controls.Add(this.addbtn);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 3);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(556, 719);
            this.guna2GroupBox1.TabIndex = 95;
            this.guna2GroupBox1.Text = "Equipment Information";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 606);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 24);
            this.label4.TabIndex = 95;
            this.label4.Text = "Added by this Admin ID:";
            // 
            // equipmentadminidtxt
            // 
            this.equipmentadminidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentadminidtxt.Location = new System.Drawing.Point(238, 602);
            this.equipmentadminidtxt.Name = "equipmentadminidtxt";
            this.equipmentadminidtxt.ReadOnly = true;
            this.equipmentadminidtxt.Size = new System.Drawing.Size(299, 28);
            this.equipmentadminidtxt.TabIndex = 96;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.equipmentinfoDataGrid);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(565, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1123, 520);
            this.panel1.TabIndex = 97;
            // 
            // equipmentinfoDataGrid
            // 
            this.equipmentinfoDataGrid.AllowUserToAddRows = false;
            this.equipmentinfoDataGrid.AllowUserToDeleteRows = false;
            this.equipmentinfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.equipmentinfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.equipmentinfoDataGrid.Location = new System.Drawing.Point(16, 22);
            this.equipmentinfoDataGrid.Name = "equipmentinfoDataGrid";
            this.equipmentinfoDataGrid.RowHeadersVisible = false;
            this.equipmentinfoDataGrid.RowTemplate.Height = 24;
            this.equipmentinfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.equipmentinfoDataGrid.Size = new System.Drawing.Size(1090, 477);
            this.equipmentinfoDataGrid.TabIndex = 98;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Equipment ID";
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
            this.Column3.DataPropertyName = "equipmentnumber";
            this.Column3.HeaderText = "Number";
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
            this.Column5.DataPropertyName = "equipmentquantity";
            this.Column5.HeaderText = "Available Quantity";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "equipmentcondition";
            this.Column6.HeaderText = "Condition";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "admin_id";
            this.Column7.HeaderText = "Added by: (Admin ID)";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "image";
            this.Column8.HeaderText = "Picture";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1050, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 24);
            this.label8.TabIndex = 101;
            this.label8.Text = "EQUIPMENT LIST";
            // 
            // generatenumberbtn
            // 
            this.generatenumberbtn.BackColor = System.Drawing.Color.White;
            this.generatenumberbtn.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.generatenumberbtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightSkyBlue;
            this.generatenumberbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.generatenumberbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.generatenumberbtn.ForeColor = System.Drawing.Color.DodgerBlue;
            this.generatenumberbtn.Location = new System.Drawing.Point(446, 465);
            this.generatenumberbtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.generatenumberbtn.Name = "generatenumberbtn";
            this.generatenumberbtn.Size = new System.Drawing.Size(91, 30);
            this.generatenumberbtn.TabIndex = 108;
            this.generatenumberbtn.Text = "Generate";
            this.generatenumberbtn.UseVisualStyleBackColor = false;
            this.generatenumberbtn.Click += new System.EventHandler(this.generatenumberbtn_Click);
            // 
            // AddEquipment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel1);
            this.Name = "AddEquipment";
            this.Size = new System.Drawing.Size(1706, 734);
            this.Load += new System.EventHandler(this.AddEquipment_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPicture)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentinfoDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox equipmenttypetxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox equipmentconditiontxt;
        private System.Windows.Forms.TextBox equipmentnumbertxt;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button addbtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox equipmentquantitytxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox equipmentnametxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox equipmentPicture;
        private System.Windows.Forms.Button browsepicbtn;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox equipmentadminidtxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView equipmentinfoDataGrid;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
        private System.Windows.Forms.Button generatenumberbtn;
    }
}
