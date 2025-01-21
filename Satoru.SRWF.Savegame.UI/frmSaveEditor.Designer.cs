﻿namespace Satoru.SRWF.Savegame.UI
{
    partial class frmSaveEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSaveEditor));
            this.statusBottom = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChangeFunds = new System.Windows.Forms.TabPage();
            this.numFunds = new System.Windows.Forms.NumericUpDown();
            this.lblFunds = new System.Windows.Forms.Label();
            this.tabAddUnit = new System.Windows.Forms.TabPage();
            this.tabModifyUnit = new System.Windows.Forms.TabPage();
            this.txtUnitId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboUnit = new System.Windows.Forms.ComboBox();
            this.tabAddPilot = new System.Windows.Forms.TabPage();
            this.tabModifyPilot = new System.Windows.Forms.TabPage();
            this.tabAddPart = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.mnuTop = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.lblHexa = new System.Windows.Forms.Label();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.statusBottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChangeFunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFunds)).BeginInit();
            this.tabModifyUnit.SuspendLayout();
            this.mnuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBottom
            // 
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBottom.Location = new System.Drawing.Point(0, 802);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Size = new System.Drawing.Size(1147, 22);
            this.statusBottom.TabIndex = 9;
            this.statusBottom.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.Text = "lblStatus";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabChangeFunds);
            this.tabControl1.Controls.Add(this.tabAddUnit);
            this.tabControl1.Controls.Add(this.tabModifyUnit);
            this.tabControl1.Controls.Add(this.tabAddPilot);
            this.tabControl1.Controls.Add(this.tabModifyPilot);
            this.tabControl1.Controls.Add(this.tabAddPart);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(0, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 719);
            this.tabControl1.TabIndex = 10;
            // 
            // tabChangeFunds
            // 
            this.tabChangeFunds.Controls.Add(this.numFunds);
            this.tabChangeFunds.Controls.Add(this.lblFunds);
            this.tabChangeFunds.Location = new System.Drawing.Point(4, 29);
            this.tabChangeFunds.Name = "tabChangeFunds";
            this.tabChangeFunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeFunds.Size = new System.Drawing.Size(1139, 686);
            this.tabChangeFunds.TabIndex = 0;
            this.tabChangeFunds.Text = "Change Funds (資金)";
            this.tabChangeFunds.UseVisualStyleBackColor = true;
            // 
            // numFunds
            // 
            this.numFunds.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numFunds.Location = new System.Drawing.Point(119, 7);
            this.numFunds.Maximum = new decimal(new int[] {
            9999500,
            0,
            0,
            0});
            this.numFunds.Name = "numFunds";
            this.numFunds.Size = new System.Drawing.Size(160, 26);
            this.numFunds.TabIndex = 1;
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Location = new System.Drawing.Point(8, 8);
            this.lblFunds.Name = "lblFunds";
            this.lblFunds.Size = new System.Drawing.Size(104, 20);
            this.lblFunds.TabIndex = 0;
            this.lblFunds.Text = "Funds (資金):";
            // 
            // tabAddUnit
            // 
            this.tabAddUnit.Location = new System.Drawing.Point(4, 29);
            this.tabAddUnit.Name = "tabAddUnit";
            this.tabAddUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUnit.Size = new System.Drawing.Size(1139, 686);
            this.tabAddUnit.TabIndex = 1;
            this.tabAddUnit.Text = "Add Unit (ユニット)";
            this.tabAddUnit.UseVisualStyleBackColor = true;
            // 
            // tabModifyUnit
            // 
            this.tabModifyUnit.Controls.Add(this.txtUnitId);
            this.tabModifyUnit.Controls.Add(this.label2);
            this.tabModifyUnit.Controls.Add(this.label1);
            this.tabModifyUnit.Controls.Add(this.cboUnit);
            this.tabModifyUnit.Location = new System.Drawing.Point(4, 29);
            this.tabModifyUnit.Name = "tabModifyUnit";
            this.tabModifyUnit.Size = new System.Drawing.Size(1139, 686);
            this.tabModifyUnit.TabIndex = 3;
            this.tabModifyUnit.Text = "Modify Unit (ユニット)";
            this.tabModifyUnit.UseVisualStyleBackColor = true;
            // 
            // txtUnitId
            // 
            this.txtUnitId.Location = new System.Drawing.Point(137, 76);
            this.txtUnitId.Name = "txtUnitId";
            this.txtUnitId.Size = new System.Drawing.Size(216, 26);
            this.txtUnitId.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(101, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Unit:";
            // 
            // cboUnit
            // 
            this.cboUnit.FormattingEnabled = true;
            this.cboUnit.Location = new System.Drawing.Point(137, 13);
            this.cboUnit.Name = "cboUnit";
            this.cboUnit.Size = new System.Drawing.Size(216, 28);
            this.cboUnit.TabIndex = 0;
            this.cboUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
            // 
            // tabAddPilot
            // 
            this.tabAddPilot.Location = new System.Drawing.Point(4, 29);
            this.tabAddPilot.Name = "tabAddPilot";
            this.tabAddPilot.Size = new System.Drawing.Size(1139, 686);
            this.tabAddPilot.TabIndex = 2;
            this.tabAddPilot.Text = "Add Pilot (パイロット)";
            this.tabAddPilot.UseVisualStyleBackColor = true;
            // 
            // tabModifyPilot
            // 
            this.tabModifyPilot.Location = new System.Drawing.Point(4, 29);
            this.tabModifyPilot.Name = "tabModifyPilot";
            this.tabModifyPilot.Size = new System.Drawing.Size(1139, 686);
            this.tabModifyPilot.TabIndex = 4;
            this.tabModifyPilot.Text = "Modify Pilot (パイロット)";
            this.tabModifyPilot.UseVisualStyleBackColor = true;
            // 
            // tabAddPart
            // 
            this.tabAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddPart.Location = new System.Drawing.Point(4, 29);
            this.tabAddPart.Name = "tabAddPart";
            this.tabAddPart.Size = new System.Drawing.Size(1139, 686);
            this.tabAddPart.TabIndex = 5;
            this.tabAddPart.Text = "Add Reinforcement Parts (強化パーツ)";
            this.tabAddPart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(433, 752);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // mnuTop
            // 
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(1147, 24);
            this.mnuTop.TabIndex = 12;
            this.mnuTop.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.exitToolStripMenuItem.Text = "&Exit";
            // 
            // ofdFile
            // 
            this.ofdFile.InitialDirectory = "D:\\Jogos\\Saturn\\SSF_PreviewVer_R16\\Backup\\InternalBackup";
            this.ofdFile.Title = "Choose a hexa file";
            this.ofdFile.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdFile_FileOk);
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.Location = new System.Drawing.Point(5, 752);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(111, 36);
            this.btnOpenFolder.TabIndex = 13;
            this.btnOpenFolder.Text = "Open Savegame";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHexa.Location = new System.Drawing.Point(137, 762);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(87, 20);
            this.lblHexa.TabIndex = 15;
            this.lblHexa.Text = "Hexa Sum:";
            // 
            // txtHexa
            // 
            this.txtHexa.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexa.Location = new System.Drawing.Point(230, 756);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.ReadOnly = true;
            this.txtHexa.Size = new System.Drawing.Size(175, 26);
            this.txtHexa.TabIndex = 14;
            // 
            // frmSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 824);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaveEditor";
            this.Text = "Sega Saturn\'s Savegame Editor";
            this.Load += new System.EventHandler(this.frmSaveEditor_Load);
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabChangeFunds.ResumeLayout(false);
            this.tabChangeFunds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFunds)).EndInit();
            this.tabModifyUnit.ResumeLayout(false);
            this.tabModifyUnit.PerformLayout();
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBottom;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChangeFunds;
        private System.Windows.Forms.TabPage tabAddUnit;
        private System.Windows.Forms.TabPage tabAddPilot;
        private System.Windows.Forms.TabPage tabModifyUnit;
        private System.Windows.Forms.TabPage tabModifyPilot;
        private System.Windows.Forms.TabPage tabAddPart;
        private System.Windows.Forms.Label lblFunds;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.NumericUpDown numFunds;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.MenuStrip mnuTop;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboUnit;
        private System.Windows.Forms.TextBox txtUnitId;
        private System.Windows.Forms.Label label2;
    }
}