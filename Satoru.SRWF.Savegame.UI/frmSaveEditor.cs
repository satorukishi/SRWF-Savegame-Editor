using Satoru.SRWF.Savegame.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Satoru.SRWF.Savegame.UI
{
    public partial class frmSaveEditor : Form
    {
        private Editor _editor;
        private string _fileName;

        public frmSaveEditor()
        {
            InitializeComponent();
            _editor = new Editor(_fileName);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _editor.Funds = (int)numFunds.Value;
            
            _editor.Save();
        }
    }
}
