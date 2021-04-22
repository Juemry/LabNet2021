﻿using System;
using System.Collections.Generic;
using System.Text;

namespace POO01
{
    public class Automovil : Transporte, ITransporte
    {
        //Constructor para clase Automovil donde se recibe las características herdadas de Transporte
        public Automovil(int pasajeros, int nroTransporte) : base(pasajeros, nroTransporte)
        {

        }

        //Implementaciones de los metodos pedidos por la consigna
        public override string Avanzar()
        {
            return $"Avanzaron {GetPasajeros()} pasajeros del Automovil {GetNroTransporte()}";
            throw new NotImplementedException();
        }

        public override string Detenerse()
        {
            return $"Se detuvieron {GetPasajeros()} pasajeros del Automovil {GetNroTransporte()}";
            throw new NotImplementedException();
        }
        //Implementacion del metodo Informar, de la interfaz ITransporte para comunicar la cantidad de pasajeros
        public string Informar()
        {
            return $"Automovil {GetNroTransporte()}: {GetPasajeros()} pasajeros.";
            throw new NotImplementedException();
        }
    }
}
