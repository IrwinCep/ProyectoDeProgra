using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoCarreras2
	{
	public class Auto
	{
		public string modelo;
		public float peso;
		public int velocidad;
		public float gasolina;

		public void PonerGas(float cantidad)
		{
			gasolina = gasolina + cantidad;
			Console.WriteLine(modelo +
				" tiene " + gasolina + "+1 de gas");
		}

		public void Acelerar()
		{
			gasolina = gasolina - velocidad / 10;
			if (gasolina <= 0)
			{
				Console.WriteLine(
					modelo + "El coche se quedo sin gas");
			}
		}

		public void Frenar()
		{
			velocidad = 0;
			Console.WriteLine(
				modelo + "Su velocidad ahora es "
				+ velocidad);
		}
		public void Arrancar()
		{
			if (gasolina > 0)
			{
				//Consume 0.01 litros de gas
				//cada que arranca
				gasolina = gasolina - 0.01f;
				Console.WriteLine(
					"Arrancando " + modelo + ", le quedan" +
					gasolina + "1 de gas.");
			}
			else
			{
				Console.WriteLine(
					"No se puede arrancar"
					+ modelo + "sin gasolina.");
			}
		}
	}

}
