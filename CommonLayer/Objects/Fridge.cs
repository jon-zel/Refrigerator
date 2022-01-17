using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Refrigirator
{
    // CR: On layers you need to know why you creating them
    // CR: Common layer is the core of the project, it stores all the the basic models for the rest of the layers
        

    class Fridge
    {
        // Properties
        public string TypeName { get; set; }
        private Color Color { get; set; }
        private int ShelfsAmount { get; set; }
        public List<Shelf> Shelfs { get; set; }

        // Constructor
        public Fridge(string TypeName, Color Color, int ShelfsAmount, List<Shelf> Shelfs)
        {
            this.TypeName = TypeName;
            this.Color = Color;
            this.ShelfsAmount = ShelfsAmount;
            this.Shelfs = Shelfs;
        }

        // Methods
        public double EmptySpaceInAllFridge()
        {
            if (!(this.Shelfs is null))
            {
                double freeSpace = 0;

                foreach (Shelf shelf in this.Shelfs)
                {
                    if (shelf != null)
                        freeSpace += shelf.FreeSpaceOnShelf();
                }

                return freeSpace;
            }
            else
                Console.WriteLine("There are no shelfs");

            return -1;
        }

        public override string ToString()
        {
            string s = "Refrigiratoe's Type Name : " + this.TypeName;
            s += "\nColor: " + this.Color;
            s += "\nShelfs Amount : " + this.ShelfsAmount;
            s += "\nShelfs :\n";

            for (int i = 0; i < this.Shelfs.Count; i++)
            {
                s += "\nShelf number " + (i + 1) + " \n";
                s += this.Shelfs[i].ToString();
            }

            return s;
        }
    }
}
