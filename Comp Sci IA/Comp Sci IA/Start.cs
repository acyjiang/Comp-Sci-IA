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
        public Start()
        {
            InitializeComponent();
        }

        private void btnCreateNewFile_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main mainWindow = new Main();
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
    }
}
