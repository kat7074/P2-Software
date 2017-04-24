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
        public FloraFaunaItem(string Name, int MinimumOxygen, int RequiredNutrition,int releasedOxygen, int maxHealth, int reproduceLevel)
        {
            this.name = Name;
            this.health = 100;
            this.maxHealth = maxHealth; 
            this.minimumOxygen = MinimumOxygen;
            this.reproduceLevel = reproduceLevel;
            this.requiredNutrition = RequiredNutrition;
            this.releasedOxygen = releasedOxygen;
        }

        public virtual string name { get; }
        public virtual int health { get; }
        public virtual int minimumOxygen { get; }
        public virtual int reproduceLevel { get; }
        public virtual int requiredNutrition { get; }
        public virtual int releasedOxygen { get; }
        public virtual int maxHealth { get; }

        public abstract void Feed();
        public abstract void Multiply();
    }
}