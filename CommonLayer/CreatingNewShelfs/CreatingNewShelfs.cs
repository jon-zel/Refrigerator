using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewShelfs
{
    class CreatingNewShelfs
    {
        // Properties
        public List<Shelf> allShelfs { get; set; }
        private const int _flag = -999;
        private const int _start = 1;
        private int amount;

        // Constructror
        public CreatingNewShelfs(int amount)
        {
            this.amount = amount;
            this.allShelfs = new List<Shelf>();
            this.InputNewShelf();
        }

        // Methods
        public void InputNewShelf()
        {
            Console.WriteLine("You are going to start creating many shelfs. Press " + _start + " to start, and " + _flag + " to end.");
            int answer = int.Parse(Console.ReadLine());

            CreatingOneNewShelf createShelf = new CreatingOneNewShelf();
            
            for (int i = 0; i < this.amount; i++)
            { 
            
                this.allShelfs.Add(createShelf.Shelf);
                Console.WriteLine("Continue?");
                answer = int.Parse(Console.ReadLine());

            }
        }
    }
}
