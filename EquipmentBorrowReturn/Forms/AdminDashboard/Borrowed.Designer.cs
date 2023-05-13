namespace EquipmentBorrowReturn
{
    partial class Borrowed
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.borrowedequipmentdatagrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.personneltxt = new System.Windows.Forms.TextBox();
            this.scheduletxt = new System.Windows.Forms.TextBox();
            this.dateborrowedtxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TransactionID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.markequipmentbtn = new Guna.UI2.WinForms.Guna2Button();
            this.borrowertxt = new System.Windows.Forms.TextBox();
            this.equipmentstatustxt = new System.Windows.Forms.ComboBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.equipmenttxt = new System.Windows.Forms.TextBox();
            this.equipmentconditiontxt = new System.Windows.Forms.TextBox();
            this.equipmenttypetxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.equipmentadminidtxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.equipmentPicture = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.equipmentnametxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.quantitytxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.equipmentnumbertxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowedequipmentdatagrid)).BeginInit();
            this.guna2GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.borrowedequipmentdatagrid);
            this.panel2.Location = new System.Drawing.Point(716, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(977, 589);
            this.panel2.TabIndex = 129;
            // 
            // borrowedequipmentdatagrid
            // 
            this.borrowedequipmentdatagrid.AllowUserToAddRows = false;
            this.borrowedequipmentdatagrid.AllowUserToDeleteRows = false;
            this.borrowedequipmentdatagrid.AllowUserToResizeRows = false;
            this.borrowedequipmentdatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowedequipmentdatagrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.borrowedequipmentdatagrid.Location = new System.Drawing.Point(14, 12);
            this.borrowedequipmentdatagrid.Margin = new System.Windows.Forms.Padding(4);
            this.borrowedequipmentdatagrid.Name = "borrowedequipmentdatagrid";
            this.borrowedequipmentdatagrid.ReadOnly = true;
            this.borrowedequipmentdatagrid.RowHeadersVisible = false;
            this.borrowedequipmentdatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowedequipmentdatagrid.Size = new System.Drawing.Size(948, 561);
            this.borrowedequipmentdatagrid.TabIndex = 104;
            this.borrowedequipmentdatagrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClickContent);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "Transaction ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "equipment_id";
            this.Column2.HeaderText = "Equipment ID";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "quantity";
            this.Column3.HeaderText = "Quantity Borrowed";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "borrower_id";
            this.Column4.HeaderText = "Borrower ID";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "personnel_id";
            this.Column5.HeaderText = "Personnel ID";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "dateBorrowed";
            this.Column6.HeaderText = "Date Borrowed";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "returnSchedule";
            this.Column7.HeaderText = "Return Schedule";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label5);
            this.guna2GroupBox1.Controls.Add(this.personneltxt);
            this.guna2GroupBox1.Controls.Add(this.scheduletxt);
            this.guna2GroupBox1.Controls.Add(this.dateborrowedtxt);
            this.guna2GroupBox1.Controls.Add(this.label9);
            this.guna2GroupBox1.Controls.Add(this.label3);
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.TransactionID);
            this.guna2GroupBox1.Controls.Add(this.label4);
            this.guna2GroupBox1.Controls.Add(this.markequipmentbtn);
            this.guna2GroupBox1.Controls.Add(this.borrowertxt);
            this.guna2GroupBox1.Controls.Add(this.equipmentstatustxt);
            this.guna2GroupBox1.Controls.Add(this.label21);
            this.guna2GroupBox1.Controls.Add(this.label6);
            this.guna2GroupBox1.Controls.Add(this.equipmenttxt);
            this.guna2GroupBox1.Controls.Add(this.equipmentconditiontxt);
            this.guna2GroupBox1.Controls.Add(this.equipmenttypetxt);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Controls.Add(this.equipmentadminidtxt);
            this.guna2GroupBox1.Controls.Add(this.groupBox2);
            this.guna2GroupBox1.Controls.Add(this.label7);
            this.guna2GroupBox1.Controls.Add(this.equipmentnametxt);
            this.guna2GroupBox1.Controls.Add(this.label8);
            this.guna2GroupBox1.Controls.Add(this.label11);
            this.guna2GroupBox1.Controls.Add(this.quantitytxt);
            this.guna2GroupBox1.Controls.Add(this.label12);
            this.guna2GroupBox1.Controls.Add(this.equipmentnumbertxt);
            this.guna2GroupBox1.Controls.Add(this.label13);
            this.guna2GroupBox1.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox1.Location = new System.Drawing.Point(3, 42);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(696, 693);
            this.guna2GroupBox1.TabIndex = 130;
            this.guna2GroupBox1.Text = "Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 205);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 24);
            this.label5.TabIndex = 150;
            this.label5.Text = "Personnel Duty ID:";
            // 
            // personneltxt
            // 
            this.personneltxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personneltxt.Location = new System.Drawing.Point(414, 199);
            this.personneltxt.Margin = new System.Windows.Forms.Padding(4);
            this.personneltxt.Name = "personneltxt";
            this.personneltxt.ReadOnly = true;
            this.personneltxt.Size = new System.Drawing.Size(254, 30);
            this.personneltxt.TabIndex = 149;
            // 
            // scheduletxt
            // 
            this.scheduletxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scheduletxt.Location = new System.Drawing.Point(268, 310);
            this.scheduletxt.Margin = new System.Windows.Forms.Padding(4);
            this.scheduletxt.Name = "scheduletxt";
            this.scheduletxt.ReadOnly = true;
            this.scheduletxt.Size = new System.Drawing.Size(399, 30);
            this.scheduletxt.TabIndex = 148;
            // 
            // dateborrowedtxt
            // 
            this.dateborrowedtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateborrowedtxt.Location = new System.Drawing.Point(268, 271);
            this.dateborrowedtxt.Margin = new System.Windows.Forms.Padding(4);
            this.dateborrowedtxt.Name = "dateborrowedtxt";
            this.dateborrowedtxt.ReadOnly = true;
            this.dateborrowedtxt.Size = new System.Drawing.Size(399, 30);
            this.dateborrowedtxt.TabIndex = 147;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(69, 316);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 24);
            this.label9.TabIndex = 146;
            this.label9.Text = "Schedule of Return:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(106, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 24);
            this.label3.TabIndex = 145;
            this.label3.Text = "Date Borrowed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(264, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 24);
            this.label2.TabIndex = 144;
            this.label2.Text = "Transaction ID:";
            // 
            // TransactionID
            // 
            this.TransactionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionID.Location = new System.Drawing.Point(414, 85);
            this.TransactionID.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionID.Name = "TransactionID";
            this.TransactionID.ReadOnly = true;
            this.TransactionID.Size = new System.Drawing.Size(253, 30);
            this.TransactionID.TabIndex = 143;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(285, 167);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 24);
            this.label4.TabIndex = 132;
            this.label4.Text = "Borrower ID:";
            // 
            // markequipmentbtn
            // 
            this.markequipmentbtn.CheckedState.Parent = this.markequipmentbtn;
            this.markequipmentbtn.CustomImages.Parent = this.markequipmentbtn;
            this.markequipmentbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.markequipmentbtn.ForeColor = System.Drawing.Color.White;
            this.markequipmentbtn.HoverState.Parent = this.markequipmentbtn;
            this.markequipmentbtn.Location = new System.Drawing.Point(476, 623);
            this.markequipmentbtn.Name = "markequipmentbtn";
            this.markequipmentbtn.ShadowDecoration.Parent = this.markequipmentbtn;
            this.markequipmentbtn.Size = new System.Drawing.Size(192, 54);
            this.markequipmentbtn.TabIndex = 142;
            this.markequipmentbtn.Text = "MARK EQUIPMENT";
            this.markequipmentbtn.Click += new System.EventHandler(this.markequipmentbtn_Click);
            // 
            // borrowertxt
            // 
            this.borrowertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowertxt.Location = new System.Drawing.Point(414, 161);
            this.borrowertxt.Margin = new System.Windows.Forms.Padding(4);
            this.borrowertxt.Name = "borrowertxt";
            this.borrowertxt.ReadOnly = true;
            this.borrowertxt.Size = new System.Drawing.Size(253, 30);
            this.borrowertxt.TabIndex = 131;
            // 
            // equipmentstatustxt
            // 
            this.equipmentstatustxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentstatustxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentstatustxt.FormattingEnabled = true;
            this.equipmentstatustxt.Items.AddRange(new object[] {
            "Lost",
            "Damaged",
            "OK"});
            this.equipmentstatustxt.Location = new System.Drawing.Point(200, 584);
            this.equipmentstatustxt.Name = "equipmentstatustxt";
            this.equipmentstatustxt.Size = new System.Drawing.Size(468, 33);
            this.equipmentstatustxt.TabIndex = 141;
            this.equipmentstatustxt.SelectedIndexChanged += new System.EventHandler(this.EquipmentStatusButtonControl);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(23, 593);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(162, 24);
            this.label21.TabIndex = 140;
            this.label21.Text = "Equipment Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(270, 129);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 24);
            this.label6.TabIndex = 127;
            this.label6.Text = "Equipment ID:";
            // 
            // equipmenttxt
            // 
            this.equipmenttxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmenttxt.Location = new System.Drawing.Point(414, 123);
            this.equipmenttxt.Margin = new System.Windows.Forms.Padding(4);
            this.equipmenttxt.Name = "equipmenttxt";
            this.equipmenttxt.ReadOnly = true;
            this.equipmenttxt.Size = new System.Drawing.Size(253, 30);
            this.equipmenttxt.TabIndex = 126;
            this.equipmenttxt.TextChanged += new System.EventHandler(this.Load_Equipment);
            // 
            // equipmentconditiontxt
            // 
            this.equipmentconditiontxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentconditiontxt.Location = new System.Drawing.Point(200, 516);
            this.equipmentconditiontxt.Name = "equipmentconditiontxt";
            this.equipmentconditiontxt.ReadOnly = true;
            this.equipmentconditiontxt.Size = new System.Drawing.Size(467, 28);
            this.equipmentconditiontxt.TabIndex = 98;
            // 
            // equipmenttypetxt
            // 
            this.equipmenttypetxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmenttypetxt.Location = new System.Drawing.Point(200, 448);
            this.equipmenttypetxt.Name = "equipmenttypetxt";
            this.equipmenttypetxt.ReadOnly = true;
            this.equipmenttypetxt.Size = new System.Drawing.Size(467, 28);
            this.equipmenttypetxt.TabIndex = 97;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 554);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 24);
            this.label1.TabIndex = 95;
            this.label1.Text = "Added by:";
            // 
            // equipmentadminidtxt
            // 
            this.equipmentadminidtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentadminidtxt.Location = new System.Drawing.Point(200, 550);
            this.equipmentadminidtxt.Name = "equipmentadminidtxt";
            this.equipmentadminidtxt.ReadOnly = true;
            this.equipmentadminidtxt.Size = new System.Drawing.Size(467, 28);
            this.equipmentadminidtxt.TabIndex = 96;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.equipmentPicture);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 59);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(201, 190);
            this.groupBox2.TabIndex = 93;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Photo";
            // 
            // equipmentPicture
            // 
            this.equipmentPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equipmentPicture.Location = new System.Drawing.Point(4, 27);
            this.equipmentPicture.Margin = new System.Windows.Forms.Padding(4);
            this.equipmentPicture.Name = "equipmentPicture";
            this.equipmentPicture.Size = new System.Drawing.Size(193, 159);
            this.equipmentPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.equipmentPicture.TabIndex = 69;
            this.equipmentPicture.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(119, 384);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 24);
            this.label7.TabIndex = 78;
            this.label7.Text = "Name:";
            // 
            // equipmentnametxt
            // 
            this.equipmentnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentnametxt.Location = new System.Drawing.Point(200, 380);
            this.equipmentnametxt.Name = "equipmentnametxt";
            this.equipmentnametxt.ReadOnly = true;
            this.equipmentnametxt.Size = new System.Drawing.Size(467, 28);
            this.equipmentnametxt.TabIndex = 80;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(102, 486);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 24);
            this.label8.TabIndex = 81;
            this.label8.Text = "Quantity:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(90, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 24);
            this.label11.TabIndex = 91;
            this.label11.Text = "Condition:";
            // 
            // quantitytxt
            // 
            this.quantitytxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantitytxt.Location = new System.Drawing.Point(200, 482);
            this.quantitytxt.Name = "quantitytxt";
            this.quantitytxt.ReadOnly = true;
            this.quantitytxt.Size = new System.Drawing.Size(467, 28);
            this.quantitytxt.TabIndex = 82;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(127, 452);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(58, 24);
            this.label12.TabIndex = 83;
            this.label12.Text = "Type:";
            // 
            // equipmentnumbertxt
            // 
            this.equipmentnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentnumbertxt.Location = new System.Drawing.Point(200, 414);
            this.equipmentnumbertxt.Name = "equipmentnumbertxt";
            this.equipmentnumbertxt.ReadOnly = true;
            this.equipmentnumbertxt.Size = new System.Drawing.Size(467, 28);
            this.equipmentnumbertxt.TabIndex = 89;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(101, 418);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 24);
            this.label13.TabIndex = 88;
            this.label13.Text = "Number:";
            // 
            // Borrowed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2GroupBox1);
            this.Controls.Add(this.panel2);
            this.Name = "Borrowed";
            this.Size = new System.Drawing.Size(1706, 790);
            this.Load += new System.EventHandler(this.Borrowed_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borrowedequipmentdatagrid)).EndInit();
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.equipmentPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.TextBox equipmentconditiontxt;
        private System.Windows.Forms.TextBox equipmenttypetxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox equipmentadminidtxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox equipmentPicture;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox equipmentnametxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox quantitytxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox equipmentnumbertxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox equipmenttxt;
        private System.Windows.Forms.ComboBox equipmentstatustxt;
        private System.Windows.Forms.Label label21;
        private Guna.UI2.WinForms.Guna2Button markequipmentbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox borrowertxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TransactionID;
        private System.Windows.Forms.DataGridView borrowedequipmentdatagrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.TextBox scheduletxt;
        private System.Windows.Forms.TextBox dateborrowedtxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox personneltxt;
    }
}
