using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestonDeCobroEstacionamiento
{
        public class Motocicleta : Vehiculo
    {
        public int Cilindrada { get; set; }
        public Motocicleta(int horas, int cilindrada) : base(horas)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularTarifa()
        {
            return Horas * 15;
        }
    }
}
