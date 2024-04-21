using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Funciones
{
    public class CalcularDivisionNumero
    {
        public int Numero1 { set; get; }
        public int Numero2 { set; get; }
        public int Resultado { set; get; }


        public double DividirNumero(int Num1, int Num2)
        {
            try
            {
                if (Num1 < 0 || Num2 < 0)
                {
                    throw new ArgumentException(String.Format("El valor ingresado es negativo"));
                    //Console.WriteLine("El numero ingreso es negativo");
                }
                Resultado = Num1 / Num2;

                Console.WriteLine($"El resultado es: {Resultado}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("No se puede dividir entre cero.");
            }
            catch (Exception)
            {
                Console.WriteLine("Error al ingresar el numero");
            }
            return Resultado;
        }
    }
}
