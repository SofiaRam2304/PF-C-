using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_BD
{
    public class ClsSuperclase
    {
        public static int administrador = 0;
        public static int inicioExitoso = 0;

        private static int duracion;
        private static int num_personas;
        private static double precio_camarote;
        private static int edad_persona;


        public int Administrador { get => administrador; set => administrador = value; }
        public int InicioExitoso { get => inicioExitoso; set => inicioExitoso = value; }


        public int Duracion { get => duracion; set => duracion = value; }
        public int Num_personas 
        { 
            get => num_personas;
            set
            {
                if(value >0 && value<= 6)
                {
                    num_personas = value;
                }
                else
                {
                    value = 0;
                }
            }
        }
        public double Precio_camarote { get => precio_camarote; set => precio_camarote = value; }
        public int Edad_persona { get => edad_persona; set => edad_persona = value; }

        //Metodos
        public double subtotal()
        {
            return 0;
        }

        public int edad()
        {
            return 0;
        }

        public double descuentoTerceraEdad()
        {
            return 0;
        }
       
        public virtual double impuesto(double impuesto)
        {
            return 0;
        }
    }
}
