using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public class FloraItem : IFloraFauna
    {
        public FloraItem(string Name, int Health, int MinimumOxygen, int MinimumTemp, int MaximumTemp)
        {
            this.name = Name;
            this.health = Health;
            this.minimumOxygen = MinimumOxygen;
            this.minimumTemp = MinimumTemp;
            this.maximumTemp = MaximumTemp;
            this.growthLevel = 0;
        }

        public string name { get; }
        public int health { get; }
        public int minimumOxygen { get; }
        public int minimumTemp { get; }
        public int maximumTemp { get; }
        public int growthLevel { get; }
    }
}