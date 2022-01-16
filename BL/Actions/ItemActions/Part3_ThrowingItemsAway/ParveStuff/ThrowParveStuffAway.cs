using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.ParveStuff
{
    class ThrowParveStuffAway
    {
        // Properties
        private Fridge Fridge;
        public List<Shelf> originalShelfs;

        // Constructor
        public ThrowParveStuffAway(Fridge Fridge)
        {
            this.Fridge = Fridge;

            GetRidOfRequieredFood throwParveStuff = new GetRidOfRequieredFood(this.Fridge, "Parve", 1);
            this.originalShelfs = throwParveStuff.originalShelfs;
            Console.WriteLine("Parve Stuff Thrown Away");
        }
    }
}
