using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class OrganizedShelfsInOrder
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public OrganizedShelfsInOrder(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("Shelfs Orgnized: ");
            AllShelfsByEmptySpace shelfsOrganazation = new AllShelfsByEmptySpace(this.Fridge);
            shelfsOrganazation.PrintList();
        }
    }
}
