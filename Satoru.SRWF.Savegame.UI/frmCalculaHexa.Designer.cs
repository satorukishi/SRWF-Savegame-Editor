namespace Satoru.SRWF.Savegame.UI
{
    partial class frmCalculaHexa
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculaHexa));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFile = new System.Windows.Forms.OpenFileDialog();
            this.txtHexa = new System.Windows.Forms.TextBox();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblOffset = new System.Windows.Forms.Label();
            this.txtOffset = new System.Windows.Forms.TextBox();
            this.lblFileName = new System.Windows.Forms.Label();
            this.btnOpenFolder = new System.Windows.Forms.Button();
            this.timFile = new System.Windows.Forms.Timer(this.components);
            this.btnCheckHexaSum = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(293, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            // txtHexa
            // 
            this.txtHexa.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHexa.Location = new System.Drawing.Point(86, 88);
            this.txtHexa.Name = "txtHexa";
            this.txtHexa.Size = new System.Drawing.Size(175, 23);
            this.txtHexa.TabIndex = 2;
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(21, 91);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(59, 13);
            this.lblHexa.TabIndex = 3;
            this.lblHexa.Text = "Hexa Sum:";
            // 
            // lblOffset
            // 
            this.lblOffset.AutoSize = true;
            this.lblOffset.Location = new System.Drawing.Point(22, 51);
            this.lblOffset.Name = "lblOffset";
            this.lblOffset.Size = new System.Drawing.Size(58, 13);
            this.lblOffset.TabIndex = 5;
            this.lblOffset.Text = "Offset (int):";
            // 
            // txtOffset
            // 
            this.txtOffset.Font = new System.Drawing.Font("Courier New", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOffset.Location = new System.Drawing.Point(86, 47);
            this.txtOffset.Name = "txtOffset";
            this.txtOffset.Size = new System.Drawing.Size(175, 23);
            this.txtOffset.TabIndex = 4;
            this.txtOffset.Text = "20";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(12, 165);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(61, 13);
            this.lblFileName.TabIndex = 6;
            this.lblFileName.Text = "lblFileName";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.Location = new System.Drawing.Point(186, 130);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(75, 23);
            this.btnOpenFolder.TabIndex = 7;
            this.btnOpenFolder.Text = "Open Folder";
            this.btnOpenFolder.UseVisualStyleBackColor = true;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // timFile
            // 
            this.timFile.Interval = 2000;
            this.timFile.Tick += new System.EventHandler(this.timFile_Tick);
            // 
            // btnCheckHexaSum
            // 
            this.btnCheckHexaSum.Location = new System.Drawing.Point(24, 130);
            this.btnCheckHexaSum.Name = "btnCheckHexaSum";
            this.btnCheckHexaSum.Size = new System.Drawing.Size(116, 23);
            this.btnCheckHexaSum.TabIndex = 8;
            this.btnCheckHexaSum.Text = "Check Hexa Sum";
            this.btnCheckHexaSum.UseVisualStyleBackColor = true;
            this.btnCheckHexaSum.Click += new System.EventHandler(this.btnCheckHexaSum_Click);
            // 
            // frmCalculaHexa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 210);
            this.Controls.Add(this.btnCheckHexaSum);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.lblOffset);
            this.Controls.Add(this.txtOffset);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 500);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "frmCalculaHexa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Calcula Hexa";
            this.Load += new System.EventHandler(this.frmCalculaHexa_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdFile;
        private System.Windows.Forms.TextBox txtHexa;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblOffset;
        private System.Windows.Forms.TextBox txtOffset;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Button btnOpenFolder;
        private System.Windows.Forms.Timer timFile;
        private System.Windows.Forms.Button btnCheckHexaSum;
    }
}

