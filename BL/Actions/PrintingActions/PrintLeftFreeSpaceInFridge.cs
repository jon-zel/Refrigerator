using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions
{
    class PrintLeftFreeSpaceInFridge
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public PrintLeftFreeSpaceInFridge(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("Empty Space In The Fridge:");
            if (this.Fridge != null)
            {
                if (this.Fridge.EmptySpaceInAllFridge() < 0)
                    Console.WriteLine("You need to re-organize the frigde, because there isn't enough space, and items are laying on one another.");
                else
                    Console.WriteLine(this.Fridge.EmptySpaceInAllFridge() + "cm");
            }
            else
                Console.WriteLine("Fridge Was Null.");
        }
    }
}
