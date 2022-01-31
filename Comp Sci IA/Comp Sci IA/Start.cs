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
        String _fileContents = String.Empty;
        bool _previewModeOn = false;
        List<String> _recentFiles = new List<String>();

        public Start()
        {
            InitializeComponent();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
            //tabControl1.MouseMove += new MouseEventHandler(tabControl1_MouseMove);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SetControls();
            SetDefaults();
        }

        private void SetControls()
        {
            tabControl1.TabPages[0].Text = "New File";
            tabControl1.TabPages[1].Text = "Open Recent File";
            tabControl1.TabPages[2].Text = "Import Existing File";
            tabControl1.TabPages[3].Text = "Help";
        }

        private void SetDefaults()
        {
            string[] lines = System.IO.File.ReadAllLines(@"../../RecentFiles.txt");

            foreach (string line in lines)
            {
                string path = Path.GetDirectoryName(line);
                string file = Path.GetFileName(line);
                lstbxRecentFiles2.Items.Add(line);
            }
        }

        private void OpenMain()
        {
            this.Hide();
            Main mainWindow = new Main(_fileName, _folderPath, _fileContents, _previewModeOn);
            mainWindow.ShowDialog();
            this.Show();
        }

        private void btnReturnToEditor_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

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

        private void btnCreateNewFile1_Click(object sender, EventArgs e)
        {
            OpenMain();
        }

        private void rbtnPreviewModeOn1_CheckedChanged(object sender, EventArgs e)
        {
            this._previewModeOn = true;
        }

        private void rbtnPreviewModeOff1_CheckedChanged(object sender, EventArgs e)
        {
            this._previewModeOn = false;
        }

        private void chkSetPreviewDefault1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnOpenFileDialog1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolder.SelectedPath))
            {
                _folderPath = openFolder.SelectedPath;
                this.txtSaveLocation1.Text = _folderPath;
            }
        }

        private void btnReset1_Click(object sender, EventArgs e)
        {
            this.txtSaveLocation1.Text = String.Empty;
            this.txtFileName1.Text = String.Empty;
            this.rbtnPreviewModeOn1.Checked = false;
            this.rbtnPreviewModeOff1.Checked = false;
            this.chkSetPreviewDefault1.Checked = false;
        }

        private void txtFileName1_TextChanged(object sender, EventArgs e)
        {
            _fileName = txtFileName1.Text;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            this.btnOpen2.Hide();
        }

        private void tabPage2_Leave(object sender, EventArgs e)
        {
            this.btnOpen2.Hide();
            this.lstbxRecentFiles2.SelectedIndex = -1;
        }

        private void lstbxRecentFiles2_Enter(object sender, EventArgs e)
        {
            this.btnOpen2.Show();
        }

        private void btnOpen2_Click(object sender, EventArgs e)
        {
            string path = lstbxRecentFiles2.SelectedItem.ToString();
            this._fileContents = System.IO.File.ReadAllText(path);
            this._folderPath = Path.GetDirectoryName(path);
            this._fileName = Path.GetFileName(path);
            OpenMain();
        }
        
        private void btnImport3_Click(object sender, EventArgs e)
        {
            
            this._fileContents = System.IO.File.ReadAllText(@_fileName);
            OpenMain();
        }

        private void btnOpenFileDialog3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "PDF (*.pdf)|*.pdf" + "|" +
                                "TXT (*.txt)|*.txt" + "|" +
                                "RTF (*.rtf)|*.rtf" + "|" +
                                "All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _fileName = openFile.FileName;
                this.txtFileNameImport3.Text = _fileName;
            }
        }

    }
}
