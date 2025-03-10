﻿using System;

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
            this.tabEditor = new System.Windows.Forms.TabControl();
            this.tabChangeFunds = new System.Windows.Forms.TabPage();
            this.numCFFunds = new System.Windows.Forms.NumericUpDown();
            this.lblFunds = new System.Windows.Forms.Label();
            this.tabAddUnit = new System.Windows.Forms.TabPage();
            this.tabModifyUnit = new System.Windows.Forms.TabPage();
            this.grpMUUnitStats = new System.Windows.Forms.GroupBox();
            this.tblUnitStats = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picMUEn = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.picMUHp = new System.Windows.Forms.PictureBox();
            this.picMULimit = new System.Windows.Forms.PictureBox();
            this.picMUMobility = new System.Windows.Forms.PictureBox();
            this.picMUArmor = new System.Windows.Forms.PictureBox();
            this.picMU = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.numMUHp = new System.Windows.Forms.NumericUpDown();
            this.numMUEn = new System.Windows.Forms.NumericUpDown();
            this.numMUMobility = new System.Windows.Forms.NumericUpDown();
            this.numMUArmor = new System.Windows.Forms.NumericUpDown();
            this.numMULimit = new System.Windows.Forms.NumericUpDown();
            this.grpMUUnit = new System.Windows.Forms.GroupBox();
            this.tblUnit = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMUId = new System.Windows.Forms.TextBox();
            this.txtMUMobility = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMUNote = new System.Windows.Forms.TextBox();
            this.txtMUHexa = new System.Windows.Forms.TextBox();
            this.txtMUArmor = new System.Windows.Forms.TextBox();
            this.txtMULimit = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMUHp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
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
            this.statusBottom.SuspendLayout();
            this.tabEditor.SuspendLayout();
            this.tabChangeFunds.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCFFunds)).BeginInit();
            this.tabModifyUnit.SuspendLayout();
            this.grpMUUnitStats.SuspendLayout();
            this.tblUnitStats.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMUEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMULimit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUMobility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUHp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUEn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUMobility)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUArmor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMULimit)).BeginInit();
            this.grpMUUnit.SuspendLayout();
            this.tblUnit.SuspendLayout();
            this.mnuTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusBottom
            // 
            this.statusBottom.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.statusBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.statusBottom.Location = new System.Drawing.Point(0, 802);
            this.statusBottom.Name = "statusBottom";
            this.statusBottom.Size = new System.Drawing.Size(1043, 22);
            this.statusBottom.TabIndex = 9;
            this.statusBottom.Text = "statusStrip1";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(52, 17);
            this.lblStatus.Text = "lblStatus";
            // 
            // tabEditor
            // 
            this.tabEditor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabEditor.Controls.Add(this.tabChangeFunds);
            this.tabEditor.Controls.Add(this.tabAddUnit);
            this.tabEditor.Controls.Add(this.tabModifyUnit);
            this.tabEditor.Controls.Add(this.tabAddPilot);
            this.tabEditor.Controls.Add(this.tabModifyPilot);
            this.tabEditor.Controls.Add(this.tabAddPart);
            this.tabEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabEditor.Location = new System.Drawing.Point(0, 27);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Padding = new System.Drawing.Point(0, 0);
            this.tabEditor.SelectedIndex = 0;
            this.tabEditor.Size = new System.Drawing.Size(1043, 719);
            this.tabEditor.TabIndex = 10;
            // 
            // tabChangeFunds
            // 
            this.tabChangeFunds.Controls.Add(this.numCFFunds);
            this.tabChangeFunds.Controls.Add(this.lblFunds);
            this.tabChangeFunds.Location = new System.Drawing.Point(4, 29);
            this.tabChangeFunds.Name = "tabChangeFunds";
            this.tabChangeFunds.Padding = new System.Windows.Forms.Padding(3);
            this.tabChangeFunds.Size = new System.Drawing.Size(1035, 686);
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
            this.tabAddUnit.Size = new System.Drawing.Size(1035, 686);
            this.tabAddUnit.TabIndex = 1;
            this.tabAddUnit.Text = "Add Unit (ユニット)";
            this.tabAddUnit.UseVisualStyleBackColor = true;
            // 
            // tabModifyUnit
            // 
            this.tabModifyUnit.Controls.Add(this.grpMUUnitStats);
            this.tabModifyUnit.Controls.Add(this.grpMUUnit);
            this.tabModifyUnit.Controls.Add(this.label1);
            this.tabModifyUnit.Controls.Add(this.cboMUUnit);
            this.tabModifyUnit.Location = new System.Drawing.Point(4, 29);
            this.tabModifyUnit.Name = "tabModifyUnit";
            this.tabModifyUnit.Size = new System.Drawing.Size(1035, 686);
            this.tabModifyUnit.TabIndex = 3;
            this.tabModifyUnit.Text = "Modify Unit (ユニット)";
            this.tabModifyUnit.UseVisualStyleBackColor = true;
            // 
            // grpMUUnitStats
            // 
            this.grpMUUnitStats.Controls.Add(this.tblUnitStats);
            this.grpMUUnitStats.Location = new System.Drawing.Point(8, 179);
            this.grpMUUnitStats.Name = "grpMUUnitStats";
            this.grpMUUnitStats.Size = new System.Drawing.Size(275, 398);
            this.grpMUUnitStats.TabIndex = 5;
            this.grpMUUnitStats.TabStop = false;
            this.grpMUUnitStats.Text = "Unit Stats Upgrade";
            // 
            // tblUnitStats
            // 
            this.tblUnitStats.ColumnCount = 2;
            this.tblUnitStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tblUnitStats.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblUnitStats.Controls.Add(this.panel1, 0, 5);
            this.tblUnitStats.Controls.Add(this.label10, 0, 0);
            this.tblUnitStats.Controls.Add(this.label11, 0, 2);
            this.tblUnitStats.Controls.Add(this.label12, 0, 3);
            this.tblUnitStats.Controls.Add(this.label13, 0, 4);
            this.tblUnitStats.Controls.Add(this.label14, 0, 1);
            this.tblUnitStats.Controls.Add(this.numMUHp, 1, 0);
            this.tblUnitStats.Controls.Add(this.numMUEn, 1, 1);
            this.tblUnitStats.Controls.Add(this.numMUMobility, 1, 2);
            this.tblUnitStats.Controls.Add(this.numMUArmor, 1, 3);
            this.tblUnitStats.Controls.Add(this.numMULimit, 1, 4);
            this.tblUnitStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblUnitStats.Location = new System.Drawing.Point(3, 22);
            this.tblUnitStats.Name = "tblUnitStats";
            this.tblUnitStats.RowCount = 6;
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnitStats.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblUnitStats.Size = new System.Drawing.Size(269, 373);
            this.tblUnitStats.TabIndex = 0;
            // 
            // panel1
            // 
            this.tblUnitStats.SetColumnSpan(this.panel1, 2);
            this.panel1.Controls.Add(this.picMUEn);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.picMUHp);
            this.panel1.Controls.Add(this.picMULimit);
            this.panel1.Controls.Add(this.picMUMobility);
            this.panel1.Controls.Add(this.picMUArmor);
            this.panel1.Controls.Add(this.picMU);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 207);
            this.panel1.TabIndex = 17;
            // 
            // picMUEn
            // 
            this.picMUEn.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample_en;
            this.picMUEn.Location = new System.Drawing.Point(16, 117);
            this.picMUEn.Name = "picMUEn";
            this.picMUEn.Size = new System.Drawing.Size(65, 13);
            this.picMUEn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMUEn.TabIndex = 26;
            this.picMUEn.TabStop = false;
            this.picMUEn.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(111, 185);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 17);
            this.label9.TabIndex = 21;
            this.label9.Text = "Sample";
            // 
            // picMUHp
            // 
            this.picMUHp.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample_hp;
            this.picMUHp.Location = new System.Drawing.Point(16, 104);
            this.picMUHp.Name = "picMUHp";
            this.picMUHp.Size = new System.Drawing.Size(65, 13);
            this.picMUHp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMUHp.TabIndex = 22;
            this.picMUHp.TabStop = false;
            this.picMUHp.Visible = false;
            // 
            // picMULimit
            // 
            this.picMULimit.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample_limit;
            this.picMULimit.Location = new System.Drawing.Point(16, 156);
            this.picMULimit.Name = "picMULimit";
            this.picMULimit.Size = new System.Drawing.Size(65, 13);
            this.picMULimit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMULimit.TabIndex = 25;
            this.picMULimit.TabStop = false;
            this.picMULimit.Visible = false;
            // 
            // picMUMobility
            // 
            this.picMUMobility.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample_mobility;
            this.picMUMobility.Location = new System.Drawing.Point(16, 130);
            this.picMUMobility.Name = "picMUMobility";
            this.picMUMobility.Size = new System.Drawing.Size(65, 13);
            this.picMUMobility.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMUMobility.TabIndex = 23;
            this.picMUMobility.TabStop = false;
            this.picMUMobility.Visible = false;
            // 
            // picMUArmor
            // 
            this.picMUArmor.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample_armor;
            this.picMUArmor.Location = new System.Drawing.Point(16, 143);
            this.picMUArmor.Name = "picMUArmor";
            this.picMUArmor.Size = new System.Drawing.Size(65, 13);
            this.picMUArmor.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMUArmor.TabIndex = 24;
            this.picMUArmor.TabStop = false;
            this.picMUArmor.Visible = false;
            // 
            // picMU
            // 
            this.picMU.AccessibleName = "Modify Unit - Sample Picture";
            this.picMU.ErrorImage = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.Image = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.InitialImage = global::Satoru.SRWF.Savegame.UI.Properties.Resources.unit_sample;
            this.picMU.Location = new System.Drawing.Point(3, 0);
            this.picMU.Name = "picMU";
            this.picMU.Size = new System.Drawing.Size(260, 182);
            this.picMU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picMU.TabIndex = 8;
            this.picMU.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 20);
            this.label10.TabIndex = 10;
            this.label10.Text = "HP:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 64);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(127, 20);
            this.label11.TabIndex = 11;
            this.label11.Text = "Mobility (運動性):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Armor (装甲):";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 128);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(92, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "Limit (限界):";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 32);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 20);
            this.label14.TabIndex = 10;
            this.label14.Text = "EN:";
            // 
            // numMUHp
            // 
            this.numMUHp.Location = new System.Drawing.Point(136, 3);
            this.numMUHp.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMUHp.Name = "numMUHp";
            this.numMUHp.Size = new System.Drawing.Size(127, 26);
            this.numMUHp.TabIndex = 16;
            this.numMUHp.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // numMUEn
            // 
            this.numMUEn.Location = new System.Drawing.Point(136, 35);
            this.numMUEn.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMUEn.Name = "numMUEn";
            this.numMUEn.Size = new System.Drawing.Size(127, 26);
            this.numMUEn.TabIndex = 16;
            this.numMUEn.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // numMUMobility
            // 
            this.numMUMobility.Location = new System.Drawing.Point(136, 67);
            this.numMUMobility.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMUMobility.Name = "numMUMobility";
            this.numMUMobility.Size = new System.Drawing.Size(127, 26);
            this.numMUMobility.TabIndex = 16;
            this.numMUMobility.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // numMUArmor
            // 
            this.numMUArmor.Location = new System.Drawing.Point(136, 99);
            this.numMUArmor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMUArmor.Name = "numMUArmor";
            this.numMUArmor.Size = new System.Drawing.Size(127, 26);
            this.numMUArmor.TabIndex = 16;
            this.numMUArmor.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // numMULimit
            // 
            this.numMULimit.Location = new System.Drawing.Point(136, 131);
            this.numMULimit.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numMULimit.Name = "numMULimit";
            this.numMULimit.Size = new System.Drawing.Size(127, 26);
            this.numMULimit.TabIndex = 16;
            this.numMULimit.ValueChanged += new System.EventHandler(this.numMU_ValueChanged);
            // 
            // grpMUUnit
            // 
            this.grpMUUnit.Controls.Add(this.tblUnit);
            this.grpMUUnit.Location = new System.Drawing.Point(8, 43);
            this.grpMUUnit.Name = "grpMUUnit";
            this.grpMUUnit.Size = new System.Drawing.Size(742, 130);
            this.grpMUUnit.TabIndex = 4;
            this.grpMUUnit.TabStop = false;
            this.grpMUUnit.Text = "Unit (Readonly)";
            // 
            // tblUnit
            // 
            this.tblUnit.ColumnCount = 6;
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 109F));
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.tblUnit.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.34F));
            this.tblUnit.Controls.Add(this.label2, 0, 0);
            this.tblUnit.Controls.Add(this.label6, 0, 1);
            this.tblUnit.Controls.Add(this.txtMUId, 1, 0);
            this.tblUnit.Controls.Add(this.txtMUMobility, 1, 1);
            this.tblUnit.Controls.Add(this.label3, 2, 0);
            this.tblUnit.Controls.Add(this.label5, 2, 1);
            this.tblUnit.Controls.Add(this.txtMUNote, 1, 2);
            this.tblUnit.Controls.Add(this.txtMUHexa, 3, 0);
            this.tblUnit.Controls.Add(this.txtMUArmor, 3, 1);
            this.tblUnit.Controls.Add(this.txtMULimit, 5, 1);
            this.tblUnit.Controls.Add(this.label7, 4, 0);
            this.tblUnit.Controls.Add(this.txtMUHp, 5, 0);
            this.tblUnit.Controls.Add(this.label4, 4, 1);
            this.tblUnit.Controls.Add(this.label8, 0, 2);
            this.tblUnit.Location = new System.Drawing.Point(3, 25);
            this.tblUnit.Name = "tblUnit";
            this.tblUnit.RowCount = 3;
            this.tblUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnit.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tblUnit.Size = new System.Drawing.Size(733, 97);
            this.tblUnit.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Mobility (運動性):";
            // 
            // txtMUId
            // 
            this.txtMUId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMUId.Location = new System.Drawing.Point(136, 3);
            this.txtMUId.Name = "txtMUId";
            this.txtMUId.ReadOnly = true;
            this.txtMUId.Size = new System.Drawing.Size(124, 26);
            this.txtMUId.TabIndex = 11;
            // 
            // txtMUMobility
            // 
            this.txtMUMobility.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMUMobility.Location = new System.Drawing.Point(136, 35);
            this.txtMUMobility.Name = "txtMUMobility";
            this.txtMUMobility.ReadOnly = true;
            this.txtMUMobility.Size = new System.Drawing.Size(124, 26);
            this.txtMUMobility.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(266, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Hexa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(266, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Armor (装甲):";
            // 
            // txtMUNote
            // 
            this.tblUnit.SetColumnSpan(this.txtMUNote, 3);
            this.txtMUNote.Location = new System.Drawing.Point(136, 67);
            this.txtMUNote.Name = "txtMUNote";
            this.txtMUNote.ReadOnly = true;
            this.txtMUNote.Size = new System.Drawing.Size(363, 26);
            this.txtMUNote.TabIndex = 20;
            // 
            // txtMUHexa
            // 
            this.txtMUHexa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMUHexa.Location = new System.Drawing.Point(375, 3);
            this.txtMUHexa.Name = "txtMUHexa";
            this.txtMUHexa.ReadOnly = true;
            this.txtMUHexa.Size = new System.Drawing.Size(124, 26);
            this.txtMUHexa.TabIndex = 12;
            // 
            // txtMUArmor
            // 
            this.txtMUArmor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMUArmor.Location = new System.Drawing.Point(375, 35);
            this.txtMUArmor.Name = "txtMUArmor";
            this.txtMUArmor.ReadOnly = true;
            this.txtMUArmor.Size = new System.Drawing.Size(124, 26);
            this.txtMUArmor.TabIndex = 17;
            // 
            // txtMULimit
            // 
            this.txtMULimit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMULimit.Location = new System.Drawing.Point(604, 35);
            this.txtMULimit.Name = "txtMULimit";
            this.txtMULimit.ReadOnly = true;
            this.txtMULimit.Size = new System.Drawing.Size(126, 26);
            this.txtMULimit.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(505, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "HP:";
            // 
            // txtMUHp
            // 
            this.txtMUHp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtMUHp.Location = new System.Drawing.Point(604, 3);
            this.txtMUHp.Name = "txtMUHp";
            this.txtMUHp.ReadOnly = true;
            this.txtMUHp.Size = new System.Drawing.Size(126, 26);
            this.txtMUHp.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Limit (限界):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 20);
            this.label8.TabIndex = 19;
            this.label8.Text = "Note:";
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
            this.tabAddPilot.Size = new System.Drawing.Size(1035, 686);
            this.tabAddPilot.TabIndex = 2;
            this.tabAddPilot.Text = "Add Pilot (パイロット)";
            this.tabAddPilot.UseVisualStyleBackColor = true;
            // 
            // tabModifyPilot
            // 
            this.tabModifyPilot.Location = new System.Drawing.Point(4, 29);
            this.tabModifyPilot.Name = "tabModifyPilot";
            this.tabModifyPilot.Size = new System.Drawing.Size(1035, 686);
            this.tabModifyPilot.TabIndex = 4;
            this.tabModifyPilot.Text = "Modify Pilot (パイロット)";
            this.tabModifyPilot.UseVisualStyleBackColor = true;
            // 
            // tabAddPart
            // 
            this.tabAddPart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabAddPart.Location = new System.Drawing.Point(4, 29);
            this.tabAddPart.Name = "tabAddPart";
            this.tabAddPart.Size = new System.Drawing.Size(1035, 686);
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
            this.mnuTop.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.mnuTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.mnuTop.Location = new System.Drawing.Point(0, 0);
            this.mnuTop.Name = "mnuTop";
            this.mnuTop.Size = new System.Drawing.Size(1043, 24);
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
            this.ClientSize = new System.Drawing.Size(1043, 824);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.txtHexa);
            this.Controls.Add(this.btnOpenFolder);
            this.Controls.Add(this.mnuTop);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabEditor);
            this.Controls.Add(this.statusBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSaveEditor";
            this.Text = "Sega Saturn\'s Savegame Editor";
            this.Load += new System.EventHandler(this.frmSaveEditor_Load);
            this.statusBottom.ResumeLayout(false);
            this.statusBottom.PerformLayout();
            this.tabEditor.ResumeLayout(false);
            this.tabChangeFunds.ResumeLayout(false);
            this.tabChangeFunds.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCFFunds)).EndInit();
            this.tabModifyUnit.ResumeLayout(false);
            this.tabModifyUnit.PerformLayout();
            this.grpMUUnitStats.ResumeLayout(false);
            this.tblUnitStats.ResumeLayout(false);
            this.tblUnitStats.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picMUEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMULimit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUMobility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMUArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUHp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUEn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUMobility)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMUArmor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMULimit)).EndInit();
            this.grpMUUnit.ResumeLayout(false);
            this.tblUnit.ResumeLayout(false);
            this.tblUnit.PerformLayout();
            this.mnuTop.ResumeLayout(false);
            this.mnuTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusBottom;
        private System.Windows.Forms.TabControl tabEditor;
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
        private System.Windows.Forms.GroupBox grpMUUnit;
        private System.Windows.Forms.GroupBox grpMUUnitStats;
        private System.Windows.Forms.TableLayoutPanel tblUnitStats;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numMUHp;
        private System.Windows.Forms.NumericUpDown numMUEn;
        private System.Windows.Forms.NumericUpDown numMUMobility;
        private System.Windows.Forms.NumericUpDown numMUArmor;
        private System.Windows.Forms.NumericUpDown numMULimit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picMU;
        private System.Windows.Forms.PictureBox picMUEn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox picMUHp;
        private System.Windows.Forms.PictureBox picMULimit;
        private System.Windows.Forms.PictureBox picMUMobility;
        private System.Windows.Forms.PictureBox picMUArmor;
        private System.Windows.Forms.TableLayoutPanel tblUnit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMUId;
        private System.Windows.Forms.TextBox txtMUMobility;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMUNote;
        private System.Windows.Forms.TextBox txtMUHexa;
        private System.Windows.Forms.TextBox txtMUArmor;
        private System.Windows.Forms.TextBox txtMULimit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMUHp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
    }
}