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
        public bool _wantedToReturn;
        public String _fileName;
        public String _folder;
        public bool _previewModeOn;
        public int WINDOWWIDTH = 2200;
        public int WINDOWHEIGHT = 1400;
        Editor _ed;
        public bool _zoomMode = false;

        public Main(String _fileName, String _folder, Bitmap _image, bool _previewModeOn)
        {
            this._fileName = _fileName;
            this._folder = _folder;
            this._previewModeOn = _previewModeOn;

            _ed = new Editor(_image, 400, 400, WINDOWWIDTH / 4, WINDOWHEIGHT / 4);

            InitializeComponent();
            pictureBox1.Controls.Add(pictureBox2);
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

            this.lblFileName.Text = this._fileName;
            this.lblFileName.Location = new Point(WINDOWWIDTH / 4 - lblFileName.Size.Width / 2, lblFileName.Location.Y);

            this.checkBox1.Checked = false;
            _zoomMode = false;
            trackBarLeft.Hide();
            trackBarRight.Hide();
            trackBarUpper.Hide();
            trackBarLower.Hide();
            btnCrop.Enabled = false;
            pictureBox2.Hide();

            //Set image
            setImage();

            //Set zoom
            setZoom();

            // Set track bars
            setTrackbars();
        }

        private void setImage()
        {
            pictureBox1.Location = new Point(_ed.leftBound(), _ed.upperBound());
            pictureBox1.Size = new System.Drawing.Size(_ed.getWidth(), _ed.getHeight());
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = _ed.getImage();
        }

        private void setZoom()
        {
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Size = new Size(_ed.getWidth(), _ed.getHeight());
            pictureBox2.BackColor = Color.Transparent;
        }
        
        private void setTrackbars()
        {
            trackBarUpper.Location = new Point(_ed.leftBound() - 13, _ed.upperBound() - trackBarUpper.Size.Height);
            trackBarUpper.Size = new Size(_ed.getWidth() + 26, 90);
            trackBarUpper.SetRange(0, _ed.getWidth());
            trackBarUpper.Value = 0;

            trackBarLower.Location = new Point(_ed.leftBound() - 13, _ed.lowerBound() + 25);
            trackBarLower.Size = new Size(_ed.getWidth() + 26, 90);
            trackBarLower.SetRange(0, _ed.getWidth());
            trackBarLower.Value = _ed.getWidth();

            trackBarLeft.Location = new Point(_ed.leftBound() - trackBarLeft.Width, _ed.upperBound() - 13);
            trackBarLeft.Size = new Size(90, _ed.getHeight() + 26);
            trackBarLeft.SetRange(0, _ed.getHeight());
            trackBarLeft.Value = _ed.getHeight();

            trackBarRight.Location = new Point(_ed.rightBound(), _ed.upperBound() - 13);
            trackBarRight.Size = new Size(90, _ed.getHeight() + 26);
            trackBarRight.SetRange(0, _ed.getHeight());
            trackBarRight.Value = 0;
        }

        private void btnReturnToStart_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void trackBarUpper_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarUpper.Value > trackBarLower.Value)
            {
                trackBarUpper.Value = trackBarLower.Value - 1;
            }
            refreshZoom();
        }

        private void trackBarLower_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarUpper.Value > trackBarLower.Value)
            {
                trackBarLower.Value = trackBarUpper.Value + 1;
            }
            refreshZoom();
        }

        private void trackBarLeft_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarRight.Value > trackBarLeft.Value)
            {
                trackBarLeft.Value = trackBarRight.Value - 1;
            }
            refreshZoom();
        }

        private void trackBarRight_ValueChanged(object sender, EventArgs e)
        {
            if (trackBarRight.Value > trackBarLeft.Value)
            {
                trackBarRight.Value = trackBarLeft.Value + 1;
            }
            refreshZoom();
        }

        private void refreshZoom()
        {
            pictureBox2.Location = new Point(trackBarUpper.Value, _ed.getHeight() - trackBarLeft.Value);
            pictureBox2.Size = new Size(trackBarLower.Value - trackBarUpper.Value, trackBarLeft.Value - trackBarRight.Value);
            pictureBox2.Refresh();
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);

            // Create rectangle.
            Rectangle rect1 = new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(blackPen, rect1);

            Pen whitePen = new Pen(Color.White, 1);

            // Create rectangle.
            Rectangle rect2 = new Rectangle(1, 1, pictureBox2.Width-4, pictureBox2.Height-4);

            // Draw rectangle to screen.
            e.Graphics.DrawRectangle(whitePen, rect2);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            Export export = new Export(_ed.getImage());
            export.ShowDialog();
        }

        private void btnCrop_Click(object sender, EventArgs e)
        {
            Rectangle a = new Rectangle((int)(_ed.getScale() * trackBarUpper.Value), (int)(_ed.getScale() * (_ed.getHeight() - trackBarLeft.Value)),
               (int)(_ed.getScale() * ( trackBarLower.Value - trackBarUpper.Value) ), (int)(_ed.getScale() * (trackBarLeft.Value - trackBarRight.Value)) );
            Console.WriteLine(" " + a.X + " " + a.Y + " " + a.Width+ " " + a.Height);

            Bitmap _oImage = _ed.getImage().Clone(a, _ed.getImage().PixelFormat);
            _ed.setImage(_oImage);

            //Set image
            setImage();

            //Set zoom
            setZoom();

            // Set track bars
            setTrackbars();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) {
                _zoomMode = true;
                trackBarLeft.Show();
                trackBarRight.Show();
                trackBarUpper.Show();
                trackBarLower.Show();
                btnCrop.Enabled = true;
                pictureBox2.Show();
            } else
            {
                _zoomMode = false;
                trackBarLeft.Hide();
                trackBarRight.Hide();
                trackBarUpper.Hide();
                trackBarLower.Hide();
                btnCrop.Enabled = false;
                pictureBox2.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _ed.undoHistory();

            setImage();
            setZoom();
            setTrackbars();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _ed.redoHistory();

            setImage();
            setZoom();
            setTrackbars();
        }
    }
}
