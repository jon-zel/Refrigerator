using System;
using System.Collections.Generic;
using System.Text;

namespace Refrigirator.BL.Actions.PrintingActions
{
    class PrintAllExpiredDatesInOrder
    {
        // Properties
        private Fridge Fridge;

        // Constructor
        public PrintAllExpiredDatesInOrder(Fridge Fridge)
        {
            this.Fridge = Fridge;
            Console.WriteLine("Expiry Dates List:");
            ExpiredDateList expiredDates = new ExpiredDateList(this.Fridge);
            expiredDates.PrintList();
        }
    }
}
