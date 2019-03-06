using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFieldReboot.Jeu.Grades
{
    class CaporalGrade : Grade
    {
        public override int ObtenirPointsDeVieParDefaut()
        {
            return 100;
        }

        public override List<Arme> ObtenirArmesParDefaut()
        {
            List<Arme> maList = new List<Arme>();

            maList.Add(new Armes.SniperArme());
            maList.Add(new Armes.UziArme());

            return maList;
        }
    }
}
