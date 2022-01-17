using Refrigirator.CommonLayer.CreatingNewItems;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.DAL
{
    class CreateNewItems
    {
        // Properties
        public List<Item> allItems { get; set; }
        private const int _flag = -999;
        private const int _start = 1;

        // Constructror
        public CreateNewItems()
        {
            this.allItems = new List<Item>();
            this.InputNewItem();
        }

        // Methods
        public void InputNewItem()
        {
            Console.WriteLine("You are going to start creating many items. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());

            CreateOneNewItem createItems = new CreateOneNewItem();

            while (answer != _flag)
            {
                this.allItems.Add(createItems.Item);
                Console.WriteLine("Continue?");
                answer = int.Parse(Console.ReadLine());

            }
        }
    }
}
