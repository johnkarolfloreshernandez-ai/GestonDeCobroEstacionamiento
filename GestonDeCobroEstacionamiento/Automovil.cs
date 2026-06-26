using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestonDeCobroEstacionamiento 
{
    public class Automovil : Vehiculo
    {
        public string Placa { get; set; }

        public Automovil(int horas, string placa) : base(horas)
        {
            Placa = placa;
        }

        public override double CalcularTarifa()
        {
            return HorasEstancia * 30;
        }
    }




}

