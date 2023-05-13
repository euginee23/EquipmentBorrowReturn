namespace EquipmentBorrowReturn
{
    partial class PersonnelMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonnelMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.stockoutbtn = new Guna.UI2.WinForms.Guna2Button();
            this.stockinbtn = new Guna.UI2.WinForms.Guna2Button();
            this.manageborrowersbtn = new Guna.UI2.WinForms.Guna2Button();
            this.returnbtn = new Guna.UI2.WinForms.Guna2Button();
            this.borrowbtn = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.personnelnametxt = new System.Windows.Forms.TextBox();
            this.personnelidtxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.personnelPic = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.personnelPic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1445, 44);
            this.panel1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1286, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Personnel Form";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(47, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Equipment Borrow/Return";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.stockoutbtn);
            this.panel2.Controls.Add(this.stockinbtn);
            this.panel2.Controls.Add(this.manageborrowersbtn);
            this.panel2.Controls.Add(this.returnbtn);
            this.panel2.Controls.Add(this.borrowbtn);
            this.panel2.Location = new System.Drawing.Point(161, 44);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1272, 75);
            this.panel2.TabIndex = 1;
            // 
            // stockoutbtn
            // 
            this.stockoutbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.stockoutbtn.CheckedState.Parent = this.stockoutbtn;
            this.stockoutbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.stockoutbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.stockoutbtn.CustomImages.Parent = this.stockoutbtn;
            this.stockoutbtn.FillColor = System.Drawing.Color.White;
            this.stockoutbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockoutbtn.ForeColor = System.Drawing.Color.Black;
            this.stockoutbtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.stockoutbtn.HoverState.Parent = this.stockoutbtn;
            this.stockoutbtn.Location = new System.Drawing.Point(756, 6);
            this.stockoutbtn.Name = "stockoutbtn";
            this.stockoutbtn.ShadowDecoration.Parent = this.stockoutbtn;
            this.stockoutbtn.Size = new System.Drawing.Size(180, 62);
            this.stockoutbtn.TabIndex = 4;
            this.stockoutbtn.Text = "Unavailable";
            this.stockoutbtn.Click += new System.EventHandler(this.stockoutbtn_Click);
            // 
            // stockinbtn
            // 
            this.stockinbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.stockinbtn.CheckedState.Parent = this.stockinbtn;
            this.stockinbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.stockinbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.stockinbtn.CustomImages.Parent = this.stockinbtn;
            this.stockinbtn.FillColor = System.Drawing.Color.White;
            this.stockinbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockinbtn.ForeColor = System.Drawing.Color.Black;
            this.stockinbtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.stockinbtn.HoverState.Parent = this.stockinbtn;
            this.stockinbtn.Location = new System.Drawing.Point(570, 6);
            this.stockinbtn.Name = "stockinbtn";
            this.stockinbtn.ShadowDecoration.Parent = this.stockinbtn;
            this.stockinbtn.Size = new System.Drawing.Size(180, 62);
            this.stockinbtn.TabIndex = 3;
            this.stockinbtn.Text = "Availabe";
            this.stockinbtn.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // manageborrowersbtn
            // 
            this.manageborrowersbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.manageborrowersbtn.CheckedState.Parent = this.manageborrowersbtn;
            this.manageborrowersbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.manageborrowersbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.manageborrowersbtn.CustomImages.Parent = this.manageborrowersbtn;
            this.manageborrowersbtn.FillColor = System.Drawing.Color.White;
            this.manageborrowersbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageborrowersbtn.ForeColor = System.Drawing.Color.Black;
            this.manageborrowersbtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.manageborrowersbtn.HoverState.Parent = this.manageborrowersbtn;
            this.manageborrowersbtn.Location = new System.Drawing.Point(384, 6);
            this.manageborrowersbtn.Name = "manageborrowersbtn";
            this.manageborrowersbtn.ShadowDecoration.Parent = this.manageborrowersbtn;
            this.manageborrowersbtn.Size = new System.Drawing.Size(180, 62);
            this.manageborrowersbtn.TabIndex = 2;
            this.manageborrowersbtn.Text = "Manage Borrowers";
            this.manageborrowersbtn.Click += new System.EventHandler(this.borrowedequipbtn_Click);
            // 
            // returnbtn
            // 
            this.returnbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.returnbtn.CheckedState.Parent = this.returnbtn;
            this.returnbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.returnbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.returnbtn.CustomImages.Parent = this.returnbtn;
            this.returnbtn.FillColor = System.Drawing.Color.White;
            this.returnbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnbtn.ForeColor = System.Drawing.Color.Black;
            this.returnbtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.returnbtn.HoverState.Parent = this.returnbtn;
            this.returnbtn.Location = new System.Drawing.Point(198, 6);
            this.returnbtn.Name = "returnbtn";
            this.returnbtn.ShadowDecoration.Parent = this.returnbtn;
            this.returnbtn.Size = new System.Drawing.Size(180, 62);
            this.returnbtn.TabIndex = 1;
            this.returnbtn.Text = "Return";
            this.returnbtn.Click += new System.EventHandler(this.returnbtn_Click);
            // 
            // borrowbtn
            // 
            this.borrowbtn.CheckedState.CustomBorderColor = System.Drawing.Color.Red;
            this.borrowbtn.CheckedState.Parent = this.borrowbtn;
            this.borrowbtn.CustomBorderColor = System.Drawing.Color.Black;
            this.borrowbtn.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.borrowbtn.CustomImages.Parent = this.borrowbtn;
            this.borrowbtn.FillColor = System.Drawing.Color.White;
            this.borrowbtn.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.borrowbtn.ForeColor = System.Drawing.Color.Black;
            this.borrowbtn.HoverState.CustomBorderColor = System.Drawing.Color.Red;
            this.borrowbtn.HoverState.Parent = this.borrowbtn;
            this.borrowbtn.Location = new System.Drawing.Point(12, 6);
            this.borrowbtn.Name = "borrowbtn";
            this.borrowbtn.ShadowDecoration.Parent = this.borrowbtn;
            this.borrowbtn.Size = new System.Drawing.Size(180, 62);
            this.borrowbtn.TabIndex = 0;
            this.borrowbtn.Text = "Borrow";
            this.borrowbtn.Click += new System.EventHandler(this.borrowbtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(51, 638);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.LogOutClick);
            // 
            // panelContainer
            // 
            this.panelContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelContainer.Location = new System.Drawing.Point(161, 119);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1272, 633);
            this.panelContainer.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.personnelnametxt);
            this.panel3.Controls.Add(this.personnelidtxt);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(163, 718);
            this.panel3.TabIndex = 7;
            // 
            // personnelnametxt
            // 
            this.personnelnametxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnelnametxt.Location = new System.Drawing.Point(6, 201);
            this.personnelnametxt.Name = "personnelnametxt";
            this.personnelnametxt.ReadOnly = true;
            this.personnelnametxt.Size = new System.Drawing.Size(146, 30);
            this.personnelnametxt.TabIndex = 8;
            this.personnelnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // personnelidtxt
            // 
            this.personnelidtxt.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.personnelidtxt.Location = new System.Drawing.Point(6, 165);
            this.personnelidtxt.Name = "personnelidtxt";
            this.personnelidtxt.ReadOnly = true;
            this.personnelidtxt.Size = new System.Drawing.Size(146, 30);
            this.personnelidtxt.TabIndex = 7;
            this.personnelidtxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.personnelPic);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(152, 153);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personnel";
            // 
            // personnelPic
            // 
            this.personnelPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personnelPic.Location = new System.Drawing.Point(3, 30);
            this.personnelPic.Name = "personnelPic";
            this.personnelPic.Size = new System.Drawing.Size(146, 120);
            this.personnelPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.personnelPic.TabIndex = 7;
            this.personnelPic.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 680);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 28);
            this.label3.TabIndex = 6;
            this.label3.Text = "LOG OUT";
            // 
            // PersonnelMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 762);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "PersonnelMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.personnelPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button borrowbtn;
        private Guna.UI2.WinForms.Guna2Button stockinbtn;
        private Guna.UI2.WinForms.Guna2Button manageborrowersbtn;
        private Guna.UI2.WinForms.Guna2Button returnbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button stockoutbtn;
        private System.Windows.Forms.TextBox personnelnametxt;
        private System.Windows.Forms.TextBox personnelidtxt;
        private System.Windows.Forms.PictureBox personnelPic;
    }
}