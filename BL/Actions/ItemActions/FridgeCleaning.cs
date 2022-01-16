using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class FridgeCleaning
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public FridgeCleaning(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("Your Fridge Was Cleaned.");
            this.Clean();
            Console.WriteLine(this.Fridge.ToString());
        }

        // Methods
        public void Clean()
        {
            if (this.Fridge != null && this.Fridge.Shelfs != null)
            {
                foreach (Shelf shelf in this.Fridge.Shelfs)
                {
                    if (shelf != null)
                    {
                        this.CleanShelf(shelf.Items);
                    }
                }
            }
        }

        public void CleanShelf(List<Item> items)
        {
            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].LastDay < DateTime.Today)
                        items.Remove(items[i]);
                }
            }
        }
    }
}
