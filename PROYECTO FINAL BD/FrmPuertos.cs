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
    public partial class FrmPuertos : Form
    {
        public FrmPuertos()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        ClsSuperclase inicio = new ClsSuperclase();
        SqlCommand cmd;

        private void FrmPuertos_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosPuertos(dgvPuertosSalida);

            if (inicio.Administrador == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Insert into Puertos(nombre_puerto, pais_ubicacion, cod_buque, cod_destino, cod_viaje ) Values('" + cmbNombrePuerto.Text + "','" + txtPais.Text + "', " + txtCodBuque.Text + ", " + txtCodDestino.Text + ", " + txtCodViaje.Text + ")", conect.sc);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Se han ingresado los Datos con Exito ", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conect.cargarDatosPuertos(dgvPuertosSalida);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

            }
            txtCodBuque.Clear();
            txtCodDestino.Clear();
            txtCodPuerto.Clear();
            txtCodViaje.Clear();
            txtPais.Clear();
            cmbNombrePuerto.Text = " ";
            txtCodPuerto.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new SqlCommand("Update Puertos set  nombre_puerto= '" + cmbNombrePuerto.Text + "', pais_ubicacion =  '" + txtPais.Text + "' , cod_buque =  " + txtCodBuque.Text + " , cod_destino = " + txtCodDestino.Text + ", cod_viaje = " + txtCodViaje.Text + " where cod_puerto = " + txtCodPuerto.Text + "", conect.sc);
                cmd.ExecuteNonQuery();
                conect.cargarDatosPuertos(dgvPuertosSalida);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        int poc;

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dgvPuertosSalida.CurrentRow.Index;

            txtCodPuerto.Text = dgvPuertosSalida[0,poc].Value.ToString();
            cmbNombrePuerto.Text= dgvPuertosSalida[1,poc].Value.ToString();
            txtPais.Text = dgvPuertosSalida[2,poc].Value.ToString();
            txtCodBuque.Text = dgvPuertosSalida[3,poc].Value.ToString();
            txtCodDestino.Text = dgvPuertosSalida[4,poc].Value.ToString();
            txtCodViaje.Text = dgvPuertosSalida[5,poc].Value.ToString();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodPuerto.Text == " ")
                {
                    MessageBox.Show("Muestre los datos a Eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Puertos WHERE cod_puerto = " + txtCodPuerto.Text + "", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosPuertos(dgvPuertosSalida);

                    txtCodBuque.Clear();
                    txtCodDestino.Clear();
                    txtCodPuerto.Clear();
                    txtCodViaje.Clear();
                    txtPais.Clear();
                    cmbNombrePuerto.Text = " ";
                    txtCodPuerto.Focus();

                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            conect.cerrar();
            menu.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmPuertos_Click(object sender, EventArgs e)
        {
            txtCodBuque.Clear();
            txtCodDestino.Clear();
            txtCodPuerto.Clear();
            txtCodViaje.Clear();
            txtPais.Clear();
            cmbNombrePuerto.Text = " ";
            txtCodPuerto.Focus();
        }
    }
}
