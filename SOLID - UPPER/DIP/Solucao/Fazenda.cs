using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID___UPPER.DIP.Solucao
{
    public class Fazenda
    {
        private IAnimal animal;

        public Fazenda(IAnimal animal)
        {
            this.animal = animal;
        }

        public void ouvirAnimal()
        {
            animal.EmitirSom();
        }
    }
}
