using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonZoo.Animaux;

namespace MonZoo
{
    class Program
    {
        static void Main(string[] args)
        {
            string maChaine = "";

            Animal monPremierElephant = new Elephant();
            Elephant monSecondElephant = new Elephant();

            


            monPremierElephant.Nom = "Dumbo";
            monPremierElephant.Sexe = Sexe.Male;

            monSecondElephant.Nom = "Djumbo";
            monSecondElephant.Sexe = Sexe.Femelle;


            monPremierElephant.DateDeNaissance = new DateTime(1982, 03, 04);
            monSecondElephant.DateDeNaissance = new DateTime(1962, 05, 06);


            monPremierElephant.Dormir();
            monSecondElephant.Dormir();


            Animal monTigre = new Tigre
            {
                Nom = "Tigrou",
                DateDeNaissance = new DateTime(1970, 6, 1),
                Sexe = Sexe.Male
            };

            monTigre.Dormir();


        }
    }
}
