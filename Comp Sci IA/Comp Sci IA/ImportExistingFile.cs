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
    public partial class ImportExistingFile : Form 
    {

        String _file = String.Empty;

        public ImportExistingFile()
        {
            InitializeComponent();
        }

        private void ImportExistingFile_Load_1(object sender, EventArgs e)
        {
            this.CenterToScreen();
            SetControls();
        }

        private void SetControls()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = true;
            this.MinimizeBox = true;

            this.lblImportFile.Text = "Import File";
            this.btnImport.Text = "Import";
            this.lblAcceptableTypes.Text = "Acceptable File Types: pdf, txt, rtf";
            this.btnOpenFileDialog.Text = "...";
            this.btnClose.Text = "Close";

            this.txtFileName.Text = String.Empty;
            this.txtFileName.Enabled = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOpenFileDialog_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();

            openFile.Filter = "PDF (*.pdf)|*.pdf" + "|" +
                                "TXT (*.txt)|*.txt" + "|" +
                                "RTF (*.rtf)|*.rtf" + "|" +
                                "All Files (*.*)|*.*";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                _file = openFile.FileName;
                this.txtFileName.Text = _file;
            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainFile = new Main(_file, "", "", false);
            mainFile._mainText = System.IO.File.ReadAllText(@_file);
            mainFile.ShowDialog();
            this.Dispose();
        }

    }
}
