using SOLID_UPPER.OCP.Violacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.LSP.Violacao
{
    public  class Pinguim : Animal
    {
        public override void Voar()
        {
            throw new Exception("Pinguins não sabem voar");
        }
    }
}
