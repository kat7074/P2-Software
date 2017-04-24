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
        int maxHealth { get; }
        int minimumOxygen { get; }
        int reproduceLevel { get; }
        int requiredNutrition { get; }
        int releasedOxygen { get; }
    }
}