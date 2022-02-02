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
        public const int WINDOWWIDTH = 816;
        public const int WINDOWHEIGHT = 489;

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
            this.lblFileName.Location = new Point(WINDOWWIDTH / 2 - lblFileName.Size.Width / 2, lblFileName.Location.Y);

            if (_previewModeOn)
            {
                toggleOnPreviewMode();
            } else
            {
                toggleOffPreviewMode();
            }
        }
        
        private void toggleOnPreviewMode()
        {
            this.txtPreview.Show();
            this.txtMain.Width = txtPreview.Width;
            this.btnPreviewMode.Text = "Preview Mode On";
            this.btnPreviewMode.Font = new Font("Microsoft Sans Serif", 9);
            this._previewModeOn = true;
        }

        private void toggleOffPreviewMode()
        {
            this.txtPreview.Hide();
            this.txtMain.Width = txtPreview.Location.X + txtPreview.Size.Width - txtMain.Location.X;
            this.btnPreviewMode.Text = "Preview Mode Off";
            this.btnPreviewMode.Font = new Font("Microsoft Sans Serif", 8);
            this._previewModeOn = false;
        }

        private void btnReturnToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            Start startForm = new Start();
            startForm.ShowDialog();
            this.Show();
        }

        private void btnPreviewMode_Click(object sender, EventArgs e)
        {
            if (_previewModeOn)
            {
                toggleOffPreviewMode();
            } 
            else
            {
                toggleOnPreviewMode();
            }
        }

        private void txtMain_TextChanged(object sender, EventArgs e)
        {
            txtPreview.Text = txtMain.Text;
        }
    }
}
