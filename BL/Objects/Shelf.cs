﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class Shelf
    {
        // Properties
        public int FloorNumber { get; set; }
        public double FreeSpace { get; set; }
        public List<Item> Items { get; set; }

        // Constructor
        public Shelf(int FloorNumber, int FreeSpace, List<Item> Items)
        {
            this.FloorNumber = FloorNumber;
            this.FreeSpace = FreeSpace;
            this.Items = Items;
            this.SetEveryItemsToBeInThisFloor();
        }

        // Methods
        public double FreeSpaceOnShelf()
        {
            return (this.FreeSpace - this.TakenSpaceByAllItemsOnSpecificShalf(this));
        }

        public double TakenSpaceByAllItemsOnSpecificShalf(Shelf shelf)
        {
            if (!(shelf is null))
            {
                double takenArea = 0;

                if (shelf.Items != null)
                {
                    foreach (Item item in shelf.Items)
                    {
                        if (item != null)
                            takenArea += item.Capacity;
                    }

                    return takenArea;
                }
            }

            return 0;
        }

        public override string ToString()
        {
            string s = "\nFloor Number : " + this.FloorNumber + "\n";
            s += "Free Space : " + this.FreeSpace + "\n";
            s += "Items";
            s += "\n";

            if (this.Items != null)
            {
                for (int i = 0; i < this.Items.Count; i++)
                {
                    s += "\nItem number " + (i + 1) + ": \n";
                    if (this.Items[i] != null)
                        s += this.Items[i].ToString();
                    s += "\n";
                }
            }
            else
                s += "No Items On The Shelf.\n";

            s += "- - - - - - - - - - - - - - - - - - - - - - -";

            return s;
        }

        public void SetEveryItemsToBeInThisFloor()
        {
            if (this.Items != null)
            {
                foreach (Item i in this.Items)
                {
                    if (i != null)
                        i.ShelfFloorNumber = this.FloorNumber;
                }
            }
        }
    }
}
