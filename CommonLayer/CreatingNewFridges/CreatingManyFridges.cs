using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewFridges
{
    class CreatingManyFridges
    {
        // Properties
        public List<Fridge> allFridges { get; set; }
        private const int _flag = -999;
        private const int _start = 1;
        private int shelfsAmount;

        // Constructror
        public CreatingManyFridges()
        {
            this.allFridges = new List<Fridge>();
            this.InputNewItem();
        }

        // Methods
        public void InputNewItem()
        {
            Console.WriteLine("You are going to start creating many Fridges. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());

            Console.WriteLine("How many shelfs do you want this fridge to contain?");
            this.shelfsAmount = int.Parse(Console.ReadLine());

            CreateOneNewFridge createFridges = new CreateOneNewFridge(this.shelfsAmount);

            while (answer != _flag)
            {
                this.allFridges.Add(createFridges.Fridge);
                Console.WriteLine("Continue?");
                answer = int.Parse(Console.ReadLine());

            }
        }
    }
}
