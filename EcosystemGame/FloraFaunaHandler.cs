﻿using System;
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
        // It will also remove any fish that is bellow zero health. 
        public void UpdateFloraAndFauna()
        {

        }

        public void AddFauna(string Type)
        {
            // Til gruppen: Jeg tænker lidt at den har kan tage en string som parameter, så den knap der tilføjer f. eks. trout,
            // kalder bare AddFaune("trout").
            // Ues ToLower, to ensure that the input is always lowercase.
            switch (Type.ToLower())
            {
                case "trout":
                    // Det nedstående er en test, for at tilføje en trout til listen. 1,1 er bare placeholder værdier.
                    HerbivorousFauna troutTest = new HerbivorousFauna("Troutname", 1, 1);
                    testList.Add(troutTest);
                    // For at se om den er tilføjet.
                    Console.WriteLine(testList[0].name);
                    break;
                case "xfish":
                    break;
                case "xflora":
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

        public class HerbivorousFauna : FloraFaunaItem
        {
            // Uses the base constructor from FloraFaunaItem. 
            public HerbivorousFauna(string Name, int MinimumOxygen, int RequiredNutrition) : base(Name, MinimumOxygen, RequiredNutrition)
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
            private CarnivorousFauna(string Name, int MinimumOxygen, int RequiredNutrition) : base(Name, MinimumOxygen, RequiredNutrition)
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
            private Flora(string Name, int MinimumOxygen, int RequiredNutrition) : base(Name, MinimumOxygen, RequiredNutrition)
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