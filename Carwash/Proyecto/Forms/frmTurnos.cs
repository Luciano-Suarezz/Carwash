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
    public partial class frmTurnos : Form
    {
        public frmTurnos()
        {
            InitializeComponent();
            btnEliminarAuto.Cursor = Cursors.Hand;
        }

        private void refrescarTurnos()
        {
            dataGridView1.DataSource = obtenerTurnos();
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.Refresh();
            dataGridView1.Update();
            comboPatente.Text = "";
            txtTipoLavado.Text = "";
            txtHora.Text = "";
            txtEstimado.Text = "";
            txtMonto.Text = "";
            txtDescripcion.Text = "";
            dataGridView1.ClearSelection();
        }
        private void frmTurnos_Load(object sender, EventArgs e)
        {
            refrescarTurnos();
            cargarPatente();
            comboPatente.Text = "";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                dateTimePicker1.Value = DateTime.Today;
                comboPatente.Text = txtTipoLavado.Text = txtHora.Text = txtEstimado.Text = txtMonto.Text =
                txtDescripcion.Text = "";
            }
            else
            {
                dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                comboPatente.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                txtTipoLavado.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtHora.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtEstimado.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtMonto.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            }
        }

        private DataTable obtenerTurnos()
        {
            MySqlConnection miConexion = Conexion.getConexion();
            MySqlCommand comando;

            string sql = "SELECT * FROM turnos";
            comando = new MySqlCommand(sql, miConexion);
            miConexion.Open();
            MySqlDataReader reader = comando.ExecuteReader();
            DataTable dtTurnos = new DataTable();
            dtTurnos.Load(reader);

            return dtTurnos;
        }

        private bool RegistrarTurno()
        {
            try
            {
                Turnos turno = new Turnos();
                turno.Fecha = dateTimePicker1.Value;
                turno.Patente = comboPatente.Text;
                turno.Hora = txtHora.Text;
                turno.Estimado = txtEstimado.Text;
                turno.Tipolavado = txtTipoLavado.Text;
                turno.Monto = txtMonto.Text;
                turno.Descripcion = txtDescripcion.Text;
                controlTurnos control = new controlTurnos();
                string message = control.ctrlRegistroTurnos(turno);
                MessageBox.Show(message, "Control de Socios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return message == "Auto registrado con éxito";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from turnos where patente='" + comboPatente.Text + "'";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
                dataGridView1.DataSource = obtenerTurnos();
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();
        }

        private bool ActualizarTurno()
        {

            MySqlConnection miConexion = Conexion.getConexion();
            string oldFecha = Convert.ToDateTime(dataGridView1.CurrentRow.Cells[0].Value).ToString("yyyy-MM-dd");
            string sql = "UPDATE turnos set fecha = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") +"', hora = '" + txtHora.Text + "' , tiempoEstimado = '" + txtEstimado.Text +
                "' , tipoLavado = '" + txtTipoLavado.Text + "' , descripcion = '" + txtDescripcion.Text + "' , monto = '" + txtMonto.Text + "' where patente = '" + comboPatente.Text + "' and fecha = '" + oldFecha + "' ;";
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            miConexion.Open();
            bool success = comando.ExecuteNonQuery() == 1;
            if (success)
            {
                MessageBox.Show("Se Actualizo correctamente");
                refrescarTurnos();
            }
            else
            {
                MessageBox.Show("No se Actualizó.");
            }
            miConexion.Close();
            return success;
        }

        private void cargarPatente()
        {
            comboPatente.DataSource = null;
            comboPatente.Items.Clear();
            MySqlConnection con = Conexion.getConexion();
            con.Open();
            try
            {
                string consulta = "Select * from auto";
                MySqlCommand comando = new MySqlCommand(consulta, con);
                MySqlDataAdapter mysqldt = new MySqlDataAdapter(comando);
                DataTable dt = new DataTable();
                mysqldt.Fill(dt);
                comboPatente.ValueMember = "patente";
                comboPatente.DisplayMember = "patente";
                comboPatente.DataSource = dt;
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

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from turnos where patente='" + comboPatente.Text + "'";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
                dataGridView1.DataSource = obtenerTurnos();
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();
        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {
            if (RegistrarTurno())
            {
                refrescarTurnos();
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (ActualizarTurno())
            {
                refrescarTurnos();
            }
        }

        private void btnEliminarAuto_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0) return;
            MySqlConnection miConexion = Conexion.getConexion();
            string sql = "delete from turnos where patente ='" + comboPatente.Text + "' and fecha = '" + dateTimePicker1.Value.ToString("yyyy-MM-dd") + "';";
            miConexion.Open();
            MySqlCommand comando = new MySqlCommand(sql, miConexion);
            if (comando.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Se elimino correctamente");
                refrescarTurnos();
            }
            else
            {
                MessageBox.Show("No se eliminó.");
            }
            miConexion.Close();
        }

        private void bunifuFlatButton3_Click(object sender, EventArgs e)
        {
            comboPatente.Text = "";
            txtTipoLavado.Text = "";
            txtHora.Text = "";
            txtEstimado.Text = "";
            txtMonto.Text = "";
            txtDescripcion.Text = "";
            dataGridView1.ClearSelection();
        }
    }
}
