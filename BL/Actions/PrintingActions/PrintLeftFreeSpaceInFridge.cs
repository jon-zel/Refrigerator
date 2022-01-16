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
                Console.WriteLine(this.Fridge.EmptySpaceInAllFridge() + "cm");
            else
                Console.WriteLine("Fridge Was Null.");
        }
    }
}
