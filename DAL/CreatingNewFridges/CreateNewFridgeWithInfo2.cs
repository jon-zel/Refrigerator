using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Refrigirator.DAL
{
    class CreateNewFridgeWithInfo2
    {
        // Properties
        public Fridge Fridge { get; set; }
        private List<Shelf> Shelfs;
        private List<Item> ItemsShelf1;
        private List<Item> ItemsShelf2;
        private List<Item> ItemsShelf3;
        private List<Item> ItemsShelf4;

        // Constructror
        public CreateNewFridgeWithInfo2()
        {
            this.Shelfs = new List<Shelf>();
            this.ItemsShelf1 = new List<Item>();
            this.ItemsShelf2 = new List<Item>();
            this.ItemsShelf3 = new List<Item>();
            this.ItemsShelf4 = new List<Item>();

            Fridge Fridge = new Fridge("Havana", Color.Green, 4, CreateShelfs(Shelfs, ItemsShelf1, ItemsShelf2, ItemsShelf3, ItemsShelf4));
            Console.WriteLine(Fridge.ToString());
        }

        // Methods
        public static List<Shelf> CreateShelfs(List<Shelf> Shelfs, List<Item> ItemsShelf1, List<Item> ItemsShelf2, List<Item> ItemsShelf3, List<Item> ItemsShelf4)
        {
            List<Shelf> shelfCopy = Shelfs;

            shelfCopy.Add(new Shelf(1, 8, CreateItemsShelf1(ItemsShelf1)));
            shelfCopy.Add(new Shelf(2, 5, CreateItemsShelf2(ItemsShelf2)));
            shelfCopy.Add(new Shelf(3, 2, CreateItemsShelf3(ItemsShelf3)));
            shelfCopy.Add(new Shelf(4, 7, CreateItemsShelf3(ItemsShelf4)));

            return shelfCopy;
        }

        public static List<Item> CreateItemsShelf1(List<Item> ItemsShelf1)
        {
            List<Item> itemsCopy = ItemsShelf1;

            itemsCopy.Add(new Item("Lettus", "Food", "parve", new DateTime(2019, 7, 21), 5.0));
            itemsCopy.Add(new Item("Pita", "Food", "Milky", new DateTime(2022, 3, 19), 2));

            return itemsCopy;
        }

        public static List<Item> CreateItemsShelf2(List<Item> ItemsShelf2)
        {
            List<Item> itemsCopy = ItemsShelf2;

            itemsCopy.Add(new Item("Tomatoes", "Food", "Parve", new DateTime(2021, 1, 14), 5.0));
            itemsCopy.Add(new Item("Sprite", "Drink", "Parve", new DateTime(2022, 2, 4), 10.0));

            return itemsCopy;
        }

        public static List<Item> CreateItemsShelf3(List<Item> ItemsShelf3)
        {
            List<Item> itemsCopy = null;

            //ItemsShelf3.Add(null);
            //ItemsShelf3.Add(null);

            return itemsCopy;
        }

        public static List<Item> CreateItemsShelf4(List<Item> ItemsShelf4)
        {
            List<Item> itemsCopy = ItemsShelf4;

            itemsCopy.Add(new Item("Shoko", "Drink", "Milky", new DateTime(2021, 7, 10), 5.0));
            itemsCopy.Add(new Item("Grapes", "Food", "Parve", new DateTime(2022, 8, 4), 10.0));

            return itemsCopy;
        }
    }
}
