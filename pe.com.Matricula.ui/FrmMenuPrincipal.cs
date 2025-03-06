using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pe.com.Matricula.ui
{
    public partial class FrmMenuPrincipal: Form
    {
        public FrmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void mATRICULAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCrearMatricula frm = new FrmCrearMatricula();
            frm.Show();

            this.Hide();
        }

        private void FrmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
