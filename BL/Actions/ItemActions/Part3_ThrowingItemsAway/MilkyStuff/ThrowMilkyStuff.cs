using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.MilkyStuff
{
    class ThrowMilkyStuff
    {
        // Properties
        private Fridge Fridge;
        public List<Shelf> originalShelfs;

        // Constructor
        public ThrowMilkyStuff(Fridge Fridge)
        {
            this.Fridge = Fridge;

            GetRidOfRequieredFood throwMilkyItems = new GetRidOfRequieredFood(this.Fridge, "Milky", 3);
            this.originalShelfs = throwMilkyItems.originalShelfs;
            Console.WriteLine("Milky Stuff Thrown Away");
        }
    }
}
