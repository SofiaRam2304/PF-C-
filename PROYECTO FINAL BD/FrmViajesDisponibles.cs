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

namespace PROYECTO_FINAL_BD
{
    public partial class FrmViajesDisponibles : Form
    {
        public FrmViajesDisponibles()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;
        ClsSuperclase inicio = new ClsSuperclase();
        int poc;

        private void FrmViajesDisponibles_Load(object sender, EventArgs e)
        {

            if(inicio.Administrador == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }

            conect.abrir();
            conect.cargarDatosViajes(dgvViajesDisponibles);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            conect.cerrar();
            menu.Show();
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDuracion.Text == " " || txtFechaSalida.Text == " " || txtFechaDestino.Text == " " || txtCodigoBunque.Text == " " || txtCodigoDestino.Text == " ")
                {
                    MessageBox.Show("No se pueden insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("insert into Viajes (duracion, fecha_salida, fecha_destino, cod_buque, cod_destino) values ('" + txtDuracion.Text + "', '" + txtFechaSalida.Text + "','" + txtFechaDestino.Text + "'," + txtCodigoBunque.Text + "," + txtCodigoDestino.Text + ")", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosViajes(dgvViajesDisponibles);
                    MessageBox.Show("Se han insertado los datos correctamente", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigoBunque.Clear();
                    txtCodigoDestino.Clear();
                    txtDuracion.Clear();
                    txtFechaDestino.Clear();
                    txtFechaSalida.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigoBunque.Clear();
                txtCodigoDestino.Clear();
                txtDuracion.Clear();
                txtFechaDestino.Clear();
                txtFechaSalida.Clear();

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            poc = dgvViajesDisponibles.CurrentRow.Index;

            //int codigo;
            txtCodigo.Text = dgvViajesDisponibles[0, poc].Value.ToString();
            txtDuracion.Text = dgvViajesDisponibles[1, poc].Value.ToString();
            txtFechaSalida.Text = dgvViajesDisponibles[2, poc].Value.ToString();
            txtFechaDestino.Text = dgvViajesDisponibles[3, poc].Value.ToString();
            txtCodigoDestino.Text = dgvViajesDisponibles[4, poc].Value.ToString();
            txtCodigoBunque.Text = dgvViajesDisponibles[5, poc].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            int codigo;
            indice = dgvViajesDisponibles.CurrentRow.Index;

            try
            {
                if(txtCodigo.Text == " ")
                {
                    MessageBox.Show("Muestre los datos a Modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dgvViajesDisponibles[0, indice].Value);

                    dgvViajesDisponibles[0, indice].Value = txtCodigo.Text;
                    dgvViajesDisponibles[1, indice].Value = txtDuracion.Text;
                    dgvViajesDisponibles[2, indice].Value = txtFechaSalida.Text;
                    dgvViajesDisponibles[3, indice].Value = txtFechaDestino.Text;
                    dgvViajesDisponibles[4, indice].Value = txtCodigoBunque.Text;
                    dgvViajesDisponibles[5, indice].Value = txtCodigoDestino.Text;

                    cmd = new SqlCommand("Update Viajes Set duracion = '" + txtDuracion.Text + "',fecha_salida = '" + txtFechaSalida.Text + "',fecha_destino = '" + txtFechaDestino.Text + "', cod_buque = " + txtCodigoBunque.Text + ", cod_destino =" + txtCodigoDestino.Text + " Where cod_viaje = " + codigo, conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizo exitosamente");
                    conect.cargarDatosViajes(dgvViajesDisponibles);

                    txtCodigo.Clear();
                    txtCodigoBunque.Clear();
                    txtCodigoDestino.Clear();
                    txtDuracion.Clear();
                    txtFechaDestino.Clear();
                    txtFechaSalida.Clear();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado"+ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodigo.Text == " ")
                {
                    MessageBox.Show("Muestre los Datos a Eliminar","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Viajes WHERE cod_viaje =" + txtCodigo.Text + "", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosViajes(dgvViajesDisponibles);

                    txtCodigo.Clear();
                    txtCodigoBunque.Clear();
                    txtCodigoDestino.Clear();
                    txtDuracion.Clear();
                    txtFechaDestino.Clear();
                    txtFechaSalida.Clear();
                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pueden eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCodigo.Clear();
                txtCodigoBunque.Clear();
                txtCodigoDestino.Clear();
                txtDuracion.Clear();
                txtFechaDestino.Clear();
                txtFechaSalida.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmViajesDisponibles_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCodigoBunque.Clear();
            txtCodigoDestino.Clear();
            txtDuracion.Clear();
            txtFechaDestino.Clear();
            txtFechaSalida.Clear();
        }
    }
}
