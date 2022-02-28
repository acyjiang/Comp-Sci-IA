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
    public partial class Export : Form
    {
        Bitmap _bmp;
        string _fileName;
        string _filePath;
        System.Drawing.Imaging.ImageFormat _fileType;

        public Export(Bitmap bmp)
        {
            _bmp = bmp;
            InitializeComponent();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_fileType == null)
            {
                MessageBox.Show("Please choose a file type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _bmp.Save(_filePath + "\\" + _fileName + "." + _fileType, _fileType);
            this.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            _fileType = System.Drawing.Imaging.ImageFormat.Jpeg;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            _fileType = System.Drawing.Imaging.ImageFormat.Png;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            _fileType = System.Drawing.Imaging.ImageFormat.Bmp;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _fileName = textBox1.Text;
        }

        private void btnOpenFileDialog2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog openFolder = new FolderBrowserDialog();

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                _filePath = openFolder.SelectedPath;
                this.txtFileNameImport2.Text = _filePath;
            }
        }
    }
}
