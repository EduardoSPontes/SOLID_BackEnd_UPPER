using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_UPPER.OCP.Solucao
{
    public class Gato : IAnimal
    {
        public void EmitirSom()
        {
            Console.WriteLine("MiAUUUUUU MIAUUU!");
        }
    }
}
