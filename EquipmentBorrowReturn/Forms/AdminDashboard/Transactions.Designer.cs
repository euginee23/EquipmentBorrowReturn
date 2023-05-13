namespace EquipmentBorrowReturn
{
    partial class Transactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Transactions));
            this.export = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transactiontypefilter = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exportword = new Guna.UI2.WinForms.Guna2Button();
            this.transactionHistory = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // export
            // 
            this.export.CheckedState.Parent = this.export;
            this.export.CustomImages.Parent = this.export;
            this.export.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.export.ForeColor = System.Drawing.Color.White;
            this.export.HoverState.Parent = this.export;
            this.export.Location = new System.Drawing.Point(1506, 718);
            this.export.Name = "export";
            this.export.ShadowDecoration.Parent = this.export;
            this.export.Size = new System.Drawing.Size(180, 45);
            this.export.TabIndex = 1;
            this.export.Text = "Export Excel";
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 708);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Filter By Transaction Type:";
            // 
            // transactiontypefilter
            // 
            this.transactiontypefilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transactiontypefilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.transactiontypefilter.FormattingEnabled = true;
            this.transactiontypefilter.Items.AddRange(new object[] {
            "Borrowing Equipment",
            "Checking of Equipment",
            "Returning of Equipment"});
            this.transactiontypefilter.Location = new System.Drawing.Point(26, 730);
            this.transactiontypefilter.Name = "transactiontypefilter";
            this.transactiontypefilter.Size = new System.Drawing.Size(275, 33);
            this.transactiontypefilter.TabIndex = 3;
            this.transactiontypefilter.TextChanged += new System.EventHandler(this.TransctionFilter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(307, 730);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.RefreshClick);
            // 
            // exportword
            // 
            this.exportword.CheckedState.Parent = this.exportword;
            this.exportword.CustomImages.Parent = this.exportword;
            this.exportword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.exportword.ForeColor = System.Drawing.Color.White;
            this.exportword.HoverState.Parent = this.exportword;
            this.exportword.Location = new System.Drawing.Point(1291, 718);
            this.exportword.Name = "exportword";
            this.exportword.ShadowDecoration.Parent = this.exportword;
            this.exportword.Size = new System.Drawing.Size(180, 45);
            this.exportword.TabIndex = 5;
            this.exportword.Text = "Export Word";
            this.exportword.Click += new System.EventHandler(this.exportword_Click);
            // 
            // transactionHistory
            // 
            this.transactionHistory.AllowUserToAddRows = false;
            this.transactionHistory.AllowUserToDeleteRows = false;
            this.transactionHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionHistory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.transactionHistory.Location = new System.Drawing.Point(26, 19);
            this.transactionHistory.Name = "transactionHistory";
            this.transactionHistory.RowHeadersVisible = false;
            this.transactionHistory.RowTemplate.Height = 24;
            this.transactionHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.transactionHistory.Size = new System.Drawing.Size(1660, 675);
            this.transactionHistory.TabIndex = 0;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column10.DataPropertyName = "transactiondate";
            this.Column10.HeaderText = "Transaction Date";
            this.Column10.Name = "Column10";
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column9.DataPropertyName = "email";
            this.Column9.HeaderText = "Borrower Email";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "address";
            this.Column8.HeaderText = "Borrower Address";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "contactnumber";
            this.Column7.HeaderText = "Borrower Contact";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "borrower_name";
            this.Column6.HeaderText = "Borrower Name";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "personnel_name";
            this.Column5.HeaderText = "Personnel Name";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "equipmentname";
            this.Column4.HeaderText = "Equipment Name";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "quantityborrowed";
            this.Column3.FillWeight = 50F;
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "transactiontype";
            this.Column2.HeaderText = "Transaction Type";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "transaction_id";
            this.Column1.FillWeight = 80F;
            this.Column1.HeaderText = "Transaction ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.exportword);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.transactiontypefilter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.export);
            this.Controls.Add(this.transactionHistory);
            this.Name = "Transactions";
            this.Size = new System.Drawing.Size(1706, 790);
            this.Load += new System.EventHandler(this.Transactions_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionHistory)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button export;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox transactiontypefilter;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button exportword;
        private System.Windows.Forms.DataGridView transactionHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
    }
}
