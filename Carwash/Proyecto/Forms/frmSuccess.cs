using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto.Forms
{
    public partial class frmSuccess : Form
    {
        public frmSuccess()
        {
            InitializeComponent();
        }

        private void frmSuccess_Load(object sender, EventArgs e)
        {
            esclarecerForm.ShowAsyc(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtCerrar2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCancelarAviso_Click(object sender, EventArgs e)
        {
            frmSuccess farrrm = new frmSuccess();
            farrrm.Close();
        }
    }
}
