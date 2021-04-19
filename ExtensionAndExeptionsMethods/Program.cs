using ExtensionAndExceptionsMethods.Extensions;
using ExtensionAndExceptionsMethods.Exceptions;
using System;

namespace ExtensionAndExceptionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {

            Logic logic = new Logic();
            
            logic.Start();

            

            Console.WriteLine("A seleccionado salir del Software. Hasta luego!");
            Console.ReadLine();
        }
    }
}
