using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }

        private void cargarUsuarios()
        {
            comboTipos.DataSource = null;
            comboTipos.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from tipoUsuarios";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                comboTipos.ValueMember = "idTipo";
                comboTipos.DisplayMember = "Nombre";
                comboTipos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnRegistrarr_Click(object sender, EventArgs e)
        {
            try
            {
                Usuarios user = new Usuarios();
                user.Usuario = txtNombreUsuario.Text;
                user.Password = txtClaveR.Text;
                user.PasswordConfirma = txtConfirmaClave.Text;
                user.Nombre = txtNombreApellido.Text;
                user.IdTipo = int.Parse(comboTipos.SelectedValue.ToString());
                controlUsuarios control = new controlUsuarios();
                MessageBox.Show(control.ctrlRegistroUsuarios(user), "Control de usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombreUsuario.Text = txtClaveR.Text = txtConfirmaClave.Text = txtNombreApellido.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnUsuariosCancelar_Click(object sender, EventArgs e)
        {
            txtNombreApellido.Text = "";
            txtNombreUsuario.Text = "";
            comboTipos.Text = "";
            txtClaveR.Text = "a";
            txtConfirmaClave.Text = "a";
        }

        private void txtClaveR_OnValueChanged(object sender, EventArgs e)
        {
            txtClaveR.isPassword = true;
        }

        private void txtConfirmaClave_OnValueChanged(object sender, EventArgs e)
        {
            txtConfirmaClave.isPassword = true;
        }
    }
}
