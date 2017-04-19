using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public class FloraFaunaHandler
    {
        public void UpdateFloraAndFauna()
        {

        }

        public void AddFauna()
        {

        }

        public void AddFlora()
        {

        }

        public void RemoveFauna()
        {

        }

        public void RemoveFlora()
        {

        }

        #region Fauna
        private class CarnivorousFauna : FloraItem
        {
            // Here the base constructor from FloraItem is used, since this is shared for all flora and fauna.
            private CarnivorousFauna(string Name, int MinimumOxygen, int MinimumTemp, int MaximumTemp, int RequiredNutrition) : base(Name, MinimumOxygen, MinimumTemp, MaximumTemp, RequiredNutrition)
            {

            }

            private void Feed()
            {

            }

            private void Multiply()
            {

            }
        }

        // Works just like the Carnivorous fauna, but has a different method for feeding.
        private class HerbivorousFauna : FloraItem
        {
            private HerbivorousFauna(string Name, int MinimumOxygen, int MinimumTemp, int MaximumTemp, int RequiredNutrition) : base(Name, MinimumOxygen, MinimumTemp, MaximumTemp, RequiredNutrition)
            {

            }

            private void Feed()
            {

            }

            private void Multiply()
            {

            }
        }
        #endregion

        #region Flora
        private class Flora : FloraItem
        {
            private Flora(string Name, int MinimumOxygen, int MinimumTemp, int MaximumTemp, int RequiredNutrition) : base(Name, MinimumOxygen, MinimumTemp, MaximumTemp, RequiredNutrition)
            {

            }

            private void Feed()
            {

            }

            private void Multiply()
            {

            }
        }
        #endregion
    }
}