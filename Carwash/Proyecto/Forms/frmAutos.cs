using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;

namespace Proyecto
{
    public partial class frmSocios : Form
    {
        public frmSocios()
        {
            InitializeComponent();
        }

        private void frmSocios_Load(object sender, EventArgs e)
        {
            CargarCarros();
        }

        private void CargarCarros()
        {
            dataGridView1.DataSource = new BindingSource { DataSource = obtenerAutos() };
            cargarDni();
            txtPatente.Text = txtMarca.Text = txtModelo.Text = txtAno.Text = "";
            comboDni.Text = "";
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ClearSelection();
        }

        private DataTable obtenerAutos()
        {
            MySqlConnection miConexion = Conexion.getConexion();
            MySqlCommand comando;

            string sql = "SELECT * FROM auto";
            miConexion.Open();
            comando = new MySqlCommand(sql, miConexion);

            MySqlDataReader reader = comando.ExecuteReader();
            DataTable dtAutos = new DataTable();
            dtAutos.Load(reader);
            miConexion.Close();

            return dtAutos;
        }

        private void cargarDni()
        {
            comboDni.DataSource = null;
            comboDni.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from persona";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                comboDni.ValueMember = "dni";
                comboDni.DisplayMember = "dni";
                comboDni.DataSource = dt;
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

        private bool RegistrarAuto()
        {
            try
            {
                Autos socio = new Autos();
                socio.Patente = txtPatente.Text;
                socio.Marca = txtMarca.Text;
                socio.Modelo = txtModelo.Text;
                socio.Año = txtAno.Text;
                socio.Dni = comboDni.Text;
                controlAutos control = new controlAutos();
                MessageBox.Show(control.crtlRegistroSocios(socio), "Control de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            return true;
        }

        private void ActualizarAuto()
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "";
            sql = "UPDATE auto set marca = '" + txtMarca.Text + "', modelo = '" + txtModelo.Text + "', año = '" + txtAno.Text + "', dni = '" + comboDni.Text + "' where patente ='" + txtPatente.Text + "';";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se Actualizo correctamente");
                CargarCarros();
            }
            else
            {
                MessageBox.Show("No se Actualizó.");
            }
            miConexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from auto where patente='" + txtPatente.Text + "'";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
                CargarCarros();
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            txtPatente.Text = txtPatente.Text.ToUpper();
            txtMarca.Text = txtMarca.Text.ToUpper();
            txtModelo.Text = txtModelo.Text.ToUpper();
            txtAno.Text = txtAno.Text.ToUpper();
            comboDni.Text = comboDni.Text.ToUpper();
            if (RegistrarAuto())
            {
                txtPatente.Text = txtMarca.Text = txtModelo.Text = txtAno.Text = "";
                comboDni.SelectedIndex = -1;
                CargarCarros();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            ActualizarAuto();
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            Autos socio = new Autos();
            socio.Patente = txtPatente.Text;
            socio.Marca = txtMarca.Text;
            socio.Modelo = txtModelo.Text;
            socio.Año = txtAno.Text;
            socio.Dni = comboDni.Text;
            modeloAutos control = new modeloAutos();
            bool existeturnoo = control.existeTurno(socio);

            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from auto where patente='" + txtPatente.Text + "'";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);

            // refrescarAutos();
            if (existeturnoo == true)
            {
                MessageBox.Show("La patente " + socio.Patente + " tiene un turno asignado, por favor primero eliminalo"); ;
            }
            else if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();
            CargarCarros();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            txtPatente.Text = "";
            txtMarca.Text = "";
            txtModelo.Text = "";
            txtAno.Text = "";
            comboDni.Text = "";
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                txtPatente.Text = txtMarca.Text = txtModelo.Text = txtAno.Text = "";
                comboDni.SelectedIndex = -1;
            }
            else
            {
                int rowIndex = dataGridView1.CurrentRow.Index;
                txtPatente.Text = Convert.ToString(dataGridView1[0, rowIndex].Value);
                txtMarca.Text = Convert.ToString(dataGridView1[1, rowIndex].Value);
                txtModelo.Text = Convert.ToString(dataGridView1[2, rowIndex].Value);
                txtAno.Text = Convert.ToString(dataGridView1[3, rowIndex].Value);
                comboDni.Text = Convert.ToString(dataGridView1[4, rowIndex].Value);
            }
        }
    }
}