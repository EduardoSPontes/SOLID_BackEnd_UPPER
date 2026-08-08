using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_UPPER.OCP.Violacao
{
    public  class Animal
    {
        public void EmitirSom(string animal)
        {
            if (animal == "Cachorro")
                Console.WriteLine("AU AU!");
            else if (animal == "Gato")
                Console.WriteLine("Miauuuuu Miauu!");
        }
    }
}
