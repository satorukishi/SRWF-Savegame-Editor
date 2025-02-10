using Satoru.SRWF.Savegame.Service;
using System;
using static System.Configuration.ConfigurationManager;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing;
using Satoru.SRWF.Savegame.UI.Properties;

namespace Satoru.SRWF.Savegame.UI
{
    public partial class frmSaveEditor : Form
    {
        private Editor _editor;
        private string _filename;

        public frmSaveEditor()
        {
            InitializeComponent();
            Initialize();
        }

        private void Initialize()
        {
            this.txtMUId.GotFocus += txtMU_GotFocus;
            this.txtMUHexa.GotFocus += txtMU_GotFocus;
            this.txtMUHp.GotFocus += txtMU_GotFocus;
            this.txtMUMobility.GotFocus += txtMU_GotFocus;
            this.txtMUArmor.GotFocus += txtMU_GotFocus;
            this.txtMULimit.GotFocus += txtMU_GotFocus;
            this.txtMUNote.GotFocus += txtMU_GotFocus;
            this.numMUHp.GotFocus += txtMU_GotFocus;
            this.numMUEn.GotFocus += txtMU_GotFocus;
            this.numMUMobility.GotFocus += txtMU_GotFocus;
            this.numMUArmor.GotFocus += txtMU_GotFocus;
            this.numMULimit.GotFocus += txtMU_GotFocus;
            this.tblUnit.SetRowSpan(txtMUNote, 3);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save save = new Save()
            {
                Funds = (int)numCFFunds.Value,
                Unit = (Unit)cboMUUnit.SelectedValue
            };

            ModifyUnit(save.Unit);

            txtHexa.Text = _editor.Save(save);
        }

        private void ModifyUnit(Unit unit)
        {
            unit.StatsUpgrade.HP = (byte)numMUHp.Value;
            unit.StatsUpgrade.EN = (byte)numMUEn.Value;
            unit.StatsUpgrade.Mobility = (byte)numMUMobility.Value;
            unit.StatsUpgrade.Armor = (byte)numMUArmor.Value;
            unit.StatsUpgrade.Limit = (byte)numMULimit.Value;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // if File is selected, dr = OK and ofdFile_FileOk will be called
            DialogResult dr = ofdFile.ShowDialog();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName(_filename));
        }

        private void ofdFile_FileOk(object sender, CancelEventArgs e)
        {
            SetSetting("lastFile", ofdFile.FileName);
            OpenFile(ofdFile.FileName);
        }

        private void OpenFile(string filename)
        {
            if (File.Exists(filename))
            {
                _filename = filename;

                lblStatus.Text = filename;
                btnOpenFolder.Enabled = true;
                tabEditor.Enabled = true;

#if DEBUG
                tabEditor.SelectedTab = tabEditor.TabPages["tabModifyUnit"];
#endif

                bool isFirstTime = _editor == null;
                _editor = new Editor(filename);

                if (isFirstTime)
                {
                    cboMUUnit.DataSource = _editor.GetUnlockedUnits();
                    cboMUUnit.DisplayMember = "Name";
                }

                txtHexa.Text = _editor.GetHexaVerifier();
            }
            else
            {
                MessageBox.Show("File not found: " + filename);
            }
        }

        private static void SetSetting(string key, string value)
        {
            Configuration configuration = OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            RefreshSection("appSettings");
        }

        private void frmSaveEditor_Load(object sender, EventArgs e)
        {
            _filename = AppSettings.Get("lastFile");
            lblStatus.Text = "";
            btnOpenFolder.Enabled = false;

            OpenFile(_filename);
        }

        private void cboUnit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboMUUnit.SelectedItem != null)
            {
                var unit = (Unit)cboMUUnit.SelectedItem;
                grpMUUnit.Text = unit.Name;
                txtMUId.Text = unit.Id.ToString();
                txtMUHexa.Text = unit.Hexa;
                txtMUHp.Text = unit.HP;
                txtMUMobility.Text = unit.Mobility;
                txtMUArmor.Text = unit.Armor;
                txtMULimit.Text = unit.Limit;
                txtMUNote.Text = unit.Note;
            }
        }

        private void txtMU_GotFocus(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            picMUHp.Visible = picMUEn.Visible = picMUMobility.Visible = picMUArmor.Visible = picMULimit.Visible = false;

            switch (control.Name.Substring(5))
            {
                case "Hp":
                    picMUHp.Visible = true;
                    break;
                case "En":
                    picMUEn.Visible = true;
                    break;
                case "Mobility":
                    picMUMobility.Visible = true;
                    break;
                case "Armor":
                    picMUArmor.Visible = true;
                    break;
                case "Limit":
                    picMULimit.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private enum UnitAttribute
        {
            HP,
            EN,
            Mobility,
            Armor,
            Limit
        }

        private void numMU_ValueChanged(object sender, EventArgs e)
        {
            Control control = (Control)sender;
            Bitmap bitmap = new Bitmap(Resources.unit_sample);
            Graphics g = Graphics.FromImage(bitmap);
            Image upgrade = Resources.unit_sample_upgrade;

            int xLocation = SampleLocation.X;

            for (int i = 1; i < numMUHp.Maximum; i++)
            {
                int x = xLocation + (i - 1) * SampleLocation.UPGRADE_WIDTH;
                bool exit = true;

                if (i <= numMUHp.Value)
                {
                    g.DrawImage(upgrade, x, SampleLocation.Y_HP);
                    exit = false;
                }
                if (i <= numMUEn.Value)
                {
                    g.DrawImage(upgrade, x, SampleLocation.Y_EN);
                    exit = false;
                }
                if (i <= numMUMobility.Value)
                {
                    g.DrawImage(upgrade, x, SampleLocation.Y_MOBILITY);
                    exit = false;
                }
                if (i <= numMUArmor.Value)
                {
                    g.DrawImage(upgrade, x, SampleLocation.Y_ARMOR);
                    exit = false;
                }
                if (i <= numMULimit.Value)
                {
                    g.DrawImage(upgrade, x, SampleLocation.Y_LIMIT);
                    exit = false;
                }

                if (exit)
                {
                    break;
                }
            }

            picMU.Image = bitmap;
        }


        private class SampleLocation
        {
            public const int Y_HP = 264;
            public const int Y_EN = 296;
            public const int Y_MOBILITY = 328;
            public const int Y_ARMOR = 360;
            public const int Y_LIMIT = 392;

            public const int X = 320;
            public const int UPGRADE_WIDTH = 16;
        }
    }
}
