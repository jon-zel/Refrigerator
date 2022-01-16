using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.DAL
{
    class CreateNewItem
    {
        // Properties
        public Item Item { get; set; }
        public string ItemName { get; set; }
        public int ShelfFloorNumber { get; set; }
        public string FoodOrDrink { get; set; }
        public string FoodType { get; set; }
        public DateTime LastDay { get; set; }
        public double Capacity { get; set; }

        // Constructror
        public CreateNewItem()
        {
            this.ItemName = "Apples";
            this.FoodOrDrink = "Food";
            this.FoodType = "Parve";
            this.LastDay = new DateTime(2012, 2, 9);
            this.Capacity = 4;

            this.Item = new Item(this.ItemName, this.FoodOrDrink, this.FoodType, this.LastDay, this.Capacity);
        }
    }
}
