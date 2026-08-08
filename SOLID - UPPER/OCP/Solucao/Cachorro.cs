using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_UPPER.OCP.Solucao
{
    public  class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("AU AU AU!");
        }
    }
}
