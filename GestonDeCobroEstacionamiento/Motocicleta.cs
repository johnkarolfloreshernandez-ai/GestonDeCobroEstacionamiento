using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestonDeCobroEstacionamiento
{
    class Motocicleta : Veiculo
    {
        public int Cilindrada { get; set; }
        public Motocicleta(int horas, int cilindrada) : base(horas)
        {
            Cilindrada = cilindrada;
        }

        public override double CalcularTrifa()
        {
            return Horas * 15;
        }
    }
}
