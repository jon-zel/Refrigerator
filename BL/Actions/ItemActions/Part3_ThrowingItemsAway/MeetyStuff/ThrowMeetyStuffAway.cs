using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.MeetyStuff
{
    class ThrowMeetyStuffAway
    {
        // Properties
        private Fridge Fridge;
        public List<Shelf> originalShelfs;

        // Constructor
        public ThrowMeetyStuffAway(Fridge Fridge)
        {
            this.Fridge = Fridge;

            GetRidOfRequieredFood throwMeetyStuff = new GetRidOfRequieredFood(this.Fridge, "Meety", 7);
            this.originalShelfs = throwMeetyStuff.originalShelfs;
            Console.WriteLine("Meety Stuff Thrown Away");
        }
    }
}
