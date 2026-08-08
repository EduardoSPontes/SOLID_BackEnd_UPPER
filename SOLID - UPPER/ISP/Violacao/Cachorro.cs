using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.ISP.Violacao
{
    public class Cachorro : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("AU AU AU!");
        }

        public void Voar()
        {
            Console.WriteLine("O cachorro não voa");
        }
    }
}
