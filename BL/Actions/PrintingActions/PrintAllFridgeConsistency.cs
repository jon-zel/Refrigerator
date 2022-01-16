using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions
{
    class PrintAllFridgeConsistency
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public PrintAllFridgeConsistency(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine(Fridge.ToString());
        }
    }
}
