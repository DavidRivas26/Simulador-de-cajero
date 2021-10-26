using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial
{
    public class Menu
    {

        public void MenuPrincipal()
        {

            try
            {

                Console.Clear();

                Console.WriteLine("1) Modo de dispensación.\n2) Retirar dinero.\n3) Salir.\n");
                Console.Write("Elija una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case (int)Menu1.dispensacion:

                        MenuDispensacion();

                        break;

                    case (int)Menu1.retirar:



                        break;

                    case (int)Menu1.salir:

                        Console.WriteLine("\nGracias por usar este software");

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError, ingrese una opcion valida");
                        Console.ResetColor();
                        Console.ReadKey();
                        MenuPrincipal();

                        break;

                }

            }

            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError, ingrese una opcion valida");
                Console.ResetColor();
                Console.ReadKey();
                MenuPrincipal();

            }

        }

        public void MenuDispensacion()
        {

            try
            {

                Console.Clear();

                Console.WriteLine("1) 200 y 1000.\n2) 100 y 500.\n3) 100, 200, 500, 1000 (Eficiente).\n4) Volver.\n");
                Console.Write("Elija una opcion: ");
                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {

                    case (int)Menu2.no_eficiente200y1000:



                        break;

                    case (int)Menu2.no_eficiente100y500:



                        break;

                    case (int)Menu2.eficiente:



                        break;

                    case (int)Menu2.volver:

                        MenuPrincipal();

                        break;

                    default:

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nError, ingrese una opcion valida");
                        Console.ResetColor();
                        Console.ReadKey();
                        MenuDispensacion();

                        break;

                }

            }

            catch (Exception e)
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nError, ingrese una opcion valida");
                Console.ResetColor();
                Console.ReadKey();
                MenuDispensacion();

            }

        }

    }

}