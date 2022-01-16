using Refrigirator.BL.Actions.ItemActions;
using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintOrganizedFridges
    {
        // Properties
        private List<Fridge> Fridges;

        // Constructor
        public PrintOrganizedFridges()
        {
            CreatingFridgeWithInfo1 createFridge1 = new CreatingFridgeWithInfo1();
            CreateNewFridgeWithInfo2 createFridge2 = new CreateNewFridgeWithInfo2();

            this.Fridges = new List<Fridge>();
            this.Fridges.Add(createFridge1.Fridge);
            this.Fridges.Add(createFridge2.Fridge);

            OrganizedFridgersInOrder organizedFridges = new OrganizedFridgersInOrder(this.Fridges);
            organizedFridges.PrintList();
        }
    }
}
