using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions
{
    class TakeOutAnItem
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public TakeOutAnItem(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("What Item Do You Want To Get?");
            string item = Console.ReadLine();
            TakeItemOut chosenItem = new TakeItemOut(item, this.Fridge);
            if (chosenItem.FindAndTakeOut())
            {
                Console.WriteLine("The Item That's Comming Out: " + chosenItem.FoundItem.ToString());
                Console.WriteLine(this.Fridge.ToString());
            }
        }
    }
}
