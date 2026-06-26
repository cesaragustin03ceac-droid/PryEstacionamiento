using System;
using System.Collections.Generic;
using System.Text;

namespace PryEstacionamiento
{
    public abstract class vehiculo
    {
        public int HorasEstancia { get; set; }

        public abstract decimal CalcularTarifa();
    }
}
