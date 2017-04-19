using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public interface IFloraFauna
    {
        string name { get; }
        int health { get; }
        int minimumOxygen { get; }
        int minimumTemp { get; }
        int maximumTemp { get; }
        int growthLevel { get; }
        int requiredNutrition { get; }
    }
}
