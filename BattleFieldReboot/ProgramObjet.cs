using BattleFieldReboot.Jeu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFieldReboot
{
    class ProgramObjet
    {
        static void Main(string[] args)
        {
            MoteurDuJeu moteur = new MoteurDuJeu();
            moteur.Initialiser();
        }
    }
}
