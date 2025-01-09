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
        private string _filename = @"D:\Jogos\Saturn\SSF_PreviewVer_R33\Backup\InternalBackup\SROBOT_F_01.bin";
        // TODO: Set _filename properly

        public frmSaveEditor()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save save = new Save()
            {
                Funds = (int)numFunds.Value
            };
            _editor.Save(save);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = ofdFile.ShowDialog();
        }

        private void ofdFile_FileOk(object sender, CancelEventArgs e)
        {
            SetSetting("lastFile", ofdFile.FileName);

            //timFile.Enabled = true;
            OpenFile(ofdFile.FileName);
        }

        private void OpenFile(string filename)
        {
            if (File.Exists(filename))
            {
                lblStatus.Text = filename;
                btnOpenFolder.Enabled = true;
                _filename = filename;

                _editor = new Editor(filename);
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

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName(_filename));
        }
    }
}
