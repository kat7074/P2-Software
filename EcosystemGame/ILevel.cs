using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public interface ILevel
    {
        // Start variables for the level.
        string gameObjective { get; }
        int startNutrients { get; }
        int startSeason { get; }
        int startOxygen { get; }
        

        // Lists containing a list of the differet species of flora and fauna the level starts with.
        List<List<FloraFaunaItem>> startFauna { get; }
        List<List<FloraFaunaItem>> startFlora { get; }

        // Method to check if the objective has been completed.
        bool CheckObjective();
    }
}
/* tror at denne metode virker til range
        [Range(1,14)]
        public int size { get; set; }

        
        [MinValue(1), MaxValue(14)]
        public int size { get; set; }
*/
