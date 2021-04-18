using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Extensions
{
    public static class Extensions
    {
        //Metodos de extension para dividir con excepcion en caso de dividir por cero
        public static string DividirPor(this int? dividendo, int? divisor)
        {
            int? resultado = null;
            try
            {
                resultado = dividendo / divisor;
                return $"El resultado de {dividendo}, dividido en {divisor} es {resultado}";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Mensaje de Error: ");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("La operacion ha finalizado.");
            }
            return null;
        }

        //Metodo de extension para dividir con exception cuando se divide por cero y respuesta personalizada
        public static string DividirALoNorris(this int? dividendo, int? divisor)
        {
            int? resultado = null;
            try
            {
                resultado = dividendo / divisor;
                return $"El resultado de {dividendo}, dividido en {divisor} es {resultado}";
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Solo Chuck Norris divide por cero!");
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"StackTrace: {(ex.StackTrace)}");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"StackTrace: {(ex.StackTrace)}");
            }
            //finally
            //{
            //    Console.WriteLine("La operacion finaliza cuando Chuck quiere.");
            //}
            return null;
        }
    };
}
