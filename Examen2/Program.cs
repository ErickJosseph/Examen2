// See https://aka.ms/new-console-template for more information

using Examen2.Clase;
using Examen2.Funciones;
using System.Security.Cryptography.X509Certificates;

namespace Examen2
{
    class program
    {
        static void Main(String[] args)
        {
            bool Validador = true;
            int OpcionMenu = 0;

            do
            {
                try
                {
                    Console.WriteLine("=====================MENU EJERCICIO======================");
                    Console.WriteLine("1) Ejercicio de calcular División");
                    Console.WriteLine("2) Ejercicio de elementos de la lista");
                    Console.WriteLine("3) Ejercicio de convertir");
                    Console.WriteLine("4) Ejercicio de elegir índice");
                    Console.WriteLine("5) Ejercicio de Dividir numero negativo");
                    Console.WriteLine("6) Salir");

                    OpcionMenu = int.Parse(Console.ReadLine());
                    switch (OpcionMenu)
                    {
                        case 1:
                            OnDividir();
                            break;
                        case 2:
                            OnAgregarLista();
                            break;
                        case 3:
                            OnConvertirCadena();
                            break;
                        case 4:
                            OnElegirElemento();
                            break;
                        case 5:
                            OnCalcularDivision();
                            break;
                        case 6:
                            Validador = false;
                            break;
                        default:
                            Console.WriteLine("la opción ingresada no se encuentra dentro del menú.");
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("=====================ERROR======================");
                    Console.WriteLine("Error al ingresar el dato, por favor seleccione un numero.");
                }

            } while (Validador);



            //Caso 1
            void OnDividir()
            {
                Console.WriteLine("===================== DIVIDIR ======================");
                CalcularDivision Division = new CalcularDivision();
                Console.WriteLine("Ingrese el primer numero: ");
                Division.Numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el segundo numero: ");
                Division.Numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine(Division.Dividir(Division.Numero1, Division.Numero2));
            }

            //Caso 2
            void OnAgregarLista()
            {
                bool ValidadorLista = true;
                string Condicion = "SI";
                int OpcionLista = 0;
                ManejadorLista ListaM = new ManejadorLista();
                ListaM.ListaNumero = new List<int>();
                do
                {
                    try
                    {

                        Console.WriteLine("===================== EJERCICIO 2 ======================");
                        Console.WriteLine("1) Agregar elemento.");
                        Console.WriteLine("2) Eliminar elemento.");
                        Console.WriteLine("3) Salir.");


                        OpcionLista = int.Parse(Console.ReadLine());

                        switch (OpcionLista)
                        {
                            case 1:
                                Console.WriteLine("===================== AGREGAR ELEMENTO ======================");
                                Console.WriteLine("Por favor agregar elemento");

                                ListaM.Numero = int.Parse(Console.ReadLine());
                                ListaM.AgregarElemento(ListaM.ListaNumero);

                                break;
                            case 2:
                                if (ListaM.ListaNumero.Count() > 0)
                                {
                                    Console.WriteLine("===================== ELIMINAR ELEMENTO ======================");
                                    Console.WriteLine("Por favor ingrese el elemento a eliminar");

                                    foreach (int Lista in ListaM.ListaNumero)
                                    {
                                        Console.WriteLine($"Elemento: {Lista}");
                                    }
                                    Console.WriteLine($"¿Desea eliminar el ultimo registro? (SI/NO)");
                                    Condicion = Console.ReadLine();
                                    if (Condicion.ToUpper() == "SI")
                                    {
                                        ListaM.EliminarElemento();
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("La lista no cuenta con elementos.");
                                }
                                break;
                            case 3:
                                ValidadorLista = false;
                                break;
                            default:
                                Console.WriteLine("la opción ingresada no se encuentra dentro del menú.");
                                break;
                        }


                    }
                    catch (Exception)
                    {
                        Console.WriteLine("=====================ERROR======================");
                        Console.WriteLine("Error al ingresar el dato, por favor seleccione un numero.");
                    }
                }
                while (ValidadorLista);
            }

            //Caso 3 

            void OnConvertirCadena()
            {
                ConvertirNumero convertirNumero = new ConvertirNumero();

                Console.WriteLine("===================== Ejercicio Convertir ======================");
                Console.WriteLine("Agregar la cadena a convertir a numero");
                convertirNumero.Cadena = Console.ReadLine();
                if (convertirNumero.Cadena != "")
                {
                    int valor = convertirNumero.ConvertirString();
                    if (convertirNumero.Mensaje == "")
                    {
                        Console.WriteLine("El valor convertido a entero es: ");
                        Console.WriteLine(convertirNumero.Numero);
                    }
                    else
                    {
                        Console.WriteLine(convertirNumero.Mensaje);
                    }
                }
                else
                {
                    Console.WriteLine("El valor ingresado es incorrecto");
                }


            }

            //Caso 4

            void OnElegirElemento()
            {
                try
                {
                    Arreglo ArregloEntero = new Arreglo();
                    ArregloEntero.indice = 0;

                    ArregloEntero.ArregloEntero = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

                    Console.WriteLine("===================== EJERCICIO 4 ======================");
                    Console.WriteLine("De la siguiente lista elegir un numero de elemento:");

                    for (int i = 0; i < ArregloEntero.ArregloEntero.Count(); i++)
                    {
                        Console.WriteLine($"Elemento {i + 1}: {ArregloEntero.ArregloEntero[i]} ");
                    }

                    ArregloEntero.indice = int.Parse(Console.ReadLine());

                    Console.WriteLine($"El elemento seleccionado es el {ArregloEntero.indice}");
                    ArregloEntero.ObtenerElemento(ArregloEntero.indice);

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Ocurrió un erro " + ex.Message);
                }

            }

            //Caso 5
            void OnCalcularDivision()
            {
                try
                {
                    CalcularDivisionNumero Dividir = new CalcularDivisionNumero();

                    Console.WriteLine("===================== EJERCICIO DIVISION DE NUMEROS ======================");
                    Console.WriteLine("Ingrese el primer numero para dividir");
                    Dividir.Numero1 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Ingrese el segundo numero para dividir");
                    Dividir.Numero2 = int.Parse(Console.ReadLine());

                    Dividir.DividirNumero(Dividir.Numero1, Dividir.Numero2);
                }
                catch
                {
                    Console.WriteLine("Error al ingresar los datos");
                }

            }

        }
    }
}


