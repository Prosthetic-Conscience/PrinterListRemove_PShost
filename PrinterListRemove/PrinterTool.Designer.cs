namespace PrinterListRemove
{
    partial class PrinterTool
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
            this.btnListPrinters = new System.Windows.Forms.Button();
            this.checkedListBoxPrinters = new System.Windows.Forms.CheckedListBox();
            this.btnRemovePrinters = new System.Windows.Forms.Button();
            this.cbDriver = new System.Windows.Forms.CheckBox();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnEndPrintJobs = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.rtbIPConfig = new System.Windows.Forms.RichTextBox();
            this.btnIpConfig = new System.Windows.Forms.Button();
            this.btnRenewLease = new System.Windows.Forms.Button();
            this.btnFlushDNS = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnForceShutdown = new System.Windows.Forms.Button();
            this.btnStartClean = new System.Windows.Forms.Button();
            this.btnDeleteCBSLogs = new System.Windows.Forms.Button();
            this.btnAppRemove = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.clbInstalledApps = new System.Windows.Forms.CheckedListBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnListPrinters
            // 
            this.btnListPrinters.Location = new System.Drawing.Point(56, 19);
            this.btnListPrinters.Name = "btnListPrinters";
            this.btnListPrinters.Size = new System.Drawing.Size(147, 38);
            this.btnListPrinters.TabIndex = 0;
            this.btnListPrinters.Text = "List Printers";
            this.btnListPrinters.UseVisualStyleBackColor = true;
            this.btnListPrinters.Click += new System.EventHandler(this.btnListPrinters_Click);
            // 
            // checkedListBoxPrinters
            // 
            this.checkedListBoxPrinters.FormattingEnabled = true;
            this.checkedListBoxPrinters.Location = new System.Drawing.Point(23, 63);
            this.checkedListBoxPrinters.Name = "checkedListBoxPrinters";
            this.checkedListBoxPrinters.Size = new System.Drawing.Size(300, 244);
            this.checkedListBoxPrinters.TabIndex = 1;
            // 
            // btnRemovePrinters
            // 
            this.btnRemovePrinters.Location = new System.Drawing.Point(56, 327);
            this.btnRemovePrinters.Name = "btnRemovePrinters";
            this.btnRemovePrinters.Size = new System.Drawing.Size(147, 42);
            this.btnRemovePrinters.TabIndex = 2;
            this.btnRemovePrinters.Text = "Remove Selected";
            this.btnRemovePrinters.UseVisualStyleBackColor = true;
            this.btnRemovePrinters.Click += new System.EventHandler(this.btnRemovePrinters_Click);
            // 
            // cbDriver
            // 
            this.cbDriver.AutoSize = true;
            this.cbDriver.Location = new System.Drawing.Point(209, 341);
            this.cbDriver.Name = "cbDriver";
            this.cbDriver.Size = new System.Drawing.Size(91, 17);
            this.cbDriver.TabIndex = 3;
            this.cbDriver.Text = "Delete drivers";
            this.cbDriver.UseVisualStyleBackColor = true;
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.DimGray;
            this.rtbConsole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbConsole.ForeColor = System.Drawing.Color.Lime;
            this.rtbConsole.Location = new System.Drawing.Point(5, 436);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(568, 168);
            this.rtbConsole.TabIndex = 4;
            this.rtbConsole.Text = "";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(572, 422);
            this.tabControl1.TabIndex = 5;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(564, 396);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Printers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnEndPrintJobs);
            this.groupBox2.Location = new System.Drawing.Point(368, 15);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(153, 74);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Print Jobs";
            // 
            // btnEndPrintJobs
            // 
            this.btnEndPrintJobs.Location = new System.Drawing.Point(15, 19);
            this.btnEndPrintJobs.Name = "btnEndPrintJobs";
            this.btnEndPrintJobs.Size = new System.Drawing.Size(107, 35);
            this.btnEndPrintJobs.TabIndex = 0;
            this.btnEndPrintJobs.Text = "End All";
            this.btnEndPrintJobs.UseVisualStyleBackColor = true;
            this.btnEndPrintJobs.Click += new System.EventHandler(this.btnEndPrintJobs_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRemovePrinters);
            this.groupBox1.Controls.Add(this.cbDriver);
            this.groupBox1.Controls.Add(this.checkedListBoxPrinters);
            this.groupBox1.Controls.Add(this.btnListPrinters);
            this.groupBox1.Location = new System.Drawing.Point(7, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 375);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove Printers";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.rtbIPConfig);
            this.tabPage2.Controls.Add(this.btnIpConfig);
            this.tabPage2.Controls.Add(this.btnRenewLease);
            this.tabPage2.Controls.Add(this.btnFlushDNS);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(564, 396);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Networking";
            // 
            // rtbIPConfig
            // 
            this.rtbIPConfig.Location = new System.Drawing.Point(167, 46);
            this.rtbIPConfig.Name = "rtbIPConfig";
            this.rtbIPConfig.Size = new System.Drawing.Size(330, 344);
            this.rtbIPConfig.TabIndex = 3;
            this.rtbIPConfig.Text = "";
            // 
            // btnIpConfig
            // 
            this.btnIpConfig.Location = new System.Drawing.Point(260, 6);
            this.btnIpConfig.Name = "btnIpConfig";
            this.btnIpConfig.Size = new System.Drawing.Size(113, 34);
            this.btnIpConfig.TabIndex = 2;
            this.btnIpConfig.Text = "IP Configuration";
            this.btnIpConfig.UseVisualStyleBackColor = true;
            this.btnIpConfig.Click += new System.EventHandler(this.btnIpConfig_Click);
            // 
            // btnRenewLease
            // 
            this.btnRenewLease.Location = new System.Drawing.Point(27, 115);
            this.btnRenewLease.Name = "btnRenewLease";
            this.btnRenewLease.Size = new System.Drawing.Size(113, 34);
            this.btnRenewLease.TabIndex = 1;
            this.btnRenewLease.Text = "Release/Renew DHCP";
            this.btnRenewLease.UseVisualStyleBackColor = true;
            this.btnRenewLease.Click += new System.EventHandler(this.btnRenewLease_Click);
            // 
            // btnFlushDNS
            // 
            this.btnFlushDNS.Location = new System.Drawing.Point(27, 53);
            this.btnFlushDNS.Name = "btnFlushDNS";
            this.btnFlushDNS.Size = new System.Drawing.Size(113, 34);
            this.btnFlushDNS.TabIndex = 0;
            this.btnFlushDNS.Text = "Flush DNS cache";
            this.btnFlushDNS.UseVisualStyleBackColor = true;
            this.btnFlushDNS.Click += new System.EventHandler(this.btnFlushDNS_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.btnForceShutdown);
            this.tabPage3.Controls.Add(this.btnStartClean);
            this.tabPage3.Controls.Add(this.btnDeleteCBSLogs);
            this.tabPage3.Controls.Add(this.btnAppRemove);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(564, 396);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Tools";
            // 
            // btnForceShutdown
            // 
            this.btnForceShutdown.Location = new System.Drawing.Point(26, 250);
            this.btnForceShutdown.Margin = new System.Windows.Forms.Padding(2);
            this.btnForceShutdown.Name = "btnForceShutdown";
            this.btnForceShutdown.Size = new System.Drawing.Size(129, 40);
            this.btnForceShutdown.TabIndex = 3;
            this.btnForceShutdown.Text = "Force Restart";
            this.btnForceShutdown.UseVisualStyleBackColor = true;
            this.btnForceShutdown.Click += new System.EventHandler(this.btnForceShutdown_Click);
            // 
            // btnStartClean
            // 
            this.btnStartClean.Location = new System.Drawing.Point(26, 97);
            this.btnStartClean.Name = "btnStartClean";
            this.btnStartClean.Size = new System.Drawing.Size(129, 40);
            this.btnStartClean.TabIndex = 1;
            this.btnStartClean.Text = "Clean PC";
            this.btnStartClean.UseVisualStyleBackColor = true;
            this.btnStartClean.Click += new System.EventHandler(this.btnStartClean_Click);
            // 
            // btnDeleteCBSLogs
            // 
            this.btnDeleteCBSLogs.Location = new System.Drawing.Point(26, 25);
            this.btnDeleteCBSLogs.Name = "btnDeleteCBSLogs";
            this.btnDeleteCBSLogs.Size = new System.Drawing.Size(129, 40);
            this.btnDeleteCBSLogs.TabIndex = 0;
            this.btnDeleteCBSLogs.Text = "Delete CBS Log Files";
            this.btnDeleteCBSLogs.UseVisualStyleBackColor = true;
            this.btnDeleteCBSLogs.Click += new System.EventHandler(this.btnDeleteCBSLogs_Click);
            // 
            // btnAppRemove
            // 
            this.btnAppRemove.Location = new System.Drawing.Point(26, 170);
            this.btnAppRemove.Name = "btnAppRemove";
            this.btnAppRemove.Size = new System.Drawing.Size(129, 40);
            this.btnAppRemove.TabIndex = 2;
            this.btnAppRemove.Text = "Remove Default Apps";
            this.btnAppRemove.UseVisualStyleBackColor = true;
            this.btnAppRemove.Click += new System.EventHandler(this.btnAppRemove_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.btnRemoveSelected);
            this.tabPage4.Controls.Add(this.clbInstalledApps);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(564, 396);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Applications";
            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.Location = new System.Drawing.Point(7, 361);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(111, 32);
            this.btnRemoveSelected.TabIndex = 2;
            this.btnRemoveSelected.Text = "Remove Selected";
            this.btnRemoveSelected.UseVisualStyleBackColor = true;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);
            // 
            // clbInstalledApps
            // 
            this.clbInstalledApps.FormattingEnabled = true;
            this.clbInstalledApps.Location = new System.Drawing.Point(7, 9);
            this.clbInstalledApps.Name = "clbInstalledApps";
            this.clbInstalledApps.Size = new System.Drawing.Size(553, 349);
            this.clbInstalledApps.TabIndex = 0;
            // 
            // PrinterTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 605);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.rtbConsole);
            this.Name = "PrinterTool";
            this.Text = "Printer Tool";
            this.Load += new System.EventHandler(this.PrinterTool_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnListPrinters;
        private System.Windows.Forms.CheckedListBox checkedListBoxPrinters;
        private System.Windows.Forms.Button btnRemovePrinters;
        private System.Windows.Forms.CheckBox cbDriver;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnEndPrintJobs;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnStartClean;
        private System.Windows.Forms.Button btnDeleteCBSLogs;
        private System.Windows.Forms.Button btnForceShutdown;
        private System.Windows.Forms.Button btnAppRemove;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.CheckedListBox clbInstalledApps;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Button btnRenewLease;
        private System.Windows.Forms.Button btnFlushDNS;
        private System.Windows.Forms.Button btnIpConfig;
        private System.Windows.Forms.RichTextBox rtbIPConfig;
        }
}

