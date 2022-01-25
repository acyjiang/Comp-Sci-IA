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

    public partial class Start : Form
    {

        String _folder = String.Empty;
        String _fileName = String.Empty;
        String _file = String.Empty;
        bool _previewModeOn = false;

        public Start()
        {
            InitializeComponent();

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SetControls();
        }

        private void SetControls()
        {
            tabControl1.TabPages[0].Text = "New File";
            tabControl1.TabPages[1].Text = "Open Recent File";
            tabControl1.TabPages[2].Text = "Import Existing File";
            tabControl1.TabPages[3].Text = "Help";
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

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainWindow = new Main(_fileName, _folder, _previewModeOn);
            mainWindow.ShowDialog();
            this.Show();
        }

        private void btnImportExistingFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            ImportExistingFile importWindow = new ImportExistingFile();
            importWindow.ShowDialog();
            this.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnReturnToEditor_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void rbtnPreviewModeOn_CheckedChanged(object sender, EventArgs e)
        {
            this._previewModeOn = true;
        }

        private void rbtnPreviewModeOff_CheckedChanged(object sender, EventArgs e)
        {
            this._previewModeOn = false;
        }

        private void chkSetPreviewDefault_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog() == DialogResult.OK && !string.IsNullOrWhiteSpace(openFolder.SelectedPath))
            {
                _folder = openFolder.SelectedPath;
                this.textBox2.Text = _folder;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.textBox2.Text = String.Empty;
            this.txtFileName.Text = String.Empty;
            this.rbtnPreviewModeOn.Checked = false;
            this.rbtnPreviewModeOff.Checked = false;
            this.chkSetPreviewDefault.Checked = false;
        }

        private void txtFileName_TextChanged(object sender, EventArgs e)
        {
            _fileName = txtFileName.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainFile = new Main(_file, "", false);
            mainFile.mainText = System.IO.File.ReadAllText(@_file);
            mainFile.ShowDialog();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "PDF (*.pdf)|*.pdf" + "|" +
                                "TXT (*.txt)|*.txt" + "|" +
                                "RTF (*.rtf)|*.rtf" + "|" +
                                "All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _file = openFile.FileName;
                this.txtFileNameImport.Text = _file;
            }
        }
    }
}
