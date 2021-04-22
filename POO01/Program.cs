using System;
using System.Collections.Generic;

namespace POO01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creacion de una clase Logic para que maneje la logica del programa
            Logic logic = new Logic();
            //Creacion de la lista con aviones y autos
            List<ITransporte> transportes = logic.CrearLista();
            //Saludo inicial
            Console.WriteLine("**Software de Transporte**\n\n");
            Console.WriteLine("Mostrando transportes:\n");

            //Uso de la opcion en el switch para que todos los items de la lista implementen la funcion .Informar();
            logic.MenuConSwitch(7, transportes);
            
            //Uso de While para realizar algunas acciones con menu
            int opc = -1;

            do
            {
                //Funcion para imprimir el Menu de Opciones
                logic.ImprimirMenu();
                //Funcion para solicitar y guardar la opcion seleccionada por el usuario
                opc = logic.IngresarOpcion(opc);

                Console.Clear();
                //Logica del menu segun la opcion que haya seleccionado el usuario
                logic.MenuConSwitch(opc, transportes);


            } while (opc != 0);

            Console.WriteLine("A seleccionado salir del Software de Transporte. Hasta luego!\n\n");
            Console.ReadLine();
          
        }
    }
}
