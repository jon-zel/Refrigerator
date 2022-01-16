using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class TakeItemOut
    {
        // Properties
        private string ItemName;
        private Fridge Fridge;
        public Item FoundItem { get; set; }

        // Constructor
        public TakeItemOut(string ItemName, Fridge Fridge)
        {
            this.ItemName = ItemName;
            this.Fridge = Fridge; 
        }

        // Methods
        public bool FindAndTakeOut()
        {
            if (this.Fridge != null && this.Fridge.Shelfs != null)
            {
                foreach (Shelf s in this.Fridge.Shelfs)
                {
                    if (s != null && s.Items != null && this.DoesItemExist(s.Items))
                    {
                        this.FoundItem = this.DidGetAnItemOut(s.Items);

                        return true;
                    }
                }

                Console.WriteLine("This Item Doesn't Exist In This Fridge.");
            }

            return false;
        }

        public Item DidGetAnItemOut(List<Item> items)
        {
            if (items != null)
            {
                Item chosen;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] != null && items[i].ItemName.Equals(this.ItemName))
                    {
                        chosen = items[i];
                        items.Remove(items[i]);
                        return chosen;
                    }
                }
                // Deletes only the first one he finds
            }

            return null;
        }

        public bool DoesItemExist(List<Item> items)
        {
            if (items != null)
            {
                foreach (Item i in items)
                {
                    if (i.ItemName.Equals(this.ItemName))
                        return true;
                }
            }

            return false;
        }
    }
}
