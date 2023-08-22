using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Forms;

namespace Proyecto
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal(string Dato)
        {
            string DatodeForm1 = Dato;
            InitializeComponent();
            txtBienvenidaUsuario.Text = ("Bienvenido, " + DatodeForm1);
        }

        private void socioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            frmSocios ferm = new frmSocios();

            ferm.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            btnSalir_Click(sender, e);

        }
        private void bntSalir_Click(object sender, EventArgs e)
        {
            DialogResult resp = MessageBox.Show("Está a punto de cerrar su sesión, ¿confirma ? ", "Socios CLUB", MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question);

        }
        private void btnSalir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnSalir_Click(sender, e);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            btnSalir_Click(sender, e);
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios frm = new frmUsuarios();

            frm.Show();
        }
        private void btnSocios_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmTurnos frm = new frmTurnos();
            frm.Show();
        }
        private void imgSalir_Click(object sender, EventArgs e)
        {
            frmSuccess furm = new frmSuccess();
            furm.BringToFront();
            furm.Show();
        }
        private void imgSalir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                btnSalir_Click(sender, e);
        }

        private void wrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtVersion_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnDashboardTurnos_Click(object sender, EventArgs e)
        {

            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            abrirFormulario(new frmTurnos());
        }
        public void seleccionarBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            btnDashboardSocios.Textcolor = Color.White;
            btnDashboardTurnos.Textcolor = Color.White;
            btnDashboardUsuarios.Textcolor = Color.White;
            btnDashboardPersona.Textcolor = Color.White;
            sender.selected = true;
            if (sender.selected)
            {
                sender.Textcolor = Color.FromArgb(0, 135, 175);
                dashboard.Text = ("Menú de "+sender.Text);
            }
        }

        private void btnDashboardSocios_Click(object sender, EventArgs e)
        {
            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            abrirFormulario(new frmSocios());
        }

        private void btnDashboardUsuarios_Click(object sender, EventArgs e)
        {

            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            abrirFormulario(new frmUsuarios());
        }
        private void seguirBoton(Bunifu.Framework.UI.BunifuFlatButton sender)
        {
            flecha.Top = sender.Top;
        }

        private Form formActivado = null;

        private void abrirFormulario(Form formHijo)
        {
            if (formActivado != null)
                formActivado.Close();
            formActivado = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            wrapper.Controls.Add(formHijo);
            wrapper.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }

        private void sideBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public static string declararUsuario(string usuarioo)
        {
            string usuarioxd = usuarioo;
            return usuarioxd;
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

            seleccionarBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            seguirBoton((Bunifu.Framework.UI.BunifuFlatButton)sender);
            abrirFormulario(new FrmPersona());
        }

        private void txtElegi_Click(object sender, EventArgs e)
        {

        }
    }

}
