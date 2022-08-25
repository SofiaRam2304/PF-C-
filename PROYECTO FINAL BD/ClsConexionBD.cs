using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace PROYECTO_FINAL_BD
{
    public class ClsConexionBD:ClsSuperclase
    {

        SqlDataAdapter da;
        DataTable dt;

        
        string conexion = "Data Source = DESKTOP-NKVF9SH; Initial Catalog = Proyecto_Datos; Integrated Security = true";

        
        public SqlConnection sc = new SqlConnection();

       
        public ClsConexionBD()
        {
            sc.ConnectionString = conexion;
        }

        public void abrir()
        {
            try
            {
                sc.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrio un error al abrir la base de datos " + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cerrar()
        {
            sc.Close();
        }

        public void logear(string usuario, string contrasena)
        {
            try
            {
                sc.Open();
                SqlCommand cmd = new SqlCommand("SELECT tipo_usuario FROM Usuarios WHERE Usuario = @Usuario AND Contrasena = @password",sc);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("password", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    ClsSuperclase inicio = new ClsSuperclase();
                    frmMenu menu = new frmMenu();
                    InicioExitoso = 0;

                    if(dt.Rows[0][0].ToString()== "Gerente")
                    {
                        MessageBox.Show("Se ha abierto usuario tipo Administrador");
                        inicio.Administrador = 1;
                        inicio.InicioExitoso = 1;
                        //login.Hide();
                        menu.Show();
                    }
                    else
                    {
                        if (dt.Rows[0][0].ToString() == "Vendedor")
                        {
                            MessageBox.Show("Se ha abierto Usuario de Vendedor");
                            inicio.Administrador= 0;
                            inicio.InicioExitoso = 1;
                            //login.Hide();
                            menu.Show();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña Incorrectos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sc.Close();
            }
            
        }

        public void cargarDatosClientes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Clientes", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosViajes(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select *from Viajes", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }

            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosPuertos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Puertos", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosDestinos(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Destinos", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosCamarote(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Camarotes", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosBuques(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * From Buques", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void cargarDatosFactura(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("SELECT * FROM Factura", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden cargar los datos" + ex, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
