using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generador
{
	public class Generadordenombre
	{
		public string[] prefijo =
			{ "Lil", "Pib",
				"El", "La" };


		public string[] nombre =
			{ "Yung", "Enano",
				"Zorra", "Bad" };



		public string[] sufijo =
			{ "Ft. NecryTalkie", "Ft. Caifanes",
			"Ft. Bad Bunny", "Ft. Rosalia" };



		public void generar(int dia, int mes, int anio)
		{
			Console.WriteLine(prefijo[mes - 1] + "" + nombre[dia - 1] + sufijo[anio - 1]);
			return;

		}
	}
}
