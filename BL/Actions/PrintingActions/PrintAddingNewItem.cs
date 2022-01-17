using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintAddingNewItem
    {
        // Properties
        private Fridge Fridge;

        //Constructor
        public PrintAddingNewItem(Fridge Fridge)
        {
            this.Fridge = Fridge;

            CreateNewItems newItem = new CreateNewItems();
            PutNewItemIn putNewItem = new PutNewItemIn(this.Fridge, newItem.Item);
            putNewItem.CheckIfAdded();
            Console.WriteLine(this.Fridge.ToString());
        }
    }
}
