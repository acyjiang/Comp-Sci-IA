using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Comp_Sci_IA
{

    public partial class Main : Form
    {

        public String _mainText;
        public bool _wantedToReturn;
        public String _fileName;
        public String _folder;
        public bool _previewModeOn;

        public Main(String _fileName, String _folder, String _mainText, bool _previewModeOn)
        {
            InitializeComponent();
            this._mainText = _mainText;
            this._fileName = _fileName;
            this._folder = _folder;
            this._previewModeOn = _previewModeOn;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.txtMain.Text = _mainText;
            this.lblFileName.Text = this._fileName;
        }

        private void btnReturnToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start startForm = new Start();
            startForm.ShowDialog();
            this.Show();
        }

        
    }
}
