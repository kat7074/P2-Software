using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public abstract class FloraFaunaItem : IFloraFauna
    {
        // The constructor for when a new FloraItem is created.
        public FloraFaunaItem(string Name, int MinimumOxygen, int RequiredNutrition)
        {
            this.name = Name;
            this.health = 100;
            this.minimumOxygen = MinimumOxygen;
            this.growthLevel = 0;
            this.requiredNutrition = RequiredNutrition;
        }

        public virtual string name { get; }
        public virtual int health { get; }
        public virtual int minimumOxygen { get; }
        public virtual int growthLevel { get; }
        public virtual int requiredNutrition { get; }
    }
}