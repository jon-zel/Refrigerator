using Refrigirator.DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.CommonLayer.CreatingNewShelfs
{
    class CreatingNewShelf
    {
        // Properties
        public Item Item { get; set; }
        public Shelf Shelf { get; set; }

        // Constructor
        public CreatingNewShelf()
        {
            CreateNewItem createItem = new CreateNewItem();
            this.Item = createItem.Item;
        }
    }
}
