using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial
{
    public class _200y1000 : IPolimorfismo1
    {

		public int Monto { get; set; }

		public _200y1000(int monto)
		{

			monto = Monto;

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

					Console.Write(papeletas.Item1 + " papeleta de 200 ");

				}

				if (papeletas.Item2 > 0)
				{

					Console.WriteLine(papeletas.Item2 + " papeleta de 1000 ");

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

			if (monto % 200 == 0 || monto % 1000 == 0) return true;
			return false;
		}

		public (int, int) devolver(int monto)
		{
			int p200 = 0, p1000 = 0;
			while (monto > 0)
			{
				if (monto >= 1000)
				{
					p1000++;
					monto -= 1000;
				}

				else if (monto >= 200)
				{
					p200++;
					monto -= 200;
				}

			}
			return (p200, p1000);
		}

	}

}