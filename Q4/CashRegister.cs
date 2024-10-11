using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q4
{
    
    internal class CashRegister
    {
        
        //Attributes
        private decimal total;
        private int numberOfItems;


        //Getters cause they read only 
        public decimal Total
        {
            get { return total; }
        }
        public int NumberOfItems
        {
            get { return numberOfItems; }
        }

        



        public void AddItem(decimal price)
        {
            total += price;
            numberOfItems++;
        }
    }
}
