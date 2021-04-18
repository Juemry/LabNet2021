﻿using ExtensionAndExceptionsMethods.Extensions;
using ExtensionAndExceptionsMethods.Exceptions;
using System;

namespace ExtensionAndExceptionsMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //inicio de variables para operaciones aritmeticas 
            int? dividendo = null;
            int? divisor = null;

            //Uso de While para realizar algunas acciones con menu
            int opc = -1;
            do
            {
                Console.Clear();

                Console.WriteLine("\n**Software de Extension Methods, Exception Methods, Customs Exceptions & Unit Test**\n");
                Console.WriteLine("Acciones disponibles: ");
                Console.WriteLine("1) Realizar Division");
                Console.WriteLine("2) Realizar Division. Version Chuck Norris®");
                Console.WriteLine("3) Corroborar que a que mes corresponde un entero.");
                Console.WriteLine("4) Corroborar que a que mes corresponde un entero. Con Custom Exception");
                Console.WriteLine("Ingrese la accion que desea realizar (cero para salir): ");


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
                        try
                        {
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
                            Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                            Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                        }
                        break;
                    case 2:
                        try
                        {
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
                            Console.WriteLine("Mensaje de Error: ");
                            Console.WriteLine(ex.Message);
                            //Inclusion de StackTrace
                            Console.WriteLine("StackTrace: ");
                            Console.WriteLine(ex.StackTrace);
                        }

                        break;
                    case 3:
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
                            Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                            Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                        }
                        break;
                    case 4:
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
                            Console.WriteLine($"El tipo de Error es: {ex.GetType()}");
                            Console.WriteLine($"Mensaje de Error: {(ex.Message)}");
                        }
                        break;

                }
                Console.ReadLine();
                
            } while (opc != 0);

            Console.WriteLine("A seleccionado salir del Software. Hasta luego!\n\n");
            Console.ReadLine();
        }
    }
}