using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    //The base class that LevelItem will inherit from
    public class LevelItem : ILevel
    {
        public string gameObjective { get { return "Add 5 Flora and Fauna to the system"; } }
        public int startNutrients { get { return 1; } }
        public int startSeason { get { return 1; } }

        public List<List<FaunaItem>> startFauna { get { return new List<List<FaunaItem>>(); } }
        public List<List<FloraItem>> startFlora { get { return new List<List<FloraItem>>(); } }

        public bool CheckObjective()
        {
            // Checks if the objective is complete. Replace (true) with the correct parameters for the objective. 
            if (true)
            {
                return true;
            }
            else
                return false;
        }
    }
}
