using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BattleFieldReboot.Types;

namespace BattleFieldReboot
{


    class Program
    {
        //const int CLEF_SOLDAT = 1;
        //const int CLEF_CAPORAL = 2;
        //const int CLEF_GENERAL = 3;

        static void Main(string[] args)
        {
            GradeArmee choixU = AfficherEtControlerEtRenvoieSaisie();
            int pointsDeVie = MettreAJourEtRecupererPointsDeVie(choixU);
            AfficherPointsDeVie(pointsDeVie);
        }

        static GradeArmee AfficherEtControlerEtRenvoieSaisie()
        {
            bool isErreur = true;

            GradeArmee choix = GradeArmee.Soldat;
            while (isErreur)
            {
                AfficherMenu();
                choix = RecupererChoixUtilisateur();

                isErreur = !Enum.IsDefined(typeof(GradeArmee), choix);

                AfficherInfoErreur(isErreur);
            }

            return choix;
        }

        static void AfficherPointsDeVie(int points)
        {
            Console.WriteLine("Tes points de vie sont à " + points + "xp");
        }

        static void AfficherInfoErreur(bool isErreur)
        {
            if (isErreur)
            {
                Console.ForegroundColor = ConsoleColor.Red;

                Console.WriteLine("Tu t'es trompé !");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
            }
        }

        static void AfficherMenu()
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("====== MENU =======");

            AfficheListeGradeMenu();
        }

        static void AfficheListeGradeMenu()
        {
            string[] grades = Enum.GetNames(typeof(GradeArmee));

            for (int i = 0; i < grades.Length; i++)
            {
                GradeArmee gradeActuel = (GradeArmee) Enum.Parse(typeof(GradeArmee), grades[i]);

                Console.WriteLine((int)gradeActuel + ". " + grades[i]);
            }
        }

        static GradeArmee RecupererChoixUtilisateur()
        {
            int choix = 0;

            string valeurSaisie = Console.ReadLine();
            int.TryParse(valeurSaisie, out choix);

            return (GradeArmee)choix;
        }

        static int MettreAJourEtRecupererPointsDeVie(GradeArmee choixUtilisateur)
        {
            int points = 0;

            switch (choixUtilisateur)
            {
                case GradeArmee.Soldat:
                    {
                        points = 50;
                    }
                    break;

                case GradeArmee.Caporal:
                    {
                        points = 100;
                    }
                    break;

                case GradeArmee.General:
                    {
                        points = 150;
                    }
                    break;

                default:
                    {
                        points = 50;
                    }
                    break;
            }

            return points;
        }

    }
}
