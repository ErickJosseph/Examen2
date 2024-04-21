using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Clase
{
    public class Arreglo
    {

        public int[] ArregloEntero { get; set; }
        public int indice { get; set; }
        public int NumeroEntero { get; set; }

        public void ObtenerElemento(int A)
        {
            try
            {
                NumeroEntero = ArregloEntero[A];
                Console.WriteLine(NumeroEntero);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("El índice ingresado esta fuera del rango, por favor elegir otro elemento");
            }
            catch (Exception)
            {
                Console.WriteLine("Ocurrió un error");
            }
        }
    }
}
