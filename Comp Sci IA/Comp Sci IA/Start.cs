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

            tabControl1.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void Start_Load(object sender, EventArgs e)
        {
            SetControls();
        }

        private void SetControls()
        {
            tabControl1.TabPages[0].Text = "New File";
            tabControl1.TabPages[1].Text = "Open Recent File";
            tabControl1.TabPages[2].Text = "Import Existing File";
        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl1.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl1.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {

                // Draw a different background color, and don't paint a focus rectangle.
                _textBrush = new SolidBrush(Color.Red);
                g.FillRectangle(Brushes.PeachPuff, e.Bounds);
            }
            else
            {
                _textBrush = new SolidBrush(e.ForeColor);
                e.DrawBackground();
            }

            // Use our own font.
            Font _tabFont = new Font("Microsoft Sans Serif", 12.0f, FontStyle.Regular, GraphicsUnit.Pixel);

            // Draw string. Center the text.
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
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

        private void btnReturnToEditor_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
