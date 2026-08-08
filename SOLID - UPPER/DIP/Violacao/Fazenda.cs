using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.DIP.Violacao
{
    public class Fazenda
    {
        private Cachorro cachorro = new Cachorro();

        public void  OuvirAnimal()
        {
            cachorro.EmitirSom();
        }
    }
}
