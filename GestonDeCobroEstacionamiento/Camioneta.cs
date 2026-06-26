using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestonDeCobroEstacionamiento
{
    public class Camioneta : Vehiculo
    {
        public int NumeroEjes { get; set; }

        public Camioneta(int horas, int numeroEjes) : base(horas)
        {
            NumeroEjes = numeroEjes;
        }

        public override double CalcularTarifa()
        {
            return Horas * 45;
        }

    }
}
