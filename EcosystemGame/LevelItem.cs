using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    // Holds all the different LevelItems. 
    public class LevelItems
    {
        // The first level of the game.
        public class LevelItemOne : ILevel
        {
            public LevelItemOne()
            {
                
            }
            public string gameObjective { get { return "Add 5 Flora and Fauna to the system"; } }
            public int startNutrients { get { return 1; } }
            // 1 er Januar.
            public int startSeason { get { return 1; } }

            // A list of lists of Fauna or FloraItems, that the level starts with. 
            public List<List<FloraItem>> startFauna { get { return new List<List<FloraItem>>(); } }
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
}