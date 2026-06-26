using System;
using System.Collections.Generic;
using System.Text;

namespace PryEstacionamiento
{
    public abstract class Vehiculo
    {
        public int HorasEstancia { get; set; }

        public abstract decimal CalcularTarifa();
    }
}
