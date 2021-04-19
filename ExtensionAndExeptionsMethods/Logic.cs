using ExtensionAndExceptionsMethods.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Exceptions
{
    public class Logic
    {
        //Metodo void llamado Start que llama a los metodos que le dan funcionalidad al programa
        public void Start()
        {
            
            int opc = -1;
            do
            {
                Console.Clear();

                ImprimirMenu();

                SwitchConMenu(opc);


            } while (opc != 0);
        }

        //Clase Logic con metodos que producen excepciones en caso de ingresar un entero fuera del rango 1 al 12
        public static string CorroborarMes(int a)
        {
            string[] meses = { "Nada :(, pero index 0 del array", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Noviembre", "Diciembre" };
            return $"El numero {a} corresponde a {meses[a]}";
            throw new IndexOutOfRangeException();
        }

        //Igual pero con Custom Exception
        public static string CorroborarMesCustom(int a)
        {
            try
            {
                string[] meses = { "Nada :(, pero index 0 del array", "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Noviembre", "Diciembre" };
                return $"El numero {a} corresponde a {meses[a]}";
            }
            catch (Exception)
            {
                throw new CustomException();
            }
        }

        //Switch para seleccionar las distintas opciones del menu
        public void SwitchConMenu(int opc)
        {

            {
                try
                {
                    opc = Int32.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ingreso un valor incorrecto, vuelva a intentar");
                }
            }

            Console.Clear();

            switch (opc)
            {
                case 1:
                    Opcion1();
                    break;
                case 2:
                    Opcion2();
                    break;
                case 3:
                    Opcion3();
                    break;
                case 4:
                    Opcion4();
                    break;
            }
            Console.ReadLine();
        }

        public void Opcion1() {
            try
            {
                int? dividendo = null;
                int? divisor = null;
                Console.WriteLine("Selecciono: 1) Realizar Division");
                Console.WriteLine("Ingrese el dividendo:");
                dividendo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor:");
                divisor = Int32.Parse(Console.ReadLine());
                //Metodo que genera una simple excepcion al intentar dividir por cero
                Console.WriteLine(dividendo.DividirPor(divisor));
            }
            catch (FormatException ex)
            {
                //En caso de que haya error en el input ingresado
                Console.WriteLine("Ingreso un valor incorrecto, vuelva a intentar");
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
            }
        }

        public void Opcion2()
        {
            try
            {
                int? dividendo = null;
                int? divisor = null;
                Console.WriteLine("Selecciono: 2) Realizar Division. Version Chuck Norris®");
                Console.WriteLine("Ingrese el dividendo:");
                dividendo = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese el divisor:");
                divisor = Int32.Parse(Console.ReadLine());
                //Metodo que genera una excepcion particular al intentar dividir por cero
                Console.WriteLine(dividendo.DividirALoNorris(divisor));
            }
            catch (FormatException ex)
            {
                //En caso de que haya error en el input ingresado
                Console.WriteLine("Seguro ingreso una letra o no ingreso nada!");
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                //Inclusion de StackTrace
                Console.WriteLine("StackTrace: ");
                Console.WriteLine(ex.StackTrace);
            }
        }

        public void Opcion3()
        {
            try
            {
                Console.WriteLine("Selecciono: 3) Corroborar que a que mes corresponde un entero.");
                Console.WriteLine("Ingrese un entero para saber a que mes del año corresponde.");
                Console.WriteLine("En caso de que no corresponda se le informara con una Excepcion.");
                int mes = Int32.Parse(Console.ReadLine());
                //Metodo de una clase Logic que dispara una excepcion cuando se introduce un entero fuera del rango del 1 al 12
                Console.WriteLine(Logic.CorroborarMes(mes));
            }
            catch (Exception ex)
            {
                //Excepcion en general para evitar la ruptura del programa
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
            }
        }

        public void Opcion4()
        {
            try
            {
                Console.WriteLine("Selecciono: 4) Corroborar que a que mes corresponde un entero. Con Custom Exception");
                Console.WriteLine("Ingrese un entero para saber a que mes del año corresponde.");
                Console.WriteLine("En caso de que no corresponda se le informara con una Custom Exception.");
                int mes = Int32.Parse(Console.ReadLine());
                //Metodo de una clase Logic que dispara una excepcion Custom cuando se introduce un entero fuera del rango del 1 al 12
                Console.WriteLine(Logic.CorroborarMesCustom(mes));
            }
            catch (Exception ex)
            {
                //Excepcion en general para evitar la ruptura del programa
                Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
            }
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("\n**Software de Extension Methods, Exception Methods, Customs Exceptions & Unit Test**\n");
            Console.WriteLine("Acciones disponibles: ");
            Console.WriteLine("1) Realizar Division");
            Console.WriteLine("2) Realizar Division. Version Chuck Norris®");
            Console.WriteLine("3) Corroborar que a que mes corresponde un entero.");
            Console.WriteLine("4) Corroborar que a que mes corresponde un entero. Con Custom Exception");
            Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");
        }
    }
}
