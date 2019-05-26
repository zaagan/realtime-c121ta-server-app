namespace RealTime_C121TA
{
    partial class Master
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Master));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.tbxHostPort = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpServerModel = new System.Windows.Forms.TabPage();
            this.fpClockServer = new AxFPCLOCK_SVRLib.AxFPCLOCK_Svr();
            this.btnClearList = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btnOpenServerNetwork = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpServerModel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpClockServer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(236)))), ((int)(((byte)(236)))));
            this.pnlHeader.Controls.Add(this.lblHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(797, 37);
            this.pnlHeader.TabIndex = 713;
            this.pnlHeader.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlHeader_Paint);
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(116)))), ((int)(((byte)(116)))));
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(162, 19);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "REALTIME SERVER";
            // 
            // tbxHostPort
            // 
            this.tbxHostPort.Location = new System.Drawing.Point(85, 18);
            this.tbxHostPort.MaxLength = 6;
            this.tbxHostPort.Name = "tbxHostPort";
            this.tbxHostPort.Size = new System.Drawing.Size(56, 25);
            this.tbxHostPort.TabIndex = 2;
            this.tbxHostPort.Text = "7005";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Host Port ";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpServerModel);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.ItemSize = new System.Drawing.Size(250, 30);
            this.tabControl1.Location = new System.Drawing.Point(0, 37);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(797, 430);
            this.tabControl1.TabIndex = 714;
            // 
            // tpServerModel
            // 
            this.tpServerModel.Controls.Add(this.fpClockServer);
            this.tpServerModel.Controls.Add(this.btnClearList);
            this.tpServerModel.Controls.Add(this.listView1);
            this.tpServerModel.Controls.Add(this.btnOpenServerNetwork);
            this.tpServerModel.Controls.Add(this.tbxHostPort);
            this.tpServerModel.Controls.Add(this.label2);
            this.tpServerModel.Location = new System.Drawing.Point(4, 34);
            this.tpServerModel.Name = "tpServerModel";
            this.tpServerModel.Padding = new System.Windows.Forms.Padding(6);
            this.tpServerModel.Size = new System.Drawing.Size(789, 392);
            this.tpServerModel.TabIndex = 1;
            this.tpServerModel.Text = "Server Mode";
            this.tpServerModel.UseVisualStyleBackColor = true;
            // 
            // fpClockServer
            // 
            this.fpClockServer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fpClockServer.Enabled = true;
            this.fpClockServer.Location = new System.Drawing.Point(674, 9);
            this.fpClockServer.Name = "fpClockServer";
            this.fpClockServer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("fpClockServer.OcxState")));
            this.fpClockServer.Size = new System.Drawing.Size(100, 41);
            this.fpClockServer.TabIndex = 9;
            this.fpClockServer.Visible = false;
            this.fpClockServer.OnReceiveGLogData += new AxFPCLOCK_SVRLib._DFPCLOCK_SvrEvents_OnReceiveGLogDataEventHandler(this.axFPCLOCK_Svr1_OnReceiveGLogData_1);
            // 
            // btnClearList
            // 
            this.btnClearList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearList.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnClearList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearList.Location = new System.Drawing.Point(645, 62);
            this.btnClearList.Name = "btnClearList";
            this.btnClearList.Size = new System.Drawing.Size(129, 35);
            this.btnClearList.TabIndex = 8;
            this.btnClearList.Text = "Clear List";
            this.btnClearList.UseVisualStyleBackColor = true;
            this.btnClearList.Click += new System.EventHandler(this.btnClearList_Click);
            // 
            // listView1
            // 
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 112);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.ShowItemToolTips = true;
            this.listView1.Size = new System.Drawing.Size(762, 262);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // btnOpenServerNetwork
            // 
            this.btnOpenServerNetwork.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.btnOpenServerNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenServerNetwork.Location = new System.Drawing.Point(12, 62);
            this.btnOpenServerNetwork.Name = "btnOpenServerNetwork";
            this.btnOpenServerNetwork.Size = new System.Drawing.Size(129, 35);
            this.btnOpenServerNetwork.TabIndex = 5;
            this.btnOpenServerNetwork.Text = "Open Network";
            this.btnOpenServerNetwork.UseVisualStyleBackColor = true;
            this.btnOpenServerNetwork.Click += new System.EventHandler(this.btnOpenServerNetwork_Click);
            // 
            // Master
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 467);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(813, 506);
            this.MinimumSize = new System.Drawing.Size(813, 506);
            this.Name = "Master";
            this.Text = "Master";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpServerModel.ResumeLayout(false);
            this.tpServerModel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fpClockServer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        public System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox tbxHostPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpServerModel;
        private System.Windows.Forms.Button btnOpenServerNetwork;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btnClearList;
        private AxFPCLOCK_SVRLib.AxFPCLOCK_Svr fpClockServer;
    }
}

