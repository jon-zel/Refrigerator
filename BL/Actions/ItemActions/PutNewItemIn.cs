using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class PutNewItemIn
    {
        // Properties
        private Fridge Fridge;
        private Item Item;

        // Constructor
        public PutNewItemIn(Fridge Fridge, Item Item)
        {
            this.Fridge = Fridge;
            this.Item = Item;
        }

        // Methods
        public void CheckIfAdded()
        {
            if (this.PutNewItemInFridge())
                Console.WriteLine("Your New Item Is Added.");
            else
                Console.WriteLine("Couldn't Add New Item.");
        }

        public bool PutNewItemInFridge()
        {
            if (this.Fridge != null && this.Item != null && this.Fridge.Shelfs != null)
            {
                foreach (Shelf shelf in this.Fridge.Shelfs)
                {
                    if (shelf != null && shelf.Items != null && shelf.FreeSpaceOnShelf() >= this.Item.Capacity)
                    {
                        shelf.Items.Add(this.Item);
                        return true;
                    }
                    else if (shelf.Items is null && shelf.FreeSpace >= this.Item.Capacity)
                    {
                        this.Item.ShelfFloorNumber = shelf.FloorNumber;
                        shelf.Items = new List<Item>();
                        shelf.Items.Add(this.Item);

                        return true;
                    }
                }

                Console.WriteLine("There is not enough space in the fridge for this item.");
            }

            return false;
        }
    }
}
