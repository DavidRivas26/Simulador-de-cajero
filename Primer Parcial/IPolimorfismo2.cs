using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial
{
    interface IPolimorfismo2
    {

        public bool validarSiSePuedeDevolver(int monto);

        public (int, int, int, int) devolver(int monto);

        public void Devolucion();

    }
}
