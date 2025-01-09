using System;
using System.ComponentModel;
using static System.Configuration.ConfigurationManager;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Configuration;
using Satoru.SRWF.Savegame.Service;

namespace Satoru.SRWF.Savegame.UI
{
    public partial class frmCalculaHexa : Form
    {
        private string _filename;
        private Editor _editor;

        public frmCalculaHexa()
        {
            InitializeComponent();
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

        private static void SetSetting(string key, string value)
        {
            Configuration configuration = OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save(ConfigurationSaveMode.Full, true);
            RefreshSection("appSettings");
        }

        private void OpenFile(string filename)
        {
            if (File.Exists(filename))
            {
                ShowFileName(filename);
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

        private void ShowFileName(string filename)
        {
            var dir = filename.Split('\\');
            lblFileName.Text = dir[0] + '\\' + dir[1] + (dir.Length - 1 > 2 ? "\\..." : string.Empty) + '\\' + dir[dir.Length - 1];

        }

        private void frmCalculaHexa_Load(object sender, EventArgs e)
        {
            _filename = AppSettings.Get("lastFile");

            lblFileName.Text = "";
            btnOpenFolder.Enabled = false;
            
            //timFile.Enabled = true;
            OpenFile(_filename);
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            Process.Start("explorer.exe", Path.GetDirectoryName(_filename));
        }

        private void timFile_Tick(object sender, EventArgs e)
        {
            OpenFile(_filename);
        }

        private void btnCheckHexaSum_Click(object sender, EventArgs e)
        {
            OpenFile(_filename);
        }
    }
}
