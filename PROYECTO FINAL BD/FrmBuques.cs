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
    public partial class FrmBuques : Form
    {
        public FrmBuques()
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

        private void FrmBuques_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosBuques(dgvBuques);

            if (conect.Administrador == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtNiveles.Text == " " || txtNombre.Text == " " ||cmbTipoBuque.SelectedIndex == -1 || txtCamarotes.Text == " ")
                {
                    MessageBox.Show("No se pueden Insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Buques (nombre_buque,num_camarotes,num_niveles,tipo_buque) VALUES ('" + txtNombre.Text + "'," + txtCamarotes.Text + "," + txtNiveles.Text + ",'" + cmbTipoBuque.Text + "')", conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los Datos han sifo insertados con Exitos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosBuques(dgvBuques);
                    txtCamarotes.Clear();
                    txtNiveles.Clear();
                    txtNombre.Clear();
                    cmbTipoBuque.SelectedIndex = -1;         
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCamarotes.Clear();
                txtNiveles.Clear();
                txtNombre.Clear();
                cmbTipoBuque.SelectedIndex = -1;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dgvBuques.CurrentRow.Index;

            txtCodigo.Text = dgvBuques[0, poc].Value.ToString();
            txtNombre.Text = dgvBuques[1, poc].Value.ToString();
            txtCamarotes.Text = dgvBuques[2, poc].Value.ToString();
            txtNiveles.Text = dgvBuques[3, poc].Value.ToString();
            cmbTipoBuque.Text = dgvBuques[4, poc].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dgvBuques.CurrentRow.Index;
            int codigo;

            try
            {
                if (txtNiveles.Text == " " || txtNombre.Text == " " || cmbTipoBuque.SelectedIndex == -1 || txtCamarotes.Text == " ")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dgvBuques[0, indice].Value);
                    dgvBuques[0, indice].Value = txtCodigo.Text;
                    dgvBuques[1, indice].Value = txtNombre.Text;
                    dgvBuques[2, indice].Value = txtCamarotes.Text;
                    dgvBuques[3, indice].Value = txtNiveles.Text;
                    dgvBuques[4, indice].Value = cmbTipoBuque.Text;

                    cmd = new SqlCommand("UPDATE Buques SET nombre_buque = '" + txtNombre.Text + "',num_camarotes= " + txtCamarotes.Text + ", num_niveles = " + txtNiveles.Text + ", tipo_buque = '" + cmbTipoBuque.Text + "' WHERE cod_buque = " + codigo, conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosBuques(dgvBuques);

                    txtCodigo.Clear();
                    txtCamarotes.Clear();
                    txtNiveles.Clear();
                    txtNombre.Clear();
                    cmbTipoBuque.SelectedIndex = -1;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCodigo.Clear();
                txtCamarotes.Clear();
                txtNiveles.Clear();
                txtNombre.Clear();
                cmbTipoBuque.SelectedIndex = -1;

            }
        }

        private void FrmBuques_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtCamarotes.Clear();
            txtNiveles.Clear();
            txtNombre.Clear();
            cmbTipoBuque.SelectedIndex = -1;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNiveles.Text == " " || txtNombre.Text == " " || cmbTipoBuque.SelectedIndex == -1 || txtCamarotes.Text == " ")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("DELETE FROM Buques WHERE cod_buque = " + txtCodigo.Text + "", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosBuques(dgvBuques);

                    txtCodigo.Clear();
                    txtCamarotes.Clear();
                    txtNiveles.Clear();
                    txtNombre.Clear();
                    cmbTipoBuque.SelectedIndex = -1;
                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtCamarotes.Clear();
                txtNiveles.Clear();
                txtNombre.Clear();
                cmbTipoBuque.SelectedIndex = -1;
            }
        }
    }
}
