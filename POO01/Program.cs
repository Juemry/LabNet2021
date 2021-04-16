using System;
using System.Collections.Generic;

namespace POO01
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Estuve tratando de hacer una lista dentro de otra lista, tipo diccionario, y no logre implementarlo :/
            //Quise hacer una lista con transportes e imprimir en la lista de acciones solo un tipo e imprimia todo
            //Cree listas separadas y funciona como tengo pensado, sin embargo, no se si es la mejor implementación
            //Les preguntare en el proximo encuentro y ustedes diran :)

            List<Transporte> aviones = new List<Transporte>
            {
                //Lista de Aviones especificada en la consigna del trabajo
                new Avion(100,1),
                new Avion(30,2),
                new Avion(10,3),
                new Avion(50,4),
                new Avion(150,5)
            };
            
            List<Transporte> automoviles = new List<Transporte>
            {
                //Lista de Aviones especificada en la consigna del trabajo
                new Automovil(4,1),
                new Automovil(2,2),
                new Automovil(4,3),
                new Automovil(1,4),
                new Automovil(3,5)
            };

            Console.WriteLine("**Software de Transporte**\n\n");
            Console.WriteLine("Mostrando transportes:\n");
            //Uso de foreach para presentar cada listado de los transportes
            foreach (var item in automoviles)
            {
                Console.WriteLine(item.Informar());
            }
            foreach (var item in aviones)
            {
                Console.WriteLine(item.Informar());
            }

            
            //Uso de While para realizar algunas acciones con menu
            int opc = -1;

            do
            {
                Console.WriteLine("\n\nAcciones disponibles: ");
                Console.WriteLine("1) Ver lista de Aviones");
                Console.WriteLine("2) Avanzar Aviones"); 
                Console.WriteLine("3) Detener Aviones");
                Console.WriteLine("4) Ver lista de Autos");
                Console.WriteLine("5) Avanzar Autos");
                Console.WriteLine("6) Detener Autos");
                Console.WriteLine("7) Ver lista de Transportes y pasajeros");
                Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");


                {
                    try
                    {
                        opc = Int32.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ingreso un valor incorrecto, vuelva a intentar");
                        //throw;
                    }
                }

                Console.Clear();

                switch (opc)
                {
                    case 1:
                        foreach (var Avion in aviones)
                        {
                            Console.WriteLine(Avion.Informar());
                        }
                        break;
                    case 2:
                        foreach (var Avion in aviones)
                        {
                            Console.WriteLine(Avion.Avanzar());
                        }
                        break;
                    case 3:
                        foreach (var Avion in aviones)
                        {
                            Console.WriteLine(Avion.Detenerse());
                        }
                        break;
                    case 4:
                        foreach (var Automovil in automoviles)
                        {
                            Console.WriteLine(Automovil.Informar());
                        }
                        break;
                    case 5:
                        foreach (var Automovil in automoviles)
                        {
                            Console.WriteLine(Automovil.Avanzar());
                        }
                        break;
                    case 6:
                        foreach (var Automovil in automoviles)
                        {
                            Console.WriteLine(Automovil.Detenerse());
                        }
                        break;
                    case 7:
                        foreach (var Avion in aviones)
                        {
                            Console.WriteLine(Avion.Informar());
                        }
                        foreach (var Automovil in automoviles)
                        {
                            Console.WriteLine(Automovil.Informar());
                        }
                        
                        break;
                        //default:
                        //    Console.WriteLine("Vuelva a intentar");
                        //    break;

                }


            } while (opc != 0);

            Console.WriteLine("A seleccionado salir del Software de Transporte. Hasta luego!\n\n");
            Console.ReadLine();
          
        }
    }
}
