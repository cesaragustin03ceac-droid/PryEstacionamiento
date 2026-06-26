using System;
using System.Collections.Generic;
using System.Text;

namespace PryEstacionamiento.Vehiculo
{
    public class Automovil:vehiculo
    {
        public string Placa { get; set; }

        public override decimal CalcularTarifa()
        {
            return HorasEstancia * 30.00m;
        }

    }
}
