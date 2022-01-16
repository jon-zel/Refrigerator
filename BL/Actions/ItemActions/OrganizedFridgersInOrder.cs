using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.ItemActions
{
    class OrganizedFridgersInOrder
    {
        // Properties
        private List<Fridge> Fridges;
        private List<Fridge> NewFridgesInOrder;

        // Constructor
        public OrganizedFridgersInOrder(List<Fridge> Fridges)
        {
            this.Fridges = Fridges;
            this.NewFridgesInOrder = new List<Fridge>();
            this.GetMaxFridgeSpace(this.Fridges);
        }

        // Methods
        public void PrintList()
        {
            foreach (Fridge f in this.NewFridgesInOrder)
            {
                Console.WriteLine("New Fridges By Order:");
                Console.WriteLine(f.ToString());
            }
        }

        //public void GetNewFridgesList()
        //{
        //    if (this.Fridges != null)
        //    {
        //        for (int i = 0; i < this.Fridges.Count; i++)
        //        {
        //            if (this.Fridges[i] != null)
        //            {
        //                this.NewFridgesInOrder.Add(this.Fridges[this.GetMaxFridgeSpace(this.Fridges)]);
        //            }
        //        }
        //    }
        //}

        public void GetMaxFridgeSpace(List<Fridge> fridges)
        {
            double maxnSpace = fridges[0].EmptySpaceInAllFridge();
            int maxIndex = 0;

            while (fridges != null)
            {
                for (int i = 1; i < fridges.Count; i++)
                {
                    if (fridges[i] != null && fridges[i].EmptySpaceInAllFridge() > maxnSpace)
                    {
                        maxnSpace = fridges[i].EmptySpaceInAllFridge();
                        maxIndex = i;
                    }
                }

                this.NewFridgesInOrder.Add(fridges[maxIndex]);
                fridges.RemoveAt(maxIndex);

                maxnSpace = fridges[0].EmptySpaceInAllFridge();
                maxIndex = 0;
            }
        }
    }
}
