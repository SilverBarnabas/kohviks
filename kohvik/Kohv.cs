using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvik
{
    class Kohv
    {
        public string Name;
        public int Size;
        public int Price;

        public void CoffeeName()
        {
            Console.WriteLine("You choosed " + Name + ".");
        }
        public void CoffeeSize()
        {
            Console.WriteLine("Your " + Name + " size is " + Size + " ml.");
        }
        public void CoffeePrice()
        {
            Console.WriteLine("Your " + Name + " price is " + Price + "€.");
            


        }


    }
}
