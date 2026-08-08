using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.ISP.Solucao
{
    public class Cachorro : IEmitirSom
    {
        public void EmitirSom()
        {
            Console.WriteLine("AU AU AU!");
        }
    }
}
