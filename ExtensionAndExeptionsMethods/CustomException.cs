using System;
using System.Collections.Generic;
using System.Text;

namespace ExtensionAndExceptionsMethods.Exceptions
{
    class CustomException : Exception
    {
        public CustomException() : base("Mensaje de Custom Exception. Los meses van del 1 al 12. Volver a intentar") 
        {
        
        }
    }
}
