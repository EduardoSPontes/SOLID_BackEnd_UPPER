using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.LSP.Solucao
{
    public class Animal
    {
        public virtual void EmitirSom()
        {
            Console.WriteLine("Som de animal");
        }
    }
}
