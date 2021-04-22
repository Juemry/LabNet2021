using System;
using System.Collections.Generic;
using System.Text;

namespace POO01
{
    public interface ITransporte
    {
        //Implementacion de interfaz con la inclusion del metodo Informar
        string Informar();
        string Avanzar();
        string Detenerse();
    }
}
