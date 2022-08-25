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
    public partial class frmFacturaccion : Form
    {
        public frmFacturaccion()
        {
            InitializeComponent();
        }

        ClsConexionBD conect = new ClsConexionBD();
        SqlCommand cmd;
        int seleccion1 = 0;
        int seleccion2 = 0;
        int seleccion3 = 0;
        bool calculo = false;
        int poc1;
        int poc2;
        int poc3;
        int indice = -1;

        private void frmFacturaccion_Load(object sender, EventArgs e)
        {
            conect.abrir();
            conect.cargarDatosClientes(dgvClientes);
            conect.cargarDatosViajes(dgvViajesDiponibles);
            conect.cargarDatosCamarote(dgvCamarotes);
            conect.cargarDatosFactura(dgvFactura);
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            frmMenu menu = new frmMenu();
            conect.cerrar();
            menu.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            poc1 = dgvClientes.CurrentRow.Index;

            txtCodCliente.Text = dgvClientes[0, poc1].Value.ToString();
            txtNombreCliente.Text = dgvClientes[1, poc1].Value.ToString();
            txtApellido.Text = dgvClientes[2, poc1].Value.ToString() + " " + dgvClientes[3, poc1].Value.ToString();
            txtEdad.Text = dgvClientes[8, poc1].Value.ToString();

            seleccion1 = 1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtEdad.Clear();
            txtCodCliente.Clear();
            txtNombreCliente.Clear();
            txtApellido.Clear();

            seleccion1 = 0;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            poc2 = dgvCamarotes.CurrentRow.Index;

            txtCodCamarote.Text = dgvCamarotes[0, poc2].Value.ToString();
            txtNivelCamarote.Text = dgvCamarotes[3, poc2].Value.ToString();
            txtTipoCamarote.Text = dgvCamarotes[2, poc2].Value.ToString();
            txtPrecioCamarote.Text = dgvCamarotes[4,poc2].Value.ToString();

            seleccion2 = 1;

        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtCodCamarote.Clear();
            txtNivelCamarote.Clear();
            txtTipoCamarote.Clear();
            txtPrecioCamarote.Clear();
            txtNumPersonas.Text = "1";

            seleccion2 = 0;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            poc3 = dgvViajesDiponibles.CurrentRow.Index;

            txtCodViaje.Text = dgvViajesDiponibles[0, poc3].Value.ToString();
            txtDuracion.Text = dgvViajesDiponibles[1, poc3].Value.ToString();
            txtCodDestino.Text = dgvViajesDiponibles[5, poc3].Value.ToString();
            txtCodBuque.Text = dgvViajesDiponibles[4, poc3].Value.ToString();

            seleccion3 = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtCodViaje.Clear();
            txtDuracion.Clear();
            txtCodDestino.Clear();
            txtCodBuque.Clear();

            seleccion3 = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            calculo = false;
            txtSubTotal.Clear();
            txtTerceraEdad.Clear();
            txtImpProtuarios.Clear();
            txtImpuesto.Clear();
            txtPropinas.Clear();
            txtTotal.Clear();
            txtCodViaje.Clear();
            txtDuracion.Clear();
            txtCodDestino.Clear();
            txtCodBuque.Clear();
            txtCodCamarote.Clear();
            txtNivelCamarote.Clear();
            txtTipoCamarote.Clear();
            txtPrecioCamarote.Clear();
            txtNumPersonas.Text = "1";
            txtEdad.Clear();
            txtCodCliente.Clear();
            txtNombreCliente.Clear();
            txtApellido.Clear();
            txtItinerario.Clear();
            itinerario = " ";
        }


        ClsCalculosFacturaccion factura = new ClsCalculosFacturaccion();

        string itinerario = " ";

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double sub;
            double portuario;
            double ivs;
            double propinas;

            if(seleccion1 == 0 || seleccion2 == 0 || seleccion3 == 0)
            {
                MessageBox.Show("Seleccione o Ingrese todos los datos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int personas = Convert.ToInt32(txtNumPersonas.Text);

                if (personas <= 0 || personas >=7)
                {
                    MessageBox.Show("Por restricciones por el COVID-19, Solamente se admite un máximo de 6 personas por cliente.   Atte. La Gerencia", "COVID-19", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtNumPersonas.Text = "1";
                    txtNumPersonas.Focus();
                }
                else
                {
                    calculo = true;
                    itinerario = " ";

                    factura.Edad_persona = Convert.ToInt32(txtEdad.Text);
                    factura.Duracion = Convert.ToInt32(txtDuracion.Text);
                    factura.Num_personas = Convert.ToInt32(txtNumPersonas.Text);
                    factura.Precio_camarote = Convert.ToDouble(txtPrecioCamarote.Text);

                    factura.edad(factura.Edad_persona);

                    txtSubTotal.Text = factura.subtotal(factura.Duracion, factura.Num_personas, factura.Precio_camarote).ToString("n2");

                    sub = factura.subtotal(factura.Duracion, factura.Num_personas, factura.Precio_camarote);

                    txtTerceraEdad.Text = factura.descuentoTerceraEdad().ToString("n2");

                    txtImpProtuarios.Text = factura.impuesto(0.05).ToString("n2");
                    portuario = Convert.ToDouble(txtImpProtuarios.Text);

                    txtImpuesto.Text = factura.impuesto(0.07).ToString("n2");
                    ivs = Convert.ToDouble(txtImpuesto.Text);

                    txtPropinas.Text = factura.calcular(0.10).ToString("n2");
                    propinas = Convert.ToDouble(txtPropinas.Text);

                    txtTotal.Text = factura.calcular(portuario, ivs, propinas).ToString("n2");

                    itinerario += "Cliente: "+txtNombreCliente.Text+" "+txtApellido.Text+"\r\n";
                    itinerario += "Codigo Cliente: " + txtCodCliente.Text + "\r\n";
                    itinerario += "RTN Cliente: " + dgvClientes[7, poc1].Value.ToString()+"\r\n\r\n";
                    itinerario += "Codigo Viaje: " + dgvViajesDiponibles[0, poc3].Value.ToString() + "\r\n";
                    itinerario += "Fecha de Salida: " + dgvViajesDiponibles[2, poc3].Value.ToString() + "\r\n";
                    itinerario += "Fecha de Llegada Destino: " + dgvViajesDiponibles[3, poc3].Value.ToString() + "\r\n";
                    itinerario += "Dias de duración: " + dgvViajesDiponibles[1, poc3].Value.ToString() +" Días"+ "\r\n";
                    itinerario += "Codigo de destino: " + dgvViajesDiponibles[5, poc3].Value.ToString() + "\r\n";
                    itinerario += "Codigo de Buque: " + dgvViajesDiponibles[4, poc3].Value.ToString() + "\r\n";
                    itinerario += "Codigo de Camarote: " + dgvCamarotes[0, poc2].Value.ToString() + "\r\n";
                    itinerario += "nivel de Camarote: " + dgvCamarotes[3, poc2].Value.ToString() + "\r\n";
                    itinerario += "Camarote tipo: " + dgvCamarotes[2, poc2].Value.ToString()+ "\r\n";
                    itinerario += "Precio Persona/Día: $ " + dgvCamarotes[4, poc2].Value.ToString()+ "\r\n";
                    itinerario += "Número de personas: " + txtNumPersonas.Text+ "\r\n\r\n";
                    itinerario += "Sub Total: $ " + txtSubTotal.Text + "\r\n";
                    itinerario += "Descuento Tercera Edad: $ " + txtTerceraEdad.Text + "\r\n";
                    itinerario += "I.V.S (7%): $ "+txtImpuesto.Text+ "\r\n";
                    itinerario += "Impuestos Portuarios (5%): $ " + txtImpProtuarios.Text + "\r\n";
                    itinerario += "Propinas (10%): $ " + txtPropinas.Text + "\r\n";
                    itinerario += "Total: $ " + txtTotal.Text + "\r\n\r\n";

                    txtItinerario.Text = itinerario;
                }
            }

            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (calculo == false)
                {
                    MessageBox.Show("Realize el calculo de factura correspondiente", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    cmd = new SqlCommand("INSERT INTO Factura (cod_cliente , cod_camarote , cod_buque , cod_destino , cod_viaje , sub_total , descuento_adulto_mayor , isv , impuesto_portuario , propinas , total)VALUES("+txtCodCliente.Text+","+txtCodCamarote.Text+","+txtCodBuque.Text+","+txtCodDestino.Text+","+txtCodViaje.Text+",'" + txtSubTotal.Text + "','" + txtTerceraEdad.Text+ "' , '" + txtImpuesto.Text + "','" + txtImpProtuarios.Text + "','" + txtPropinas.Text + "','"+txtTotal.Text+"')",conect.sc);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("La factura e itinerario fueron registradas con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    conect.cargarDatosFactura(dgvFactura);

                
                    itinerario = " ";
                    calculo = false;
                    txtSubTotal.Clear();
                    txtTerceraEdad.Clear();
                    txtImpProtuarios.Clear();
                    txtImpuesto.Clear();
                    txtPropinas.Clear();
                    txtTotal.Clear();
                    txtCodViaje.Clear();
                    txtDuracion.Clear();
                    txtCodDestino.Clear();
                    txtCodBuque.Clear();
                    txtCodCamarote.Clear();
                    txtNivelCamarote.Clear();
                    txtTipoCamarote.Clear();
                    txtPrecioCamarote.Clear();
                    txtNumPersonas.Text = "1";
                    txtEdad.Clear();
                    txtCodCliente.Clear();
                    txtNombreCliente.Clear();
                    txtApellido.Clear();
                    txtItinerario.Clear();
                   
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al ingresar los datos"+ex,"ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                calculo = false;
                calculo = false;
                txtSubTotal.Clear();
                txtTerceraEdad.Clear();
                txtImpProtuarios.Clear();
                txtImpuesto.Clear();
                txtPropinas.Clear();
                txtTotal.Clear();
                txtCodViaje.Clear();
                txtDuracion.Clear();
                txtCodDestino.Clear();
                txtCodBuque.Clear();
                txtCodCamarote.Clear();
                txtNivelCamarote.Clear();
                txtTipoCamarote.Clear();
                txtPrecioCamarote.Clear();
                txtNumPersonas.Clear();
                txtEdad.Clear();
                txtCodCliente.Clear();
                txtNombreCliente.Clear();
                txtApellido.Clear();
                txtItinerario.Clear();
            }
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToLongDateString();
            toolStripStatusLabel2.Text = DateTime.Now.ToLongTimeString();
        }

        private void dgvViajesDiponibles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtCodViaje_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItinerario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (indice == -1)
                {
                    MessageBox.Show("Seleccione un registro de factura a eliminar", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                {
                    cmd = new SqlCommand("DELETE FROM Factura WHERE cod_factura=" + indice, conect.sc);
                    cmd.ExecuteNonQuery();
                    conect.cargarDatosFactura(dgvFactura);
                    MessageBox.Show("Se han eliminado los datos con exito", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se pudo eliminar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                indice = -1;
            }
        }

        private void dgvFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indice = dgvFactura.CurrentRow.Index;
        }
    }
}
