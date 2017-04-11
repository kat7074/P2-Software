using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public abstract class LevelItemBase
    {
        //Start variables for the level
        public string gameObjective;
        public int startNutrients;
        public int startSeason;

        //Lists containing a list of the differet species of flora and fauna the level starts with
        public List<List<FaunaItem>> startFauna;
        public List<List<FloraItem>> startFlora; 
    }
}
