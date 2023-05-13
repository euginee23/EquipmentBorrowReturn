namespace EquipmentBorrowReturn
{
    partial class Manage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.editequipmentpanel = new Guna.UI2.WinForms.Guna2Button();
            this.addequipmentpanel = new Guna.UI2.WinForms.Guna2Button();
            this.managepanelcontainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.editequipmentpanel);
            this.panel1.Controls.Add(this.addequipmentpanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1706, 56);
            this.panel1.TabIndex = 61;
            // 
            // editequipmentpanel
            // 
            this.editequipmentpanel.CheckedState.Parent = this.editequipmentpanel;
            this.editequipmentpanel.CustomImages.Parent = this.editequipmentpanel;
            this.editequipmentpanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.editequipmentpanel.ForeColor = System.Drawing.Color.White;
            this.editequipmentpanel.HoverState.Parent = this.editequipmentpanel;
            this.editequipmentpanel.Location = new System.Drawing.Point(189, 5);
            this.editequipmentpanel.Name = "editequipmentpanel";
            this.editequipmentpanel.ShadowDecoration.Parent = this.editequipmentpanel;
            this.editequipmentpanel.Size = new System.Drawing.Size(180, 45);
            this.editequipmentpanel.TabIndex = 1;
            this.editequipmentpanel.Text = "EDIT EQUIPMENT";
            this.editequipmentpanel.Click += new System.EventHandler(this.editequipmentpanel_Click);
            // 
            // addequipmentpanel
            // 
            this.addequipmentpanel.CheckedState.Parent = this.addequipmentpanel;
            this.addequipmentpanel.CustomImages.Parent = this.addequipmentpanel;
            this.addequipmentpanel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.addequipmentpanel.ForeColor = System.Drawing.Color.White;
            this.addequipmentpanel.HoverState.Parent = this.addequipmentpanel;
            this.addequipmentpanel.Location = new System.Drawing.Point(3, 5);
            this.addequipmentpanel.Name = "addequipmentpanel";
            this.addequipmentpanel.ShadowDecoration.Parent = this.addequipmentpanel;
            this.addequipmentpanel.Size = new System.Drawing.Size(180, 45);
            this.addequipmentpanel.TabIndex = 0;
            this.addequipmentpanel.Text = "ADD EQUIPMENT";
            this.addequipmentpanel.Click += new System.EventHandler(this.addequipmentpanel_Click);
            // 
            // managepanelcontainer
            // 
            this.managepanelcontainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.managepanelcontainer.Location = new System.Drawing.Point(0, 56);
            this.managepanelcontainer.Name = "managepanelcontainer";
            this.managepanelcontainer.Size = new System.Drawing.Size(1706, 734);
            this.managepanelcontainer.TabIndex = 62;
            // 
            // Manage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.managepanelcontainer);
            this.Controls.Add(this.panel1);
            this.Name = "Manage";
            this.Size = new System.Drawing.Size(1706, 790);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel managepanelcontainer;
        private Guna.UI2.WinForms.Guna2Button editequipmentpanel;
        private Guna.UI2.WinForms.Guna2Button addequipmentpanel;
    }
}
