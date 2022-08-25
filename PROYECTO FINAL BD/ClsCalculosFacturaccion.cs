using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_FINAL_BD
{
    public class ClsCalculosFacturaccion:ClsSuperclase
    {
        private static double sub_total = 0;
        private static double total = 0;
        private static double impuestos = 0;
        private static double impuestos_portuarios = 0;
        private static double propinas = 0;
        private static double descuento_tercera_edad = 0;

        public double Sub_total1 { get => sub_total; set => sub_total = value; }
        public double Total1 { get => total; set => total = value; }
        public double Impuestos1 { get => impuestos; set => impuestos = value; }
        public double Impuestos_portuarios1 { get => impuestos_portuarios; set => impuestos_portuarios = value; }
        public double Propinas1 { get => propinas; set => propinas = value; }
        public double Descuento_tercera_edad1 { get => descuento_tercera_edad; set => descuento_tercera_edad = value; }

        //METODOS 
        public double subtotal(int duracion, int num_personas, double precio_camarote)
        {
            sub_total = (duracion * num_personas * precio_camarote);

            return sub_total;
        }

        int valorEdad = 0;

        public int edad(int edad)
        {
            valorEdad = edad;
            return valorEdad;
        }

        new public double descuentoTerceraEdad()
        {
            if(valorEdad >= 60)
            {
                return descuento_tercera_edad = (sub_total * 0.25);
            }
            else
            {
                return descuento_tercera_edad = 0;
            }
        }

        public override double impuesto(double impuesto)
        {
            return(sub_total * impuesto);
        }

        public double calcular(double valor)
        {
            return (sub_total * valor);
        }
  
        public double calcular(double impuesto1, double impuesto2, double propinas)
        {
            return (sub_total - (descuento_tercera_edad) + (impuesto1 + impuesto2 + propinas));
        }
    }
}
