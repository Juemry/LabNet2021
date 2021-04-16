using System;
using System.Collections.Generic;
using System.Text;

namespace POO01
{
    public class Avion : Transporte
    {
        //Constructor para clase Avion donde se recibe las características herdadas de Transporte
        public Avion(int pasajeros, int nroTransporte) : base(pasajeros, nroTransporte)
        {

        }
        
        //Implementaciones de los metodos pedidos por la consigna
        public override string Avanzar()
        {
            return $"Avanzaron {GetPasajeros()} pasajeros del Avion {GetNroTransporte()}";
            throw new NotImplementedException();
        }


        public override string Detenerse()
        {
            return $"Se detuvieron {GetPasajeros()} pasajeros del Avion {GetNroTransporte()}";
            throw new NotImplementedException();
        }

        public override string Informar()
        {
            return $"Avion {GetNroTransporte()}: {GetPasajeros()} pasajeros.";
            throw new NotImplementedException();
        }
    }
}

