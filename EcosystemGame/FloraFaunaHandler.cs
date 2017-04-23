using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcosystemGame
{
    public class FloraFaunaHandler
    {
        // Til gruppe: Liste over alle fisk i søen. Skal nok hede noget andet end testList.
        public List<FloraFaunaItem> testList = new List<FloraFaunaItem>();

        // Checks the list of FloraItems, and executes the feed and multiply methods for each FloraItem, if the parameters are reached
        // It will also remove any fish that is below zero health. 
        public void UpdateFloraAndFauna()
        {
            foreach (var item in testList)
            {
                if (item.health < 0)
                {
                    testList.Remove(item);
                }
                else
                {
                    
                }
            }
        }

        public void AddFauna(string Type)
        {
            // Til gruppen: Jeg tænker lidt at den har kan tage en string som parameter, så den knap der tilføjer f. eks. trout,
            // kalder bare AddFaune("trout").
            // Ues ToLower, to ensure that the input is always lowercase.
            switch (Type.ToLower())
            {
                case "eel":
                    // Er den her herbivore eller carnivore? o.o'
                    break;
                case "pike":
                    // CarnivorousFauna testPike = new CarnivorousFauna("Pike", 1, 1, 1, 1, 1);
                    // testList.Add(testPike);
                    // Console.WriteLine(testList[0].name);
                    break;
                case "perch":
                    // Kan kategoriseres som både herbivore og carnivore? :o
                    break;
                case "trout":
                    // Det nedstående er en test, for at tilføje en trout til listen. 1,1 er bare placeholder værdier.
                    HerbivorousFauna testTrout = new HerbivorousFauna("Trout", 1, 1, 1, 1, 1);
                    testList.Add(testTrout);
                    // For at se om den er tilføjet.
                    Console.WriteLine(testList[0].name);
                    break;
                default:
                    break;
            }
        }

        public void AddFlora(string Type)
        {
            switch(Type.ToLower())
            {
                case "quillwort":
                    break;
                case "shoreweed":
                    break;
                case "t-stonewort":
                    break;
                case "w-stonewort":
                    break;
            }
        }

        public void RemoveFauna()
        {

        }

        public void RemoveFlora()
        {

        }

        public class HerbivorousFauna : FloraFaunaItem
        {
            // Uses the base constructor from FloraFaunaItem. 
            public HerbivorousFauna(string Name, int MinimumOxygen, int RequiredNutrition, int releasedOxygen, int maxHealth, int reproduceLevel) : base(Name, MinimumOxygen, RequiredNutrition, releasedOxygen, maxHealth, reproduceLevel)
            {

            }

            private void Feed()
            {

            }

            private void Multiply()
            {

            }
        }

        // Not currently in use, the focus is on herbivorous fauna to start with. 
        private class CarnivorousFauna : FloraFaunaItem
        {
            // Here the base constructor from FloraItem is used, since this is shared for all flora and fauna.
            private CarnivorousFauna(string Name, int MinimumOxygen, int RequiredNutrition, int releasedOxygen, int maxHealth, int reproduceLevel) : base(Name, MinimumOxygen, RequiredNutrition, releasedOxygen, maxHealth, reproduceLevel)
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

        private class Flora : FloraFaunaItem
        {
            private Flora(string Name, int MinimumOxygen, int RequiredNutrition, int releasedOxygen, int maxHealth, int reproduceLevel) : base(Name, MinimumOxygen, RequiredNutrition, releasedOxygen, maxHealth, reproduceLevel)
            {

            }

            private void Feed()
            {

            }

            private void Multiply()
            {

            }
        }
    }
}