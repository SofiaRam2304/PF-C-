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
    public partial class FrmLugares : Form
    {
        public FrmLugares()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            conect.cerrar();
            menu.Show();
            this.Close();
        }

        private void FrmLugares_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosDestinos(dgvDestinos);

            if (conect.Administrador == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodBuque.Text == " " || txtubi.Text == " " || cmbdestino.SelectedIndex == -1)
                {
                    MessageBox.Show("No se pueden insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Destinos (nombre_destino, ubicacion, cod_buque) VALUES ('" + cmbdestino.Text + "','" + txtubi.Text + "'," + txtCodBuque.Text + ")", conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los datos han sido insertados con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosDestinos(dgvDestinos);

                    cmbdestino.SelectedIndex = -1;
                    txtubi.Clear();
                    txtCodigo.Clear();
                    txtCodBuque.Clear();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Los datos no pudieron ser ingresados" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbdestino.SelectedItem = false;
                txtubi.Clear();
                txtCodigo.Clear();
                txtCodBuque.Clear();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dgvDestinos.CurrentRow.Index;

            txtCodigo.Text = dgvDestinos[0, poc].Value.ToString();
            cmbdestino.Text = dgvDestinos[1, poc].Value.ToString();
            txtubi.Text = dgvDestinos[2, poc].Value.ToString();
            txtCodBuque.Text = dgvDestinos[3, poc].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dgvDestinos.CurrentRow.Index;
            int codigo;

            try
            {
                if (txtCodBuque.Text == " " || txtubi.Text == " " || cmbdestino.SelectedIndex == -1)
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dgvDestinos[0, indice].Value);
                    dgvDestinos[0, indice].Value = txtCodigo.Text;
                    dgvDestinos[1, indice].Value = cmbdestino.Text;
                    dgvDestinos[2, indice].Value = txtubi.Text;
                    dgvDestinos[3, indice].Value = txtCodBuque.Text;

                    cmd = new SqlCommand("UPDATE Destinos SET nombre_destino = '" + cmbdestino.Text + "', ubicacion = '" + txtubi.Text + "',cod_buque = " + txtCodBuque.Text + " WHERE cod_destino = " + codigo, conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosDestinos(dgvDestinos);
                    //(nombre_destino, ubicacion, cod_buque)

                    cmbdestino.SelectedIndex = -1;
                    txtubi.Clear();
                    txtCodigo.Clear();
                    txtCodBuque.Clear();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbdestino.SelectedIndex = -1;
                txtubi.Clear();
                txtCodigo.Clear();
                txtCodBuque.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtCodBuque.Text == " " || txtubi.Text == " " || cmbdestino.SelectedIndex == -1)
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Destinos WHERE cod_destino = " + txtCodigo.Text + "", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosDestinos(dgvDestinos);

                    cmbdestino.SelectedIndex = -1;
                    txtubi.Clear();
                    txtCodigo.Clear();
                    txtCodBuque.Clear();

                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                cmbdestino.SelectedIndex = -1;
                txtubi.Clear();
                txtCodigo.Clear();
                txtCodBuque.Clear();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void cmbdestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = cmbdestino.SelectedIndex;
        }

        private void FrmLugares_Click(object sender, EventArgs e)
        {
            cmbdestino.SelectedIndex = -1;
            txtubi.Clear();
            txtCodigo.Clear();
            txtCodBuque.Clear();
        }
    }
}
