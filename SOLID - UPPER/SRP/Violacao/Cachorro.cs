using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_UPPER.DIP.Violacao
{
    public class Cachorro
    {
        public void EmitirSom()
        {
            Console.WriteLine("AU AU AU");
        }
        public void Comer()
        {
            Console.WriteLine("O cachorro está comendo.");
        }

    }
}
