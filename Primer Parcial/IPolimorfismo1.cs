using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Parcial
{
    public interface IPolimorfismo1
    {

        public bool validarSiSePuedeDevolver(int monto);

        public (int, int) devolver(int monto);

        public void Devolucion();

    }
}
