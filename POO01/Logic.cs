using System;
using System.Collections.Generic;
using System.Text;

namespace POO01
{
    class Logic
    {
        public void ImprimirMenu() {

            Console.WriteLine("\n\nAcciones disponibles: ");
            Console.WriteLine("1) Ver lista de Aviones");
            Console.WriteLine("2) Avanzar Aviones");
            Console.WriteLine("3) Detener Aviones");
            Console.WriteLine("4) Ver lista de Autos");
            Console.WriteLine("5) Avanzar Autos");
            Console.WriteLine("6) Detener Autos");
            Console.WriteLine("7) Ver lista de Transportes y pasajeros");
            Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");

        }

        public List<ITransporte> CrearLista()
        {
            List<ITransporte> transportes = new List<ITransporte>
            {
                //Lista de Aviones especificada en la consigna del trabajo
                new Avion(100,1),
                new Avion(30,2),
                new Avion(10,3),
                new Avion(50,4),
                new Avion(150,5),
                 //Lista de Aviones especificada en la consigna del trabajo
                new Automovil(4,1),
                new Automovil(2,2),
                new Automovil(4,3),
                new Automovil(1,4),
                new Automovil(3,5)
            };
            return transportes;
        }

        public int IngresarOpcion(int opc)
        {
            try
            {
                opc = Int32.Parse(Console.ReadLine());
                return opc;
            }
            catch (FormatException)
            {
                Console.WriteLine("Ingreso un valor incorrecto, vuelva a intentar");
                //throw;
            }
            return opc;
        }

        public void MenuConSwitch(int opc, List<ITransporte> transportes)
        {
            switch (opc)
            {
                case 1:
                    foreach (var item in transportes)
                    {
                        if (item is Avion)
                        {
                            Console.WriteLine(item.Informar());
                        }
                    }
                    break;
                case 2:

                    foreach (var item in transportes)
                    {
                        if (item is Avion)
                        {
                            Console.WriteLine(item.Avanzar());
                        }
                    }
                    break;
                case 3:
                    foreach (var item in transportes)
                    {
                        if (item is Avion)
                        {
                            Console.WriteLine(item.Detenerse());
                        }
                    }
                    break;
                case 4:
                    foreach (var item in transportes)
                    {
                        if (item is Automovil)
                        {
                            Console.WriteLine(item.Informar());
                        }
                    }
                    break;
                case 5:
                    foreach (var item in transportes)
                    {
                        if (item is Automovil)
                        {
                            Console.WriteLine(item.Avanzar());
                        }
                    }
                    break;
                case 6:
                    foreach (var item in transportes)
                    {
                        if (item is Automovil)
                        {
                            Console.WriteLine(item.Detenerse());
                        }
                    }
                    break;
                case 7:
                    foreach (var item in transportes)
                    {
                        Console.WriteLine(item.Informar());
                    }
                    break;
                    //default:
                    //    Console.WriteLine("Vuelva a intentar");
                    //    break;

            }
        }
    }
}
