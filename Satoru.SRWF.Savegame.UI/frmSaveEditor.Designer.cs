namespace Satoru.SRWF.Savegame.UI
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
            this.numCFFunds = new System.Windows.Forms.NumericUpDown();
            this.lblFunds = new System.Windows.Forms.Label();
            this.tabAddUnit = new System.Windows.Forms.TabPage();
            this.tabModifyUnit = new System.Windows.Forms.TabPage();
            this.grpMUUnit = new System.Windows.Forms.GroupBox();
            this.picMU = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboMUUnit = new System.Windows.Forms.ComboBox();
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
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMUId = new System.Windows.Forms.TextBox();
            this.txtMUHexa = new System.Windows.Forms.TextBox();
            this.txtMUHP = new System.Windows.Forms.TextBox();
            this.txtMULimit = new System.Windows.Forms.TextBox();
            this.txtMUArmor = new System.Windows.Forms.TextBox();
            this.txtMUMobility = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMUNote = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statusBottom.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChangeFunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCFFunds)).BeginInit();
            this.tabModifyUnit.SuspendLayout();
            this.grpMUUnit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMU)).BeginInit();
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
            this.tabChangeFunds.Controls.Add(this.numCFFunds);
            this.tabChangeFunds.Controls.Add(this.lblFunds);
            this.tabChangeFunds.Location = new System.Drawing.Point(4, 29);
            this.tabChangeFunds.Name = "tabChangeFunds";
            this.tabChangeFunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeFunds.Size = new System.Drawing.Size(1139, 686);
            this.tabChangeFunds.TabIndex = 0;
            this.tabChangeFunds.Text = "Change Funds (資金)";
            this.tabChangeFunds.UseVisualStyleBackColor = true;
            // 
            // numCFFunds
            // 
            this.numCFFunds.Increment = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCFFunds.Location = new System.Drawing.Point(128, 9);
            this.numCFFunds.Maximum = new decimal(new int[] {
            9999500,
            0,
            0,
            0});
            this.numCFFunds.Name = "numCFFunds";
            this.numCFFunds.Size = new System.Drawing.Size(160, 26);
            this.numCFFunds.TabIndex = 1;
            // 
            // lblFunds
            // 
            this.lblFunds.AutoSize = true;
            this.lblFunds.Location = new System.Drawing.Point(18, 11);
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
            this.tabModifyUnit.Controls.Add(this.grpMUUnit);
            this.tabModifyUnit.Controls.Add(this.label1);
            this.tabModifyUnit.Controls.Add(this.cboMUUnit);
            this.tabModifyUnit.Location = new System.Drawing.Point(4, 29);
            this.tabModifyUnit.Name = "tabModifyUnit";
            this.tabModifyUnit.Size = new System.Drawing.Size(1139, 686);
            this.tabModifyUnit.TabIndex = 3;
            this.tabModifyUnit.Text = "Modify Unit (ユニット)";
            this.tabModifyUnit.UseVisualStyleBackColor = true;
            // 
            // grpMUUnit
            // 
            this.grpMUUnit.Controls.Add(this.label9);
            this.grpMUUnit.Controls.Add(this.txtMUNote);
            this.grpMUUnit.Controls.Add(this.label8);
            this.grpMUUnit.Controls.Add(this.txtMULimit);
            this.grpMUUnit.Controls.Add(this.txtMUArmor);
            this.grpMUUnit.Controls.Add(this.txtMUMobility);
            this.grpMUUnit.Controls.Add(this.label4);
            this.grpMUUnit.Controls.Add(this.label5);
            this.grpMUUnit.Controls.Add(this.txtMUHP);
            this.grpMUUnit.Controls.Add(this.txtMUHexa);
            this.grpMUUnit.Controls.Add(this.txtMUId);
            this.grpMUUnit.Controls.Add(this.label6);
            this.grpMUUnit.Controls.Add(this.label7);
            this.grpMUUnit.Controls.Add(this.picMU);
            this.grpMUUnit.Controls.Add(this.label3);
            this.grpMUUnit.Controls.Add(this.label2);
            this.grpMUUnit.Location = new System.Drawing.Point(8, 43);
            this.grpMUUnit.Name = "grpMUUnit";
            this.grpMUUnit.Size = new System.Drawing.Size(1123, 241);
            this.grpMUUnit.TabIndex = 4;
            this.grpMUUnit.TabStop = false;
            this.grpMUUnit.Text = "Unit";
            // 
            // picMU
            // 
            this.picMU.AccessibleName = "Modify Unit - Sample Picture";
            this.picMU.ErrorImage = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.InitialImage = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.Location = new System.Drawing.Point(699, 22);
            this.picMU.Name = "picMU";
            this.picMU.Size = new System.Drawing.Size(252, 189);
            this.picMU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picMU.TabIndex = 8;
            this.picMU.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(313, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hexa:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose a Unit:";
            // 
            // cboMUUnit
            // 
            this.cboMUUnit.FormattingEnabled = true;
            this.cboMUUnit.Location = new System.Drawing.Point(155, 9);
            this.cboMUUnit.Name = "cboMUUnit";
            this.cboMUUnit.Size = new System.Drawing.Size(216, 28);
            this.cboMUUnit.TabIndex = 0;
            this.cboMUUnit.SelectedIndexChanged += new System.EventHandler(this.cboUnit_SelectedIndexChanged);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobility (運動性):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(539, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "HP:";
            // 
            // txtMUId
            // 
            this.txtMUId.Location = new System.Drawing.Point(147, 22);
            this.txtMUId.Name = "txtMUId";
            this.txtMUId.ReadOnly = true;
            this.txtMUId.Size = new System.Drawing.Size(100, 26);
            this.txtMUId.TabIndex = 11;
            // 
            // txtMUHexa
            // 
            this.txtMUHexa.Location = new System.Drawing.Point(369, 22);
            this.txtMUHexa.Name = "txtMUHexa";
            this.txtMUHexa.ReadOnly = true;
            this.txtMUHexa.Size = new System.Drawing.Size(100, 26);
            this.txtMUHexa.TabIndex = 12;
            // 
            // txtMUHP
            // 
            this.txtMUHP.Location = new System.Drawing.Point(580, 22);
            this.txtMUHP.Name = "txtMUHP";
            this.txtMUHP.ReadOnly = true;
            this.txtMUHP.Size = new System.Drawing.Size(100, 26);
            this.txtMUHP.TabIndex = 13;
            // 
            // txtMULimit
            // 
            this.txtMULimit.Location = new System.Drawing.Point(580, 55);
            this.txtMULimit.Name = "txtMULimit";
            this.txtMULimit.ReadOnly = true;
            this.txtMULimit.Size = new System.Drawing.Size(100, 26);
            this.txtMULimit.TabIndex = 18;
            // 
            // txtMUArmor
            // 
            this.txtMUArmor.Location = new System.Drawing.Point(369, 54);
            this.txtMUArmor.Name = "txtMUArmor";
            this.txtMUArmor.ReadOnly = true;
            this.txtMUArmor.Size = new System.Drawing.Size(100, 26);
            this.txtMUArmor.TabIndex = 17;
            // 
            // txtMUMobility
            // 
            this.txtMUMobility.Location = new System.Drawing.Point(147, 55);
            this.txtMUMobility.Name = "txtMUMobility";
            this.txtMUMobility.ReadOnly = true;
            this.txtMUMobility.Size = new System.Drawing.Size(100, 26);
            this.txtMUMobility.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(482, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Limit (限界):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(263, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Armor (装甲):";
            // 
            // txtMUNote
            // 
            this.txtMUNote.Location = new System.Drawing.Point(147, 88);
            this.txtMUNote.Name = "txtMUNote";
            this.txtMUNote.ReadOnly = true;
            this.txtMUNote.Size = new System.Drawing.Size(322, 26);
            this.txtMUNote.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(89, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Note:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(799, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sample";
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
            ((System.ComponentModel.ISupportInitialize)(this.numCFFunds)).EndInit();
            this.tabModifyUnit.ResumeLayout(false);
            this.tabModifyUnit.PerformLayout();
            this.grpMUUnit.ResumeLayout(false);
            this.grpMUUnit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMU)).EndInit();
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
        private System.Windows.Forms.NumericUpDown numCFFunds;
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
        private System.Windows.Forms.ComboBox cboMUUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpMUUnit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picMU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMUId;
        private System.Windows.Forms.TextBox txtMULimit;
        private System.Windows.Forms.TextBox txtMUArmor;
        private System.Windows.Forms.TextBox txtMUMobility;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMUHP;
        private System.Windows.Forms.TextBox txtMUHexa;
        private System.Windows.Forms.TextBox txtMUNote;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}