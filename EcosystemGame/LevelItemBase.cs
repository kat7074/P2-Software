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

        // Lists containing a list of the differet species of flora and fauna the level starts with.
        List<List<FaunaItem>> startFauna { get; }
        List<List<FloraItem>> startFlora { get; }

        // Method to check if the objective has been completed.
        bool CheckObjective();
    }
}