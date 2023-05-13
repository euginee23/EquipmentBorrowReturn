namespace EquipmentBorrowReturn.Forms.AdminDashboard.Manage_Personnels
{
    partial class ManagePersonnel
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
            this.managepersonnelpanelcontainer = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.editequipmentpanelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.addpersonnelpanelbtn = new Guna.UI2.WinForms.Guna2Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // managepersonnelpanelcontainer
            // 
            this.managepersonnelpanelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managepersonnelpanelcontainer.Location = new System.Drawing.Point(0, 56);
            this.managepersonnelpanelcontainer.Name = "managepersonnelpanelcontainer";
            this.managepersonnelpanelcontainer.Size = new System.Drawing.Size(1706, 734);
            this.managepersonnelpanelcontainer.TabIndex = 64;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editequipmentpanelbtn);
            this.panel1.Controls.Add(this.addpersonnelpanelbtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1706, 56);
            this.panel1.TabIndex = 63;
            // 
            // editequipmentpanelbtn
            // 
            this.editequipmentpanelbtn.CheckedState.Parent = this.editequipmentpanelbtn;
            this.editequipmentpanelbtn.CustomImages.Parent = this.editequipmentpanelbtn;
            this.editequipmentpanelbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editequipmentpanelbtn.ForeColor = System.Drawing.Color.White;
            this.editequipmentpanelbtn.HoverState.Parent = this.editequipmentpanelbtn;
            this.editequipmentpanelbtn.Location = new System.Drawing.Point(189, 5);
            this.editequipmentpanelbtn.Name = "editequipmentpanelbtn";
            this.editequipmentpanelbtn.ShadowDecoration.Parent = this.editequipmentpanelbtn;
            this.editequipmentpanelbtn.Size = new System.Drawing.Size(180, 45);
            this.editequipmentpanelbtn.TabIndex = 1;
            this.editequipmentpanelbtn.Text = "EDIT PERSONNEL";
            this.editequipmentpanelbtn.Click += new System.EventHandler(this.editequipmentpanelbtn_Click);
            // 
            // addpersonnelpanelbtn
            // 
            this.addpersonnelpanelbtn.CheckedState.Parent = this.addpersonnelpanelbtn;
            this.addpersonnelpanelbtn.CustomImages.Parent = this.addpersonnelpanelbtn;
            this.addpersonnelpanelbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addpersonnelpanelbtn.ForeColor = System.Drawing.Color.White;
            this.addpersonnelpanelbtn.HoverState.Parent = this.addpersonnelpanelbtn;
            this.addpersonnelpanelbtn.Location = new System.Drawing.Point(3, 5);
            this.addpersonnelpanelbtn.Name = "addpersonnelpanelbtn";
            this.addpersonnelpanelbtn.ShadowDecoration.Parent = this.addpersonnelpanelbtn;
            this.addpersonnelpanelbtn.Size = new System.Drawing.Size(180, 45);
            this.addpersonnelpanelbtn.TabIndex = 0;
            this.addpersonnelpanelbtn.Text = "ADD PERSONNEL";
            this.addpersonnelpanelbtn.Click += new System.EventHandler(this.addpersonnelpanelbtn_Click);
            // 
            // ManagePersonnel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managepersonnelpanelcontainer);
            this.Controls.Add(this.panel1);
            this.Name = "ManagePersonnel";
            this.Size = new System.Drawing.Size(1706, 790);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel managepersonnelpanelcontainer;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button editequipmentpanelbtn;
        private Guna.UI2.WinForms.Guna2Button addpersonnelpanelbtn;
    }
}
