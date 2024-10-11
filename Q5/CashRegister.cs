using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    internal class CashRegister
    {
        private decimal total;
        private int itemCount;

        private static decimal totalCash;
        private static int totalItems;

        public void AddItem(decimal price)
        {
            total += price;
            itemCount++;

            totalCash += price;
            totalItems++;
        }
        public decimal Total => total;

        public int ItemCount => itemCount;

        public static decimal TotalCash => totalCash;

        public static int TotalItems => totalItems;
    }
}
