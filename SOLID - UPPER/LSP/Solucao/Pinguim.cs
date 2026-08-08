using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.LSP.Solucao
{
    public class Pinguim : Animal
    {
        public override void EmitirSom()
        {
            Console.WriteLine("Cuá-Cuá");
        }
    }
}
