using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator
{
    class GetRidOfRequieredFood
    {
        // Properties
        private List<Shelf> shelfs;
        public List<Shelf> originalShelfs { get; set; }
        private string BadType;
        private int TimeRange;

        // Constructor
        public GetRidOfRequieredFood(Fridge Fridge, string BadType, int TimeRange)
        {
            this.shelfs = Fridge.Shelfs;
            this.originalShelfs = Fridge.Shelfs;
            this.BadType = BadType;
            this.TimeRange = TimeRange;
        }

        // Methods
        public void ThrowStuffOnShelfAway(List<Item> items)
        {
            if (items != null)
            {
                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i] != null && items[i].FoodType.Equals(BadType) && items[i].LastDay.AddDays(this.TimeRange).Equals(DateTime.Today))
                    {
                        Console.WriteLine("The Next Item Is Going To Be Removed:");
                        items[i].ToString();
                        items.RemoveAt(i);
                        Console.WriteLine("It Was Removed.");
                    }
                }
            }
        }
    }
}
