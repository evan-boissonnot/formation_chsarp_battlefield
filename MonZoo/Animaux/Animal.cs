using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonZoo.Animaux
{
    public class Animal
    {
        public string Tete;
        public string Queue;
        public int NbPattes;
        public int NbOreilles;

        public Sexe Sexe;
        public DateTime DateDeNaissance;
        public string Nom;


        public virtual void Dormir()
        {
            Console.WriteLine(this.Nom + ", je dors, mais je ne sais pas comment");
        }

        public virtual bool Manger()
        {
            return true;
        }
    }
}
