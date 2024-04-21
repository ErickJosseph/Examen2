using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Funciones
{
    public class ConvertirNumero
    {
        public string Cadena { set; get; }
        public int Numero { set; get; }
        public string Mensaje { set; get; }

        public int ConvertirString()
        {
            try
            {
                Mensaje = "";
                Numero = int.Parse(Cadena);
                return Numero;
            }
            catch (FormatException)
            {
                Mensaje = "Error al convertir al formato solicitado.";
                return 0;
                
            }
        }
    }
}
