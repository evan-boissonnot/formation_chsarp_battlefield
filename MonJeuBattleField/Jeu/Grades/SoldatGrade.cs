using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleFieldReboot.Jeu.Grades
{
    class SoldatGrade : Grade
    {
        public override int ObtenirPointsDeVieParDefaut()
        {
            return 50;
        }

        public override List<Arme> ObtenirArmesParDefaut()
        {
            List<Arme> maList = new List<Arme>();

            maList.Add(new Armes.FamasArme());

            return maList;
        }
    }
}
