using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PROYECTO_FINAL_BD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        ClsConexionBD conexion = new ClsConexionBD();

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        ClsSuperclase inicio = new ClsSuperclase();

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            conexion.logear(this.txtUsuario.Text, this.txtContrasena.Text);

            if(inicio.InicioExitoso == 1)
            {
                this.Hide();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conexion.sc.Close();
            Application.Exit();
        }
    }
}
