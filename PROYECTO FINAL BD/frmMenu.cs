using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_FINAL_BD
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            frmFacturaccion factura = new frmFacturaccion();
            factura.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ClsConexionBD conexion = new ClsConexionBD();

        private void button8_Click(object sender, EventArgs e)
        {
            conexion.sc.Close();
            this.Close();
            Form1 login = new Form1();
            login.Show();
            conexion.InicioExitoso = 0;
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            ClsConexionBD conexion = new ClsConexionBD();

            if(conexion.Administrador == 1)
            {

                toolStripStatusLabel1.Text = "Gerente Administrador";
            }
            else
            {
                toolStripStatusLabel1.Text = "Agente de Ventas";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FrmViajesDisponibles viajes = new FrmViajesDisponibles();
            this.Hide();
            viajes.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FrmPuertos puertos = new FrmPuertos();
            this.Hide();
            puertos.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FrmLugares lugares = new FrmLugares();
            this.Hide();
            lugares.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FrmCamarotes camarotes = new FrmCamarotes();
            this.Hide();
            camarotes.Show();
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conexion.sc.Close();
            this.Close();
            Form1 login = new Form1();
            login.Show();
            conexion.InicioExitoso = 0;
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClientes clientes = new FrmClientes();
            clientes.Show();
            this.Hide();
        }

        private void lugaresTurísticosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLugares lugares = new FrmLugares();
            this.Hide();
            lugares.Show();
        }

        private void buquesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBuques Buques = new FrmBuques();
            this.Hide();
            Buques.Show();
        }

        private void camarotesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCamarotes camarotes = new FrmCamarotes();
            this.Hide();
            camarotes.Show();
        }

        private void viajesDisponiblesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViajesDisponibles viajes = new FrmViajesDisponibles();
            this.Hide();
            viajes.Show();
        }

        private void puertosDeSalidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPuertos puertos = new FrmPuertos();
            this.Hide();
            puertos.Show();
        }

        private void facturacciónEItinerarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            frmFacturaccion Factura = new frmFacturaccion();
            this.Hide();
            Factura.Show();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            conexion.sc.Close();
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FrmBuques Buques = new FrmBuques();
            this.Hide();
            Buques.Show();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agencia de viajes MSC Cruises V.1.0 \r\nMSC Cruises es una Marca registrada que NO está asociada con este programa.\r\nPrograma desarrollado con fines de Estudio", "Información del programa", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
