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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabChangeFunds = new System.Windows.Forms.TabPage();
            this.numFunds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tabAddUnit = new System.Windows.Forms.TabPage();
            this.tabModifyUnit = new System.Windows.Forms.TabPage();
            this.tabAddPilot = new System.Windows.Forms.TabPage();
            this.tabModifyPilot = new System.Windows.Forms.TabPage();
            this.tabAddPart = new System.Windows.Forms.TabPage();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabChangeFunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFunds)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 802);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1147, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
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
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(0, 0);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1147, 746);
            this.tabControl1.TabIndex = 10;
            // 
            // tabChangeFunds
            // 
            this.tabChangeFunds.Controls.Add(this.numFunds);
            this.tabChangeFunds.Controls.Add(this.label1);
            this.tabChangeFunds.Location = new System.Drawing.Point(4, 29);
            this.tabChangeFunds.Name = "tabChangeFunds";
            this.tabChangeFunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeFunds.Size = new System.Drawing.Size(1139, 713);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Funds (資金):";
            // 
            // tabAddUnit
            // 
            this.tabAddUnit.Location = new System.Drawing.Point(4, 29);
            this.tabAddUnit.Name = "tabAddUnit";
            this.tabAddUnit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddUnit.Size = new System.Drawing.Size(1139, 713);
            this.tabAddUnit.TabIndex = 1;
            this.tabAddUnit.Text = "Add Unit (ユニット)";
            this.tabAddUnit.UseVisualStyleBackColor = true;
            // 
            // tabModifyUnit
            // 
            this.tabModifyUnit.Location = new System.Drawing.Point(4, 29);
            this.tabModifyUnit.Name = "tabModifyUnit";
            this.tabModifyUnit.Size = new System.Drawing.Size(1139, 713);
            this.tabModifyUnit.TabIndex = 3;
            this.tabModifyUnit.Text = "Modify Unit (ユニット)";
            this.tabModifyUnit.UseVisualStyleBackColor = true;
            // 
            // tabAddPilot
            // 
            this.tabAddPilot.Location = new System.Drawing.Point(4, 29);
            this.tabAddPilot.Name = "tabAddPilot";
            this.tabAddPilot.Size = new System.Drawing.Size(1139, 713);
            this.tabAddPilot.TabIndex = 2;
            this.tabAddPilot.Text = "Add Pilot (パイロット)";
            this.tabAddPilot.UseVisualStyleBackColor = true;
            // 
            // tabModifyPilot
            // 
            this.tabModifyPilot.Location = new System.Drawing.Point(4, 29);
            this.tabModifyPilot.Name = "tabModifyPilot";
            this.tabModifyPilot.Size = new System.Drawing.Size(1139, 713);
            this.tabModifyPilot.TabIndex = 4;
            this.tabModifyPilot.Text = "Modify Pilot (パイロット)";
            this.tabModifyPilot.UseVisualStyleBackColor = true;
            // 
            // tabAddPart
            // 
            this.tabAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddPart.Location = new System.Drawing.Point(4, 29);
            this.tabAddPart.Name = "tabAddPart";
            this.tabAddPart.Size = new System.Drawing.Size(1139, 713);
            this.tabAddPart.TabIndex = 5;
            this.tabAddPart.Text = "Add Reinforcement Parts (強化パーツ)";
            this.tabAddPart.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.PaleGreen;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(4, 752);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(87, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmSaveEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1147, 824);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Name = "frmSaveEditor";
            this.Text = "Sega Saturn\'s Savegame Editor";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabChangeFunds.ResumeLayout(false);
            this.tabChangeFunds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numFunds)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabChangeFunds;
        private System.Windows.Forms.TabPage tabAddUnit;
        private System.Windows.Forms.TabPage tabAddPilot;
        private System.Windows.Forms.TabPage tabModifyUnit;
        private System.Windows.Forms.TabPage tabModifyPilot;
        private System.Windows.Forms.TabPage tabAddPart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.NumericUpDown numFunds;
        private System.Windows.Forms.Button btnSave;
    }
}