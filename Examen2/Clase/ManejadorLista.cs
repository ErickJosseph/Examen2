using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Clase
{
    public class ManejadorLista
    {
        public int Numero { get; set; }
        public List<int> ListaNumero { get; set; }

        public void EliminarElemento()
        {
            try
            {
                ListaNumero.Remove(ListaNumero[ListaNumero.Count() - 1]);
                Console.WriteLine($"Se realizo la eliminación del ultimo registro correctamente");
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("la lista se encuentra vacía");
            }

        }
        public void AgregarElemento(List<int> Lista)
        {
            try
            {
                Lista.Add(Numero);
                Console.WriteLine($"Se agrego el registro correctamente.");

            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("La lista se encuentra vacía");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al realizar la operación");
            }
        }

    }
}
