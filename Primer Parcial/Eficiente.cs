using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial
{
    class Eficiente : IPolimorfismo2
    {

		public int Monto { get; set; }

		public Eficiente(int monto)
        {

			Monto = monto;

			Devolucion();

		}

		public void Devolucion()
		{

			int monto = Menu.monto;

			if (validarSiSePuedeDevolver(monto))
			{
				var papeletas = devolver(monto);

				Console.Write("\nEl cajero le devuelve ");

				if (papeletas.Item1 > 0)
				{

					Console.Write(papeletas.Item1 + " papeleta de 100");

				}

				if (papeletas.Item2 > 0)
				{

					Console.Write(papeletas.Item2 + " papeleta de 200 ");

				}

				if (papeletas.Item3 > 0)
				{

					Console.Write(papeletas.Item3 + " papeleta de 500 ");

				}

				if (papeletas.Item4 > 0)
				{

					Console.Write(papeletas.Item4 + " papeleta de 1000 ");

				}

				Console.WriteLine("");

			}

			else
			{

				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nError, debe ingresar una cantidad valida");
				Console.ResetColor();
				Console.ReadKey();

			}

		}

		public bool validarSiSePuedeDevolver(int monto)
		{

			if (monto % 100 == 0 || monto % 200 == 0 || monto % 500 == 0 || monto % 1000 == 0) return true;
			return false;
		}

		public (int, int, int, int) devolver(int monto)
		{
			int p100 = 0, p200 = 0, p500 = 0, p1000 = 0;
			while (monto > 0)
			{
				if (monto >= 1000)
				{
					p1000++;
					monto -= 1000;
				}
				else if (monto >= 500)
				{
					p500++;
					monto -= 500;
				}
				else if (monto >= 200)
				{
					p200++;
					monto -= 200;
				}
				else if (monto >= 100)
				{
					p100++;
					monto -= 100;
				}

			}
			return (p100, p200, p500, p1000);
		
		}
	
	}

}