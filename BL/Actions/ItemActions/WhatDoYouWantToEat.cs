﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class WhatDoYouWantToEat
    {
        // Properties
        private Fridge Fridge;
        private string FoodOrDrink;
        private string FoodType;
        private List<Item> suitableItems;

        // Constructor
        public WhatDoYouWantToEat(Fridge Fridge, string FoodOrDrink, string FoodType)
        {
            this.Fridge = Fridge;
            this.FoodOrDrink = FoodOrDrink;
            this.FoodType = FoodType;
            this.suitableItems = new List<Item>();
            this.FinalList();
        }

        // Methods
        public void FinalList()
        {
            if (this.Fridge != null && this.Fridge.Shelfs != null)
            {
                foreach (Shelf s in this.Fridge.Shelfs)
                {
                    this.FindItem(s.Items);
                }

                if (this.suitableItems != null)
                {
                    this.ValidateSuitableItems();
                    Console.WriteLine(this.suitableItems.ToString());
                }
                else
                    Console.WriteLine("Couldn't Find Proper Request.");
            }
        }

        public void ValidateSuitableItems()
        {
            if (this.suitableItems != null)
            {
                foreach (Item i in this.suitableItems)
                {
                    if (i != null && i.LastDay < DateTime.Today)
                        this.suitableItems.Remove(i);
                }

                if (this.suitableItems == null)
                    Console.WriteLine("The Requested Items Are Expired.");
            }
        }

        public void FindItem(List<Item> items)
        {
            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].FoodType.Equals(this.FoodType) && items[i].FoodOrDrink.Equals(this.FoodOrDrink) && items[i].LastDay > DateTime.Today)
                        this.suitableItems.Add(items[i]);
                }
            }
        }



    }
}
