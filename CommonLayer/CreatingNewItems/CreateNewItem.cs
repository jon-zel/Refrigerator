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

        private const int _flag = -999;
        private const int _start = 1;
        private List<string> possibleFoodOrDrink;
        private List<string> FoodTypes;
        private int Day;
        private int Month;
        private int Year;

        // Constructror
        public CreateNewItem()
        {
            this.possibleFoodOrDrink = new List<string> { "Food", "Drink" };
            this.FoodTypes = new List<string> { "Parve", "Meety", "Milky" }; 

            this.Item = this.InputNewItem();
        }

        // Methods
        public bool FoodOrDrinkVerify()
        {
            if (this.possibleFoodOrDrink != null)
            {
                foreach (string s in this.possibleFoodOrDrink)
                {
                    if (this.FoodOrDrink.Equals(s))
                        return (true);
                }
            }

            return (false);
        }

        public void GetOnlyFoodOrDrink()
        {
            while (!this.FoodOrDrinkVerify())
            {
                Console.WriteLine("Wrong. Enter only 'Food' or 'Drink' Inputs.");
                this.FoodOrDrink = Console.ReadLine();
            }
        }

        public bool FoodTypeVerify()
        {
            if (this.FoodTypes != null)
            {
                foreach (string s in this.FoodTypes)
                {
                    if (this.FoodType.Equals(s))
                        return (true);
                }
            }

            return (false);
        }

        public void GetCorrectFoodType()
        {
            while (!this.FoodTypeVerify())
            {
                Console.WriteLine("Wrong Inputs.");
                this.FoodType = Console.ReadLine();
            }
        }

        public Item InputNewItem()
        {
            Console.WriteLine("You are creating new item. Enter " + _flag + " for ending." + " and " + _start + " for start.");
            string answer = Console.ReadLine();

            if (answer != _start.ToString() && answer != _flag.ToString())
            {
                Console.WriteLine("wrong input.");

                while (answer != _start.ToString() && answer != _flag.ToString())
                    answer = Console.ReadLine();
            }

            while (answer != _flag.ToString())
            {
                Console.WriteLine("Enter Item's Name:");
                this.ItemName = Console.ReadLine();

                Console.WriteLine("Enter Food Or Drink:");
                this.FoodOrDrink = Console.ReadLine(); ;

                if (!this.FoodOrDrinkVerify())
                    this.GetOnlyFoodOrDrink();

                Console.WriteLine("Enter Food Type:");
                this.FoodType = "Parve";

                if (this.FoodTypeVerify())
                    this.GetCorrectFoodType();

                Console.WriteLine("Enter Date by the following request:");
                Console.WriteLine("Enter day:");
                Day = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter month:");
                Month = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter year:");
                Year = int.Parse(Console.ReadLine());
                this.LastDay = new DateTime(Year, Month, Day);

                Console.WriteLine("Enter Capacity:");
                this.Capacity = int.Parse(Console.ReadLine());

                Console.WriteLine("You are creating new item. Enter " + _flag + " for ending.");
                answer = Console.ReadLine();

                if (answer != _start.ToString() && answer != _flag.ToString())
                {
                    Console.WriteLine("wrong input.");

                    while (answer != _start.ToString() && answer != _flag.ToString())
                        answer = Console.ReadLine();
                }
            }

            Item item = new Item(this.ItemName, this.FoodOrDrink, this.FoodType, this.LastDay, this.Capacity);

            return item;

        }
    }
}
