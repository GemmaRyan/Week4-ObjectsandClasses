using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q6
{
    internal class LunchDemos
    {
        public string Entree
        {
            get;
            set;
        }
        public string SideDish
        {
            get;
            set;
        }
        public string Drink
        {
            get;
            set;
        }

        public Lunch(string entree, string sideDish, string drink)
        {
            Entree = entree;
            SideDish = sideDish;
            Drink = drink;
        }
    }
}
