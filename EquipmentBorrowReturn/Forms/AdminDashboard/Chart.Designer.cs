namespace EquipmentBorrowReturn.Forms.AdminDashboard
{
    partial class Chart
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chart));
            this.label1 = new System.Windows.Forms.Label();
            this.chartEquipmentIN = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartEquipmentOUT = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.typerefresh = new System.Windows.Forms.PictureBox();
            this.equipmenttypecmb = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.conditionrefresh = new System.Windows.Forms.PictureBox();
            this.equipmentconditioncmd = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.statusrefresh = new System.Windows.Forms.PictureBox();
            this.equipmentstatuscmd = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquipmentIN)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEquipmentOUT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typerefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionrefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusrefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1638, 764);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "CHART";
            // 
            // chartEquipmentIN
            // 
            chartArea7.Name = "ChartArea1";
            this.chartEquipmentIN.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartEquipmentIN.Legends.Add(legend7);
            this.chartEquipmentIN.Location = new System.Drawing.Point(40, 126);
            this.chartEquipmentIN.Name = "chartEquipmentIN";
            series7.ChartArea = "ChartArea1";
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "Equipment";
            this.chartEquipmentIN.Series.Add(series7);
            this.chartEquipmentIN.Size = new System.Drawing.Size(762, 491);
            this.chartEquipmentIN.TabIndex = 1;
            this.chartEquipmentIN.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(24, 114);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 520);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.chartEquipmentOUT);
            this.panel2.Location = new System.Drawing.Point(878, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(796, 520);
            this.panel2.TabIndex = 3;
            // 
            // chartEquipmentOUT
            // 
            chartArea8.Name = "ChartArea1";
            this.chartEquipmentOUT.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.chartEquipmentOUT.Legends.Add(legend8);
            this.chartEquipmentOUT.Location = new System.Drawing.Point(17, 15);
            this.chartEquipmentOUT.Name = "chartEquipmentOUT";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Equipment";
            this.chartEquipmentOUT.Series.Add(series8);
            this.chartEquipmentOUT.Size = new System.Drawing.Size(762, 491);
            this.chartEquipmentOUT.TabIndex = 2;
            this.chartEquipmentOUT.Text = "chart1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(248, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "AVAILABLE EQUIPMENTS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1011, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "Lost / Damaged / Borrowed EQUIPMENTS";
            // 
            // typerefresh
            // 
            this.typerefresh.Image = ((System.Drawing.Image)(resources.GetObject("typerefresh.Image")));
            this.typerefresh.Location = new System.Drawing.Point(549, 668);
            this.typerefresh.Name = "typerefresh";
            this.typerefresh.Size = new System.Drawing.Size(37, 32);
            this.typerefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.typerefresh.TabIndex = 8;
            this.typerefresh.TabStop = false;
            this.typerefresh.Click += new System.EventHandler(this.TypeRefreshClick);
            // 
            // equipmenttypecmb
            // 
            this.equipmenttypecmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmenttypecmb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmenttypecmb.FormattingEnabled = true;
            this.equipmenttypecmb.Items.AddRange(new object[] {
            "Display",
            "Cable",
            "Tools",
            "Accessory",
            "Video",
            "Audio"});
            this.equipmenttypecmb.Location = new System.Drawing.Point(268, 668);
            this.equipmenttypecmb.Name = "equipmenttypecmb";
            this.equipmenttypecmb.Size = new System.Drawing.Size(275, 33);
            this.equipmenttypecmb.TabIndex = 7;
            this.equipmenttypecmb.TextChanged += new System.EventHandler(this.EquipmentType_Filter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 646);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Equipment Type:";
            // 
            // conditionrefresh
            // 
            this.conditionrefresh.Image = ((System.Drawing.Image)(resources.GetObject("conditionrefresh.Image")));
            this.conditionrefresh.Location = new System.Drawing.Point(549, 726);
            this.conditionrefresh.Name = "conditionrefresh";
            this.conditionrefresh.Size = new System.Drawing.Size(37, 32);
            this.conditionrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.conditionrefresh.TabIndex = 11;
            this.conditionrefresh.TabStop = false;
            this.conditionrefresh.Click += new System.EventHandler(this.ConditionRefresh_Click);
            // 
            // equipmentconditioncmd
            // 
            this.equipmentconditioncmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentconditioncmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentconditioncmd.FormattingEnabled = true;
            this.equipmentconditioncmd.Items.AddRange(new object[] {
            "New",
            "Good",
            "Fair",
            "Damaged"});
            this.equipmentconditioncmd.Location = new System.Drawing.Point(268, 726);
            this.equipmentconditioncmd.Name = "equipmentconditioncmd";
            this.equipmentconditioncmd.Size = new System.Drawing.Size(275, 33);
            this.equipmentconditioncmd.TabIndex = 10;
            this.equipmentconditioncmd.TextChanged += new System.EventHandler(this.EquipmentCondition_Filter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(265, 704);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Equipment Condition:";
            // 
            // statusrefresh
            // 
            this.statusrefresh.Image = ((System.Drawing.Image)(resources.GetObject("statusrefresh.Image")));
            this.statusrefresh.Location = new System.Drawing.Point(1394, 668);
            this.statusrefresh.Name = "statusrefresh";
            this.statusrefresh.Size = new System.Drawing.Size(37, 32);
            this.statusrefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.statusrefresh.TabIndex = 14;
            this.statusrefresh.TabStop = false;
            this.statusrefresh.Click += new System.EventHandler(this.StatusRefresh_Click);
            // 
            // equipmentstatuscmd
            // 
            this.equipmentstatuscmd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipmentstatuscmd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipmentstatuscmd.FormattingEnabled = true;
            this.equipmentstatuscmd.Items.AddRange(new object[] {
            "Lost",
            "Damaged",
            "Borrowed"});
            this.equipmentstatuscmd.Location = new System.Drawing.Point(1113, 668);
            this.equipmentstatuscmd.Name = "equipmentstatuscmd";
            this.equipmentstatuscmd.Size = new System.Drawing.Size(275, 33);
            this.equipmentstatuscmd.TabIndex = 13;
            this.equipmentstatuscmd.TextChanged += new System.EventHandler(this.EquipmentStatus_Filter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1110, 646);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Equipment Status:";
            // 
            // Chart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusrefresh);
            this.Controls.Add(this.equipmentstatuscmd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.conditionrefresh);
            this.Controls.Add(this.equipmentconditioncmd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.typerefresh);
            this.Controls.Add(this.equipmenttypecmb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chartEquipmentIN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Chart";
            this.Size = new System.Drawing.Size(1706, 790);
            this.Load += new System.EventHandler(this.Chart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartEquipmentIN)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEquipmentOUT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typerefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.conditionrefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusrefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquipmentIN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEquipmentOUT;
        private System.Windows.Forms.PictureBox typerefresh;
        private System.Windows.Forms.ComboBox equipmenttypecmb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox conditionrefresh;
        private System.Windows.Forms.ComboBox equipmentconditioncmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox statusrefresh;
        private System.Windows.Forms.ComboBox equipmentstatuscmd;
        private System.Windows.Forms.Label label6;
    }
}
