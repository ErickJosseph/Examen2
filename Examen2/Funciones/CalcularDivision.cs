using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2.Funciones
{
    public class CalcularDivision
    {
        public int Numero1 { set; get; }
        public int Numero2 { set; get; }
        public double Resultado { set; get; }

        public double Dividir(int Num1, int Num2)
        {
            try
            {
                Resultado = Num1 / Num2;
                Console.WriteLine (Resultado);
                return Resultado;
            }
            catch(DivideByZeroException) 
            {
                Console.WriteLine("Usted esta intentando dividir un numero entre cero.");
                return 0;
            }
        }
    }
}
