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
    public partial class FrmPersona : Form
    {
        public FrmPersona()
        {
            InitializeComponent();
            dataGridView1.DataSource = obtenerPersonas();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        private void refrescarPersonas()
        {
            dataGridView1.DataSource = obtenerPersonas();
            dataGridView1.Refresh();
            dataGridView1.Update();
            dataGridView1.ClearSelection();
            txtNombrePersona.Text = txtNumeroPersona.Text = txtDniPersonaa.Text = "";
        }

        private DataTable obtenerPersonas()
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "";
            MySqlCommand comando;

            sql = "SELECT * FROM persona";
            comando = new MySqlCommand(sql, miConexion);
            miConexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            DataTable dtPersonas = new DataTable();
            dtPersonas.Load(reader);

            return dtPersonas;
        }

        private void btnPersonaAgregar_Click(object sender, EventArgs e)
        {
            txtNombrePersona.Text = txtNombrePersona.Text.ToUpper();
            txtDniPersonaa.Text = txtDniPersonaa.Text.ToUpper();
            txtNumeroPersona.Text = txtNumeroPersona.Text.ToUpper();
            RegistrarPersona();
            refrescarPersonas();
        }
        private void RegistrarPersona()
        {
            try
            {
                Persona persona = new Persona();
                persona.Nombre = txtNombrePersona.Text;
                persona.Dni = txtDniPersonaa.Text;
                persona.Telefono = txtNumeroPersona.Text;
                controlPersona control = new controlPersona();
                MessageBox.Show(control.crtlRegistroPersona(persona), "Control de Personas", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void btnPersonaActualizar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (ActualizarPersona())
            {
                txtNombrePersona.Text = txtNumeroPersona.Text = txtDniPersonaa.Text = "";
            }
        }

        private bool ActualizarPersona()
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "";
            sql = "UPDATE persona set nombre = '" + txtNombrePersona.Text + "', telefono = '" + txtNumeroPersona.Text + "' where dni ='" + txtDniPersonaa.Text + "';";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            bool success = comando.ExecuteNonQuery() == 1;
            if (success)
            {
                MessageBox.Show("Se Actualizo correctamente");
                refrescarPersonas();
            }
            else
            {
                MessageBox.Show("No se Actualizó.");
            }
            miConexion.Close();
            return success;
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            txtDniPersonaa.Text = "";
            txtNombrePersona.Text = "";
            txtNumeroPersona.Text = "";
            dataGridView1.ClearSelection();
        }

        private void btnPersonaEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from persona where dni='" + txtDniPersonaa.Text + "'";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);

            modeloPersona control = new modeloPersona();

            Persona persona = new Persona();
            persona.Nombre = txtPersonaNombre.Text;
            persona.Dni = txtDniPersonaa.Text;
            persona.Telefono = txtNumeroPersona.Text;
            bool existeAutoo;
            existeAutoo = control.existeAuto(persona);
            refrescarPersonas();

            if (existeAutoo == true)
            {
                MessageBox.Show("El Dni " + persona.Dni + " tiene un Auto asignado, por favor primero eliminalo"); ;
            }
            else if
          (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
                refrescarPersonas();
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();
            refrescarPersonas();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                txtNombrePersona.Text = txtDniPersonaa.Text = txtNumeroPersona.Text = "";
            }
            else
            {
                txtNombrePersona.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtDniPersonaa.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtNumeroPersona.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            }
        }
    }
}
