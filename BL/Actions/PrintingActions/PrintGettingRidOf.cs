using Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.MeetyStuff;
using Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.MilkyStuff;
using Refrigirator.BL.Actions.ItemActions.Part3_ThrowingItemsAway.ParveStuff;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintGettingRidOf
    {
        // Properties
        private Fridge Fridge;
        private List<Shelf> originalShelfs;

        // Constructor
        public PrintGettingRidOf(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("Wanna Go Shopping?");

            if (this.Fridge.EmptySpaceInAllFridge() >= 20)
                Console.WriteLine("You Can Go Shopping");
            else
            {

                if (!this.IsCleaningFridgeEnough())
                    if (!this.IsMilkyEnough())
                        if (!this.IsMeetyEnough())
                            if (!this.IsParveEnough())
                            {
                                Fridge.Shelfs = this.originalShelfs;
                                Console.WriteLine("It's Not The Right Time To Go Shopping Now!");
                            }


            }
        }

        // Methods
        public bool IsCleaningFridgeEnough()
        {
            Console.WriteLine("Refrigirator Cleaning:");
            FridgeCleaning cleanFridge = new FridgeCleaning(Fridge);
            cleanFridge.Clean();

            if (Fridge.EmptySpaceInAllFridge() >= 20)
            {
                Console.WriteLine("You Can Go Shopping");

                return true;
            }

            return false;
        }

        public bool IsParveEnough()
        {
            ThrowParveStuffAway throwParveStuff = new ThrowParveStuffAway(this.Fridge);

            if (Fridge.EmptySpaceInAllFridge() >= 20)
            {
                Console.WriteLine("You Can Go Shopping");

                return true;
            }

            return false;
        }

        public bool IsMeetyEnough()
        {
            ThrowMeetyStuffAway throwMeetyStuff = new ThrowMeetyStuffAway(this.Fridge);

            if (Fridge.EmptySpaceInAllFridge() >= 20)
            {
                Console.WriteLine("You Can Go Shopping");

                return true;
            }

            return false;
        }

        public bool IsMilkyEnough()
        {
            ThrowMilkyStuff throwMilkyStuff = new ThrowMilkyStuff(this.Fridge);
            this.originalShelfs = throwMilkyStuff.originalShelfs;

            if (this.Fridge.EmptySpaceInAllFridge() >= 20)
            {
                Console.WriteLine("You Can Go Shopping");
                
                return true;
            }

            return false;
        }
    }
}
