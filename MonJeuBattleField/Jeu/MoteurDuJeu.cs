using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFieldReboot.Jeu
{
    public class MoteurDuJeu
    {
        public Joueur MonJoueur = null;

        //public Joueur MonJoueur
        //{
        //    get
        //    {
        //        return this._joueur;
        //    }
        //    set
        //    {
        //        this._joueur = value;
        //    }
        //}

        public void Initialiser()
        {
            this.MonJoueur = new Joueur();

            Console.WriteLine("Le pseudo du joueur ?");
            this.MonJoueur.Nom = Console.ReadLine();

            Console.WriteLine("Le nom de l'avatar ?");
            this.MonJoueur.MonAvatar = new Avatar();
            this.MonJoueur.MonAvatar.Pseudo = Console.ReadLine();

            Console.WriteLine("Choix du grade");
            string choixGrade = Console.ReadLine();

            Grade grade = null;
            switch (choixGrade)
            {
                case "1":
                    {
                        grade = new Grades.SoldatGrade();
                    }
                    break;

                case "2":
                    {
                        grade = new Grades.CaporalGrade();
                    }
                    break;

                case "3":
                    {
                        grade = new Grades.GeneralGrade();
                    }
                    break;

                default:
                    break;
            }

            this.MonJoueur.MonAvatar.MonGradeCourant = grade;
            this.MonJoueur.MonAvatar.PointsDeVie = grade.ObtenirPointsDeVieParDefaut();

            foreach (var arme in grade.ObtenirArmesParDefaut())
            {
                Console.WriteLine(arme);
            }


        }
    }
}
