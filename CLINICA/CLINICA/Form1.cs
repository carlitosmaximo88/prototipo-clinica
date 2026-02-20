using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using CapaEntidad;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CLINICA
{
    public partial class Form1 : Form
    {
        public Form1() => InitializeComponent();

        private void pACIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPacientes fp = new frmPacientes();
            fp.MdiParent = this;
            fp.Show();
        }
    }
}
