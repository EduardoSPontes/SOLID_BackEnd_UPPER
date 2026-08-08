using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.LSP.Violacao
{
    public class Animal
    {
        public virtual void Voar()
        {
            Console.WriteLine("O animal está voando!");
        }
    }
}
