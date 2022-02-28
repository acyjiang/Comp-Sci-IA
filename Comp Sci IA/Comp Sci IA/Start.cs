using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Comp_Sci_IA
{

    public partial class Start : Form
    {
        String _fileName = String.Empty;
        String _folderPath = String.Empty;
        Image _image = null;
        bool _previewModeOn = false;
        List<String> _recentFiles = new List<String>();

        public Start()
        {
            InitializeComponent();
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SetControls();
        }

        private void SetControls()
        {
            // Sets recent files
            SetRecentFiles();

            // Draws tab control
            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            tabControl1.TabPages[0].Text = "Open Recent File";
            tabControl1.TabPages[1].Text = "Import File";
            tabControl1.TabPages[2].Text = "Help";

            btnOpen1.Hide();
        }

        private void SetRecentFiles()
        {
            lstbxRecentFiles1.Items.Clear();

            _recentFiles = System.IO.File.ReadAllLines(@"../../RecentFiles.txt").ToList();

            foreach (string line in _recentFiles)
            {
                string path = Path.GetDirectoryName(line);
                string file = Path.GetFileName(line);
                lstbxRecentFiles1.Items.Add(line);
            }
        }

        //-------------GOING TO MAIN FORM-------------

        private void OpenMain()
        {
            // Hide this window
            this.Hide();

            // Add the file to recent files
            string s = Path.Combine(_folderPath, _fileName);

            if (_recentFiles.Contains(s))
            {
                _recentFiles.Remove(s);
            }

            _recentFiles.Insert(0, s);

            File.WriteAllText(@"../../RecentFiles.txt", string.Empty);

            StreamWriter sw = new StreamWriter(@"../../RecentFiles.txt");
            foreach (string line in _recentFiles)
            {
                sw.WriteLine(line);
            }
            sw.Close();

            SetRecentFiles();

            // Open the main window
            Main mainWindow = new Main(_fileName, _folderPath, new Bitmap(_image), _previewModeOn);
            mainWindow.ShowDialog();

            // Show once the main window goes away
            this.Show();

        }


        //-------------SIDE TAB FORMATTING-------------

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);
            Font _tabFont;

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Black);
                g.FillRectangle(Brushes.PeachPuff, e.Bounds);
                _tabFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
                _tabFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);
            }

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        //-------------RECENT FILES TAB (1)-------------

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            this.btnOpen1.Hide();
        }

        private void tabPage1_Leave(object sender, EventArgs e)
        {
            this.btnOpen1.Hide();
            this.lstbxRecentFiles1.SelectedIndex = -1;
        }

        private void lstbxRecentFiles1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstbxRecentFiles1.SelectedIndex == -1)
            {
                this.btnOpen1.Hide();
            }
            else
            {
                this.btnOpen1.Show();
            }
        }

        private void btnOpen1_Click(object sender, EventArgs e)
        {
            if (lstbxRecentFiles1.SelectedIndex == -1)
            {
                return;
            }

            string path = lstbxRecentFiles1.SelectedItem.ToString();
            
            this._image = Image.FromFile(path);
            this._folderPath = Path.GetDirectoryName(path);
            this._fileName = Path.GetFileName(path);

            this.btnOpen1.Hide();
            this.lstbxRecentFiles1.SelectedIndex = -1;

            OpenMain();

            
        }

        //-------------IMPORT FILE TAB (2)-------------

        private void btnImport2_Click(object sender, EventArgs e)
        {

            this._image = Image.FromFile(_fileName);
            OpenMain();
        }

        private void btnOpenFileDialog2_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "All Files (*.*)|*.*" + "|" +
                                "JPEG (*.jpeg)|*.jpeg" + "|" +
                                "PNG (*.png)|*.png" + "|" +
                                "BMP (*.bmp)|*.bmp";
                                

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFile.FileName;
                this.txtFileNameImport2.Text = _fileName;
            }
        }


        //-------------EXIT-------------

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
