using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Refrigirator
{
    class CreatingFridgeWithInfo1
    {
        // Properties
        public Fridge Fridge { get; set; }
        private List<Shelf> Shelfs;
        private List<Item> ItemsShelf1;
        private List<Item> ItemsShelf2;
        private List<Item> ItemsShelf3;

        // Constructor
        public CreatingFridgeWithInfo1()
        {
            this.Shelfs = new List<Shelf>();
            this.ItemsShelf1 = new List<Item>();
            this.ItemsShelf2 = new List<Item>();
            this.ItemsShelf3 = new List<Item>();

            this.Fridge = new Fridge("Samsung", Color.Black, 3, CreateShelfs(Shelfs, ItemsShelf1, ItemsShelf2, ItemsShelf3));
            Console.WriteLine(Fridge.ToString());
        }

        // Methods
        public static List<Shelf> CreateShelfs(List<Shelf> Shelfs, List<Item> ItemsShelf1, List<Item> ItemsShelf2, List<Item> ItemsShelf3)
        {
            List<Shelf> shelfCopy = Shelfs;

            shelfCopy.Add(new Shelf(1, 10, CreateItemsShelf1(ItemsShelf1)));
            shelfCopy.Add(new Shelf(2, 15, CreateItemsShelf2(ItemsShelf2)));
            shelfCopy.Add(new Shelf(3, 5, CreateItemsShelf3(ItemsShelf3)));

            return shelfCopy;
        }

        public static List<Item> CreateItemsShelf1(List<Item> ItemsShelf1)
        {
            List<Item> itemsCopy = ItemsShelf1;

            itemsCopy.Add(new Item("Milk", "Drink", "Milky", new DateTime(2016, 7, 15), 5.0));
            itemsCopy.Add(new Item("Coockies", "Food", "Milky", new DateTime(2022, 2, 17), 2));

            return itemsCopy;
        }

        public static List<Item> CreateItemsShelf2(List<Item> ItemsShelf2)
        {
            List<Item> itemsCopy = ItemsShelf2;

            ItemsShelf2.Add(new Item("Chiken Wings", "Food", "Meety", new DateTime(2021, 5, 15), 5.0));
            ItemsShelf2.Add(new Item("Cola Zero", "Drink", "Parve", new DateTime(2022, 2, 4), 10.0));

            return itemsCopy;
        }

        public static List<Item> CreateItemsShelf3(List<Item> ItemsShelf3)
        {
            List<Item> itemsCopy = null;

            //ItemsShelf3.Add(null);
            //ItemsShelf3.Add(null);

            return itemsCopy;
        }
    }
}
