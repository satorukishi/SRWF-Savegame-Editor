using Satoru.SRWF.Savegame.Service;
using System;
using static System.Configuration.ConfigurationManager;
using System.ComponentModel;
using System.Configuration;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace Satoru.SRWF.Savegame.UI
{
    public partial class frmSaveEditor : Form
    {
        private Editor _editor;
        private string _filename;

        public frmSaveEditor()
        {
            InitializeComponent();

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save save = new Save()
            {
                Funds = (int)numCFFunds.Value,
                Unit = (Unit)cboMUUnit.SelectedValue
            };
            txtHexa.Text = _editor.Save(save);
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
                lblStatus.Text = filename;
                btnOpenFolder.Enabled = true;
                _filename = filename;

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
                txtMUHP.Text = unit.HP;
                txtMUMobility.Text = unit.Mobility;
                txtMUArmor.Text = unit.Armor;
                txtMULimit.Text = unit.Limit;
                txtMUNote.Text = unit.Note;
            }
        }
    }
}
