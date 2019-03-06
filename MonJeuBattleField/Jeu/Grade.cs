using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFieldReboot.Jeu
{
    public class Grade
    {
        public virtual int ObtenirPointsDeVieParDefaut()
        {
            return 10;
        }

        public virtual List<Arme> ObtenirArmesParDefaut()
        {
            return new List<Arme>();
        }
    }
}
