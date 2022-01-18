using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewFridges
{
    class CreateOneNewFridge
    {
        // Properties
        public Fridge Fridge { get; set; }
        public string TypeName { get; set; }
        private Color Color { get; set; }
        private int ShelfsAmount { get; set; }
        public List<Shelf> Shelfs { get; set; }

        // Constructror
        public CreateOneNewFridge()
        {
            Console.WriteLine("How many shelfs you want this fridge to have?");
            this.ShelfsAmount = int.Parse(Console.ReadLine()); ;
            CreatingNewShelfs createNewShelfs = new CreatingNewShelfs(this.ShelfsAmount);
            this.Shelfs = createNewShelfs.allShelfs;

            this.Fridge = this.InputNewItem();
        }

        // Methods
        public Fridge InputNewItem()
        {
            Console.WriteLine("Enter Fridge's Type Name:");
            this.TypeName = Console.ReadLine();

            Console.WriteLine("Enter Color:");
            // only because couldn't find the right way to do so.
            this.Color = Color.Green;

             //לבדוק שצבע הגיוני
            
            Console.WriteLine("Enter Shelfs Amount:");
            this.ShelfsAmount = int.Parse(Console.ReadLine());

            var fridge = new Fridge(this.TypeName, this.Color, this.ShelfsAmount, this.Shelfs);

            return fridge;
        }
    }
}
