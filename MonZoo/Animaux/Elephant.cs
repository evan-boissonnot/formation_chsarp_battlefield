using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonZoo.Animaux
{
    class Elephant : Animal
    {
        public string Trompe;       
        public int NbDefences;

        public override void Dormir()
        {
            //base.Dormir();
            Console.WriteLine(this.Nom + ", je dors comme un éléphant");
        }


        public override bool Manger()
        {
            return false;
        }
    }
}
