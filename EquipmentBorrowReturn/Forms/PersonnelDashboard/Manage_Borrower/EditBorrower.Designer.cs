namespace EquipmentBorrowReturn.Forms.PersonnelDashboard.Manage_Borrower
{
    partial class EditBorrower
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
            this.borrowerinfoDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removebtn = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middlenametxt = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.firstnametxt = new System.Windows.Forms.TextBox();
            this.borrowerPicture = new System.Windows.Forms.PictureBox();
            this.lastnametxt = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.contactnumbertxt = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.emailtxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.addresstxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.borroweridtxt = new System.Windows.Forms.TextBox();
            this.updatepicCheck = new Guna.UI2.WinForms.Guna2CheckBox();
            this.updatebtn = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.searchtxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerinfoDataGrid)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.borrowerPicture)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // borrowerinfoDataGrid
            // 
            this.borrowerinfoDataGrid.AllowUserToAddRows = false;
            this.borrowerinfoDataGrid.AllowUserToDeleteRows = false;
            this.borrowerinfoDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.borrowerinfoDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.borrowerinfoDataGrid.Location = new System.Drawing.Point(16, 22);
            this.borrowerinfoDataGrid.Name = "borrowerinfoDataGrid";
            this.borrowerinfoDataGrid.RowHeadersVisible = false;
            this.borrowerinfoDataGrid.RowTemplate.Height = 24;
            this.borrowerinfoDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.borrowerinfoDataGrid.Size = new System.Drawing.Size(1037, 477);
            this.borrowerinfoDataGrid.TabIndex = 98;
            this.borrowerinfoDataGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetBorrowerInfoGrid);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "id";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "firstname";
            this.Column2.HeaderText = "First Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "middlename";
            this.Column3.HeaderText = "Middle Name";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "lastname";
            this.Column4.HeaderText = "Last Name";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "address";
            this.Column5.HeaderText = "Address";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "contactnumber";
            this.Column6.HeaderText = "Contact Number";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "email";
            this.Column7.HeaderText = "Email";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "image";
            this.Column8.HeaderText = "Borrower Picture";
            this.Column8.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column8.Name = "Column8";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.borrowerinfoDataGrid);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(616, 122);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1070, 520);
            this.panel1.TabIndex = 104;
            // 
            // removebtn
            // 
            this.removebtn.CheckedState.Parent = this.removebtn;
            this.removebtn.CustomImages.Parent = this.removebtn;
            this.removebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.removebtn.ForeColor = System.Drawing.Color.White;
            this.removebtn.HoverState.Parent = this.removebtn;
            this.removebtn.Location = new System.Drawing.Point(230, 638);
            this.removebtn.Name = "removebtn";
            this.removebtn.ShadowDecoration.Parent = this.removebtn;
            this.removebtn.Size = new System.Drawing.Size(156, 50);
            this.removebtn.TabIndex = 102;
            this.removebtn.Text = "REMOVE";
            this.removebtn.Click += new System.EventHandler(this.removebtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 403);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 24);
            this.label2.TabIndex = 103;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 366);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 24);
            this.label1.TabIndex = 102;
            this.label1.Text = "Middle Name:";
            // 
            // middlenametxt
            // 
            this.middlenametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.middlenametxt.Location = new System.Drawing.Point(158, 365);
            this.middlenametxt.Name = "middlenametxt";
            this.middlenametxt.Size = new System.Drawing.Size(409, 28);
            this.middlenametxt.TabIndex = 100;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(32, 335);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 24);
            this.label15.TabIndex = 78;
            this.label15.Text = "First Name:";
            // 
            // firstnametxt
            // 
            this.firstnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstnametxt.Location = new System.Drawing.Point(158, 331);
            this.firstnametxt.Name = "firstnametxt";
            this.firstnametxt.Size = new System.Drawing.Size(409, 28);
            this.firstnametxt.TabIndex = 80;
            // 
            // borrowerPicture
            // 
            this.borrowerPicture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.borrowerPicture.Location = new System.Drawing.Point(4, 27);
            this.borrowerPicture.Margin = new System.Windows.Forms.Padding(4);
            this.borrowerPicture.Name = "borrowerPicture";
            this.borrowerPicture.Size = new System.Drawing.Size(183, 159);
            this.borrowerPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.borrowerPicture.TabIndex = 69;
            this.borrowerPicture.TabStop = false;
            // 
            // lastnametxt
            // 
            this.lastnametxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastnametxt.Location = new System.Drawing.Point(158, 399);
            this.lastnametxt.Name = "lastnametxt";
            this.lastnametxt.Size = new System.Drawing.Size(409, 28);
            this.lastnametxt.TabIndex = 101;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(43, 609);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 24);
            this.label17.TabIndex = 99;
            this.label17.Text = "Contact #:";
            // 
            // contactnumbertxt
            // 
            this.contactnumbertxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactnumbertxt.Location = new System.Drawing.Point(158, 606);
            this.contactnumbertxt.Name = "contactnumbertxt";
            this.contactnumbertxt.Size = new System.Drawing.Size(409, 28);
            this.contactnumbertxt.TabIndex = 98;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 569);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(62, 24);
            this.label16.TabIndex = 97;
            this.label16.Text = "Email:";
            // 
            // emailtxt
            // 
            this.emailtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailtxt.Location = new System.Drawing.Point(158, 569);
            this.emailtxt.Name = "emailtxt";
            this.emailtxt.Size = new System.Drawing.Size(409, 28);
            this.emailtxt.TabIndex = 96;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(51, 467);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(85, 24);
            this.label14.TabIndex = 95;
            this.label14.Text = "Address:";
            // 
            // addresstxt
            // 
            this.addresstxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresstxt.Location = new System.Drawing.Point(158, 467);
            this.addresstxt.Multiline = true;
            this.addresstxt.Name = "addresstxt";
            this.addresstxt.Size = new System.Drawing.Size(409, 92);
            this.addresstxt.TabIndex = 94;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.borrowerPicture);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(214, 108);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(191, 190);
            this.groupBox1.TabIndex = 93;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Photo";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.label3);
            this.guna2GroupBox2.Controls.Add(this.borroweridtxt);
            this.guna2GroupBox2.Controls.Add(this.updatepicCheck);
            this.guna2GroupBox2.Controls.Add(this.updatebtn);
            this.guna2GroupBox2.Controls.Add(this.removebtn);
            this.guna2GroupBox2.Controls.Add(this.label2);
            this.guna2GroupBox2.Controls.Add(this.label1);
            this.guna2GroupBox2.Controls.Add(this.lastnametxt);
            this.guna2GroupBox2.Controls.Add(this.middlenametxt);
            this.guna2GroupBox2.Controls.Add(this.label17);
            this.guna2GroupBox2.Controls.Add(this.contactnumbertxt);
            this.guna2GroupBox2.Controls.Add(this.label16);
            this.guna2GroupBox2.Controls.Add(this.emailtxt);
            this.guna2GroupBox2.Controls.Add(this.label14);
            this.guna2GroupBox2.Controls.Add(this.addresstxt);
            this.guna2GroupBox2.Controls.Add(this.groupBox1);
            this.guna2GroupBox2.Controls.Add(this.label15);
            this.guna2GroupBox2.Controls.Add(this.firstnametxt);
            this.guna2GroupBox2.CustomBorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.guna2GroupBox2.FillColor = System.Drawing.Color.Transparent;
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.Black;
            this.guna2GroupBox2.Location = new System.Drawing.Point(16, 14);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(594, 706);
            this.guna2GroupBox2.TabIndex = 103;
            this.guna2GroupBox2.Text = "Borrower Information";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Borrower ID:";
            // 
            // borroweridtxt
            // 
            this.borroweridtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borroweridtxt.Location = new System.Drawing.Point(308, 55);
            this.borroweridtxt.Margin = new System.Windows.Forms.Padding(4);
            this.borroweridtxt.Name = "borroweridtxt";
            this.borroweridtxt.ReadOnly = true;
            this.borroweridtxt.Size = new System.Drawing.Size(124, 30);
            this.borroweridtxt.TabIndex = 102;
            // 
            // updatepicCheck
            // 
            this.updatepicCheck.AutoSize = true;
            this.updatepicCheck.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatepicCheck.CheckedState.BorderRadius = 0;
            this.updatepicCheck.CheckedState.BorderThickness = 0;
            this.updatepicCheck.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.updatepicCheck.Location = new System.Drawing.Point(181, 301);
            this.updatepicCheck.Name = "updatepicCheck";
            this.updatepicCheck.Size = new System.Drawing.Size(266, 24);
            this.updatepicCheck.TabIndex = 106;
            this.updatepicCheck.Text = "Check if you want to update picture";
            this.updatepicCheck.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.updatepicCheck.UncheckedState.BorderRadius = 0;
            this.updatepicCheck.UncheckedState.BorderThickness = 0;
            this.updatepicCheck.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            // 
            // updatebtn
            // 
            this.updatebtn.CheckedState.Parent = this.updatebtn;
            this.updatebtn.CustomImages.Parent = this.updatebtn;
            this.updatebtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updatebtn.ForeColor = System.Drawing.Color.White;
            this.updatebtn.HoverState.Parent = this.updatebtn;
            this.updatebtn.Location = new System.Drawing.Point(411, 638);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.ShadowDecoration.Parent = this.updatebtn;
            this.updatebtn.Size = new System.Drawing.Size(156, 50);
            this.updatebtn.TabIndex = 105;
            this.updatebtn.Text = "UPDATE";
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(621, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 24);
            this.label4.TabIndex = 109;
            this.label4.Text = "Search Borrower:";
            // 
            // searchtxt
            // 
            this.searchtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchtxt.Location = new System.Drawing.Point(797, 86);
            this.searchtxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchtxt.Name = "searchtxt";
            this.searchtxt.Size = new System.Drawing.Size(453, 30);
            this.searchtxt.TabIndex = 108;
            this.searchtxt.TextChanged += new System.EventHandler(this.SearchBorrower);
            // 
            // EditBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.searchtxt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Name = "EditBorrower";
            this.Size = new System.Drawing.Size(1706, 734);
            this.Load += new System.EventHandler(this.EditBorrower_Load);
            ((System.ComponentModel.ISupportInitialize)(this.borrowerinfoDataGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.borrowerPicture)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView borrowerinfoDataGrid;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button removebtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox middlenametxt;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox firstnametxt;
        private System.Windows.Forms.PictureBox borrowerPicture;
        private System.Windows.Forms.TextBox lastnametxt;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox contactnumbertxt;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox emailtxt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox addresstxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private Guna.UI2.WinForms.Guna2CheckBox updatepicCheck;
        private Guna.UI2.WinForms.Guna2Button updatebtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox borroweridtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox searchtxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewImageColumn Column8;
    }
}
