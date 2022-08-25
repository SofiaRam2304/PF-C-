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
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;

        

        private void FrmClientes_Load(object sender, EventArgs e)
        {
            //conect.sc.Open();
            conect.abrir();
            conect.cargarDatosClientes(dgvClientes);

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
                if (txtNombre.Text == "  " || txtPrimer_Apellido.Text == "  " || txtSegundoApellido.Text == "  " || txtTelefono.Text == "  " || txtCelular.Text == "  " || txtCorreo.Text == "  " || txtRtn.Text == "  " || txtEdad.Text == "  ")
                {
                    MessageBox.Show("No se pueden Insertar datos en blanco", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("Insert Into Clientes (nombre_cliente, primer_apellido_clie, segundo_apellido_clie, telefono, celular, correo_electronico, rtn_cliente, edad_cliente) values ('" + txtNombre.Text + "','" + txtPrimer_Apellido.Text + "','" + txtSegundoApellido.Text + "'," + txtTelefono.Text + "," + txtCelular.Text + ",'" + txtCorreo.Text + "'," + txtRtn.Text + "," + txtEdad.Text + ")", conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Los Datos han sifo insertados con Exitos", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosClientes(dgvClientes);
                   
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtPrimer_Apellido.Clear();
                    txtSegundoApellido.Clear();
                    txtTelefono.Clear();
                    txtCelular.Clear();
                    txtCorreo.Clear();
                    txtRtn.Clear();
                    txtEdad.Clear();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrimer_Apellido.Clear();
                txtSegundoApellido.Clear();
                txtTelefono.Clear();
                txtCelular.Clear();
                txtCorreo.Clear();
                txtRtn.Clear();
                txtEdad.Clear();
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            int indice;

            indice = dgvClientes.CurrentRow.Index;

            int codigo;

            try
            {
                if (txtCodigo.Text == " "||txtNombre.Text == "  " || txtPrimer_Apellido.Text == "  " || txtSegundoApellido.Text == "  " || txtTelefono.Text == "  " || txtCelular.Text == "  " || txtCorreo.Text == "  " || txtRtn.Text == "  " || txtEdad.Text == "  ")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    codigo = Convert.ToInt32(dgvClientes[0, indice].Value);
                    dgvClientes[0, indice].Value = txtCodigo.Text;
                    dgvClientes[1, indice].Value = txtNombre.Text;
                    dgvClientes[2, indice].Value = txtPrimer_Apellido.Text;
                    dgvClientes[3, indice].Value = txtSegundoApellido.Text;
                    dgvClientes[4, indice].Value = txtTelefono.Text;
                    dgvClientes[5, indice].Value = txtCelular.Text;
                    dgvClientes[6, indice].Value = txtCorreo.Text;
                    dgvClientes[7, indice].Value = txtRtn.Text;
                    dgvClientes[8, indice].Value = txtEdad.Text;

                    cmd = new SqlCommand("Update Clientes Set nombre_cliente = '" + txtNombre.Text + "', primer_apellido_clie = '" + txtPrimer_Apellido.Text + "', segundo_apellido_clie = '" + txtSegundoApellido.Text + "', telefono=" + txtTelefono.Text + ",celular=" + txtCelular.Text + ",correo_electronico='" + txtCorreo.Text + "',rtn_cliente=" + txtRtn.Text + ",edad_cliente=" + txtEdad.Text + "Where cod_cliente = " + codigo, conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("El registro fue actualizado", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosClientes(dgvClientes);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("El registro no pudo ser actualizado"+ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //btnAgregar.Visible = true;
                //btnModificar.Visible = false;
                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrimer_Apellido.Clear();
                txtSegundoApellido.Clear();
                txtTelefono.Clear();
                txtCelular.Clear();
                txtCorreo.Clear();
                txtRtn.Clear();
                txtEdad.Clear();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
               if(txtCodigo.Text == " " || txtNombre.Text == "  " || txtPrimer_Apellido.Text == "  " || txtSegundoApellido.Text == "  " || txtTelefono.Text == "  " || txtCelular.Text == "  " || txtCorreo.Text == "  " || txtRtn.Text == "  " || txtEdad.Text == "  ")
                {
                    MessageBox.Show("Muestre los datos a modificar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
               else
                {
                    cmd = new SqlCommand("DELETE FROM Clientes Where cod_cliente =" + txtCodigo.Text + "", conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosClientes(dgvClientes);

                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtPrimer_Apellido.Clear();
                    txtSegundoApellido.Clear();
                    txtTelefono.Clear();
                    txtCelular.Clear();
                    txtCorreo.Clear();
                    txtRtn.Clear();
                    txtEdad.Clear();

                    MessageBox.Show("Se han eliminado los datos con Exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);

                txtCodigo.Clear();
                txtNombre.Clear();
                txtPrimer_Apellido.Clear();
                txtSegundoApellido.Clear();
                txtTelefono.Clear();
                txtCelular.Clear();
                txtCorreo.Clear();
                txtRtn.Clear();
                txtEdad.Clear();
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            conect.cerrar();
            menu.Show();
            this.Close();
        }

        private void dgvClientes_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int poc;

            poc = dgvClientes.CurrentRow.Index;

            txtCodigo.Text = dgvClientes[0, poc].Value.ToString();
            txtNombre.Text = dgvClientes[1, poc].Value.ToString();
            txtPrimer_Apellido.Text = dgvClientes[2, poc].Value.ToString();
            txtSegundoApellido.Text = dgvClientes[3, poc].Value.ToString();
            txtTelefono.Text = dgvClientes[4, poc].Value.ToString();
            txtCelular.Text = dgvClientes[5, poc].Value.ToString();
            txtCorreo.Text = dgvClientes[6, poc].Value.ToString();
            txtRtn.Text = dgvClientes[7, poc].Value.ToString();
            txtEdad.Text = dgvClientes[8, poc].Value.ToString();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void FrmClientes_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrimer_Apellido.Clear();
            txtSegundoApellido.Clear();
            txtTelefono.Clear();
            txtCelular.Clear();
            txtCorreo.Clear();
            txtRtn.Clear();
            txtEdad.Clear();
        }
    }
}
