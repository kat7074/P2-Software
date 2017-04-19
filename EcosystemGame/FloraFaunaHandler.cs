using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public class FloraFaunaHandler
    {

        List<FloraItem> testList = new List<FloraItem>();

        public void UpdateFloraAndFauna()
        {

        }

        public void AddFauna(string Type)
        {
            switch (Type)
            {
                case "Trout":
                    HerbivorousFauna troutTest = new HerbivorousFauna("Troutname", 1, 1, 1, 1);
                    testList.Add(troutTest);
                    Console.WriteLine(testList[0].name);
                    break;
                case "XFish":
                    break;
                case "XFlora":
                    break;
                default:
                    break;
            }
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

            // For updating the Fauna stats, after each round. 
            private void Update()
            {

            }
        }

        // Works just like the Carnivorous fauna, but has a different method for feeding.
        public class HerbivorousFauna : FloraItem
        {
            public HerbivorousFauna(string Name, int MinimumOxygen, int MinimumTemp, int MaximumTemp, int RequiredNutrition) : base(Name, MinimumOxygen, MinimumTemp, MaximumTemp, RequiredNutrition)
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