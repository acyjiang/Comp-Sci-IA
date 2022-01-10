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
        public Main()
        {
            InitializeComponent();
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
