using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Troopers
{
    class Program
    {
        static void Main(string[] args)
        {

            //string retourQuestion = null;

            //Console.WriteLine("Combien de soldats voulez-vous créer ?");
            //retourQuestion = Console.ReadLine();

            ////int nbSoldats = int.Parse(retourQuestion);

            //int nbSoldats = -1;
            //if (int.TryParse(retourQuestion, out nbSoldats))
            //{
            //    Console.WriteLine("Vous avez saisi : " + nbSoldats);
            //}


            //Console.WriteLine("Votre nom de joueur s'il vous plaît ?");
            //string nom = Console.ReadLine();

            //Console.WriteLine("Votre date de naissance");
            //string dateEnChaine = Console.ReadLine();            //string retourQuestion = null;

            //Console.WriteLine("Combien de soldats voulez-vous créer ?");
            //retourQuestion = Console.ReadLine();

            ////int nbSoldats = int.Parse(retourQuestion);

            //int nbSoldats = -1;
            //if (int.TryParse(retourQuestion, out nbSoldats))
            //{
            //    Console.WriteLine("Vous avez saisi : " + nbSoldats);
            //}


            //Console.WriteLine("Votre nom de joueur s'il vous plaît ?");
            //string nom = Console.ReadLine();

            //Console.WriteLine("Votre date de naissance");
            string dateEnChaine = Console.ReadLine();

            DateTime date = DateTime.Now;
            if(DateTime.TryParse(dateEnChaine, out date))
            {
                date = date.AddDays(3);

                Console.WriteLine(date);

                date = date.AddYears(1);

                Console.WriteLine(date);
            }


            DateTime newDate = DateTime.Now;

            TimeSpan span = newDate.Subtract(date);

            Console.WriteLine("Temps d'exécution : " + span.Milliseconds);


            CultureInfo info = new CultureInfo("en-US");

            decimal version = 1500000.666M;
            double version2 = 1.5D;

            string dateAffiche = newDate.AddMonths(1).ToString("dd-MM-yyyy  yyy MMM dddd   MM-dd-yyyy");
            Console.WriteLine(dateAffiche);

            Console.WriteLine(version.ToString("###00.000#"));


            System.Threading.Thread.CurrentThread.CurrentCulture = info;

            dateAffiche = newDate.AddMonths(1).ToString("dd-MM-yyyy  yyy MMM dddd   MM-dd-yyyy");
            Console.WriteLine(dateAffiche);

            Console.WriteLine(version);



            Console.ReadLine();
        }
    }
}
