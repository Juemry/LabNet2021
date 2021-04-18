using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Exceptions
{
    public class Logic
    {
        //Clase Logic con metodos que producen excepciones en caso de ingresar un entero fuera del rango 1 al 12
        public static string CorroborarMes(int a)
            {
            switch (a)
            {
                case 1:
                    return $"El numero {a} corresponde a Enero";
                case 2:
                    return $"El numero {a} corresponde a Febrero";
                case 3:
                    return $"El numero {a} corresponde a Marzo";
                case 4:
                    return $"El numero {a} corresponde a Abril";
                case 5:
                    return $"El numero {a} corresponde a Mayo";
                case 6:
                    return $"El numero {a} corresponde a Junio";
                case 7:
                    return $"El numero {a} corresponde a Julio";
                case 8:
                    return $"El numero {a} corresponde a Agosto";
                case 9:
                    return $"El numero {a} corresponde a Septiembre";
                case 10:
                    return $"El numero {a} corresponde a Octubre";
                case 11:
                    return $"El numero {a} corresponde a Noviembre";
                case 12:
                    return $"El numero {a} corresponde a Diciembre";
            }
            throw new ArgumentOutOfRangeException();
        }

        //Igual pero con Custom Exception
        public static string CorroborarMesCustom(int a)
        {
            switch (a)
            {
                case 1:
                    return $"El numero {a} corresponde a Enero";
                case 2:
                    return $"El numero {a} corresponde a Febrero";
                case 3:
                    return $"El numero {a} corresponde a Marzo";
                case 4:
                    return $"El numero {a} corresponde a Abril";
                case 5:
                    return $"El numero {a} corresponde a Mayo";
                case 6:
                    return $"El numero {a} corresponde a Junio";
                case 7:
                    return $"El numero {a} corresponde a Julio";
                case 8:
                    return $"El numero {a} corresponde a Agosto";
                case 9:
                    return $"El numero {a} corresponde a Septiembre";
                case 10:
                    return $"El numero {a} corresponde a Octubre";
                case 11:
                    return $"El numero {a} corresponde a Noviembre";
                case 12:
                    return $"El numero {a} corresponde a Diciembre";
            }
            throw new CustomException();
        }
    }
}
