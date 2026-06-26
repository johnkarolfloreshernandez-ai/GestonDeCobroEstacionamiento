using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestonDeCobroEstacionamiento
{
    public abstract class Vehiculo
    {
        public int Horas { get; set; }

        public Vehiculo(int horas)
        {
            Horas = horas;
        }

        public abstract double CalcularTarifa();
    }
}
