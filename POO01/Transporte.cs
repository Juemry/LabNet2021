using System;
using System.Collections.Generic;
using System.Text;

namespace POO01
{
	public abstract class Transporte
	{
		//Declaración de variables privadas solo con Getters para poder obtener el valor
		private int pasajeros { get; }

		private int nroTransporte { get; }

		//Definición del constructor
		public Transporte(int pasajeros, int nroTransporte)
		{
			this.pasajeros = pasajeros;
			this.nroTransporte = nroTransporte;
		}

		//Metodos abstractos pedidos por la consigna
	
		public abstract string Avanzar();

		public abstract string Detenerse();

		//Metodos Get para obtener los valores de las variables privadas
        public int GetPasajeros()
		{
			return pasajeros;
		}

		public int GetNroTransporte()
		{
			return nroTransporte;
		}
    }
}
