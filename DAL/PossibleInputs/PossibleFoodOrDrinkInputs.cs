using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.DAL
{
    class PossibleFoodOrDrinkInputs
    {
        // Properties
        public List<string> possibleInputs { get; set; }

        // Constructor
        public PossibleFoodOrDrinkInputs()
        {
            this.possibleInputs = new List<string>();
            this.possibleInputs.Add("Food");
            this.possibleInputs.Add("Drink");
        }
    }
}
