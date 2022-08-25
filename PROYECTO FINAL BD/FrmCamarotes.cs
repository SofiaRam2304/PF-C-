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
    public partial class FrmCamarotes : Form
    {
        public FrmCamarotes()
        {
            InitializeComponent();
        }

        ClsConexionBD connect = new ClsConexionBD();
        SqlCommand cmd;

        private void FrmCamarotes_Load(object sender, EventArgs e)
        {
            connect.abrir();
            connect.cargarDatosCamarote(dgvCamarotes);

            if (connect.Administrador == 0)
            {
                btnEliminar.Enabled = false;
                btnModificar.Enabled = false;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoBuque.Text == " " || txtCodigoCamarote.Text == " " || txtNivelCamarote.Text == " " || txtPrecioPerson.Text == " " || cmbTipoCamarote.SelectedIndex == -1)
                {
                    MessageBox.Show("No se pueden Insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Insert into Camarotes(cod_buque, tipo_camarote, nivel_camarote, precio_dia_persona) Values(" + txtCodigoBuque.Text + ", '" + cmbTipoCamarote.Text + "'," + txtNivelCamarote.Text + ", " + txtPrecioPerson.Text + ")", connect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Se han ingresado los Datos con Exito ", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connect.cargarDatosCamarote(dgvCamarotes);

                    txtCodigoBuque.Clear();
                    txtCodigoCamarote.Clear();
                    txtNivelCamarote.Clear();
                    txtPrecioPerson.Clear();
                    cmbTipoCamarote.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());

                txtCodigoBuque.Clear();
                txtCodigoCamarote.Clear();
                txtNivelCamarote.Clear();
                txtPrecioPerson.Clear();

                cmbTipoCamarote.SelectedIndex = -1;

            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dgvCamarotes.CurrentRow.Index;

            txtCodigoCamarote.Text = dgvCamarotes[0, poc].Value.ToString();
            txtCodigoBuque.Text = dgvCamarotes[1, poc].Value.ToString();
            cmbTipoCamarote.Text = dgvCamarotes[2, poc].Value.ToString();
            txtNivelCamarote.Text = dgvCamarotes[3, poc].Value.ToString();
            txtPrecioPerson.Text = dgvCamarotes[4, poc].Value.ToString();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;
            indice = dgvCamarotes.CurrentRow.Index;
            int codigo;

            try
            {
                if(txtCodigoBuque.Text == " " || txtCodigoCamarote.Text == " " || txtNivelCamarote.Text == " " || txtPrecioPerson.Text == " " || cmbTipoCamarote.SelectedIndex==-1)
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dgvCamarotes[0, indice].Value);
                    dgvCamarotes[0, indice].Value = txtCodigoCamarote.Text;
                    dgvCamarotes[1, indice].Value = txtCodigoBuque.Text;
                    dgvCamarotes[2, indice].Value = cmbTipoCamarote.Text;
                    dgvCamarotes[3, indice].Value = txtNivelCamarote.Text;
                    dgvCamarotes[4, indice].Value = txtPrecioPerson.Text;

                    cmd = new SqlCommand("Update Camarotes set  nivel_camarote= " + txtNivelCamarote.Text + ", cod_buque =  " + txtCodigoBuque.Text + " , tipo_camarote =  '" + cmbTipoCamarote.Text + "' , precio_dia_persona = " + txtPrecioPerson.Text + " where cod_camarote = " + txtCodigoCamarote.Text + "", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.cargarDatosCamarote(dgvCamarotes);
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtCodigoBuque.Clear();
                    txtCodigoCamarote.Clear();
                    txtNivelCamarote.Clear();
                    txtPrecioPerson.Clear();
                    cmbTipoCamarote.SelectedIndex = -1;

                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                txtCodigoBuque.Clear();
                txtCodigoCamarote.Clear();
                txtNivelCamarote.Clear();
                txtPrecioPerson.Clear();
                cmbTipoCamarote.SelectedIndex = -1;
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtCodigoBuque.Text == " " || txtCodigoCamarote.Text == " " || txtNivelCamarote.Text == " " || txtPrecioPerson.Text == " " || cmbTipoCamarote.SelectedIndex == -1)
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Delete from Camarotes where cod_camarote = " + txtCodigoCamarote.Text + "", connect.sc);
                    cmd.ExecuteNonQuery();
                    connect.cargarDatosCamarote(dgvCamarotes);

                    txtCodigoBuque.Clear();
                    txtCodigoCamarote.Clear();
                    txtNivelCamarote.Clear();
                    txtPrecioPerson.Clear();
                    cmbTipoCamarote.SelectedIndex = -1;

                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

                txtCodigoBuque.Clear();
                txtCodigoCamarote.Clear();
                txtNivelCamarote.Clear();
                txtPrecioPerson.Clear();
                cmbTipoCamarote.SelectedIndex = -1;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            connect.cerrar();
            menu.Show();
            this.Close();
        }

        private void txtPrecioPerson_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbTipoCamarote_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selection = cmbTipoCamarote.SelectedIndex;

            switch (selection)
            {
                case -1:
                    txtPrecioPerson.Text = " ";
                    break;

                case 0:
                    txtPrecioPerson.Text = "50.00";
                    break;
                case 1:
                    txtPrecioPerson.Text = "75.00";
                    break;
                case 2:
                    txtPrecioPerson.Text = "100.00";
                    break;
                default:
                    txtPrecioPerson.Text = "150.00";
                    break;
            }
        }

        private void FrmCamarotes_Click(object sender, EventArgs e)
        {
            txtCodigoBuque.Clear();
            txtCodigoCamarote.Clear();
            txtNivelCamarote.Clear();
            txtPrecioPerson.Clear();
            cmbTipoCamarote.SelectedIndex = -1;
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
