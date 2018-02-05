using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvik
{
    class Food
    {
        public string Name;
        public int Price;

        public void FoodName()
        {
            Console.WriteLine("You choosed " + Name + ".");
        }
        public void FoodPrice()
        {
            Console.WriteLine("Your " + Name + " price is " + Price + "€.");

        }
    }
}
