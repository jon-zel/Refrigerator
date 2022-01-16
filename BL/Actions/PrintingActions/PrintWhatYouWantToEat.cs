using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintWhatYouWantToEat
    {
        // Properties
        private Fridge Fridge;
        private List<string> possibleFoodTypes;
        private List<string> possibleFoodOrDrinkInputs;


        // Constructor
        public PrintWhatYouWantToEat(Fridge Fridge, List<string> possibleFoodTypes, List<string> possibleFoodOrDrinkInputs)
        {
            this.Fridge = Fridge;
            this.possibleFoodTypes = possibleFoodTypes;
            this.possibleFoodOrDrinkInputs = possibleFoodOrDrinkInputs;

            Console.WriteLine("What Do You Want To Eat?\nFood Or Drink?");
            string FoodOrDrink = Console.ReadLine();
            Console.WriteLine("Food Type?");
            string FoodType = Console.ReadLine();

            if (this.ValidateFoodOrDrinkInput(FoodOrDrink) && this.ValidateFoodTypeInput(FoodType))
            {
                WhatDoYouWantToEat wannaEat = new WhatDoYouWantToEat(this.Fridge, FoodOrDrink, FoodType);
                Console.WriteLine(wannaEat.PrintProperList());
            }
            else
                Console.WriteLine("Inputs Are Wrong. No Such Possible In The System.");
        }

        // Methods
        public bool ValidateFoodTypeInput(string FoodType)
        {
            if (this.possibleFoodTypes != null)
            {
                foreach (string s in this.possibleFoodTypes)
                    if (s.Equals(FoodType))
                        return true;
            }

            Console.WriteLine("Possible Food Types List Is Null.");

            return false;
        }

        public bool ValidateFoodOrDrinkInput(string FoodOrDrink)
        {
             if (this.possibleFoodOrDrinkInputs != null)
             {
                foreach (string s in this.possibleFoodOrDrinkInputs)
                    if (s.Equals(FoodOrDrink))
                        return true;
            }

            Console.WriteLine("Possible Food Or Drink Inputs List Is Null.");
            
            return false;
        }
    }
}
