using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _20240918_Database_FrameWork
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void studentiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudenti formStudenti = new FrmStudenti();
            formStudenti.MdiParent = this;
            formStudenti.Show();
        }
        private void corsiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCorsi formCorsi = new FrmCorsi();
            formCorsi.MdiParent = this;
            formCorsi.Show();
        }
    }
}
