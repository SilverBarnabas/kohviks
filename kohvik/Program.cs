using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kohvik
{
    class Program
    {

        static void Main(string[] args)
        {

            int Cost = 0;
            void mdea()
            {
                Console.WriteLine("Helloo, what coffee do you want?\n1 - Cappuccino\n2 - Espresso\n3 - Latte\n0 - Skip coffee");
                int Option = Int32.Parse(Console.ReadLine());
                switch (Option)
                {
                    case 1:
                        var Cappuccino = new Cappuccino();
                        Cappuccino.CoffeeName();
                        Cappuccino.CoffeeSize();
                        Cappuccino.CoffeePrice();
                        Cost = Cost + Cappuccino.Price;
                        break;
                    case 2:
                        var Latte = new Latte();
                        Latte.CoffeeName();
                        Latte.CoffeeSize();
                        Latte.CoffeePrice();
                        Cost = Cost + Latte.Price;
                        break;
                    case 3:
                        var Espresso = new Espresso();
                        Espresso.CoffeeName();
                        Espresso.CoffeeSize();
                        Espresso.CoffeePrice();
                        Cost = Cost + Espresso.Price;
                        break;
                    case 0:
                        break;

                }
                Console.WriteLine("Bill is " + Cost + "€.");
                Console.ReadKey();
                Console.WriteLine("Helloo, what food do you want?\n1 - Chips\n2 - Fries\n0 - Skip food");
                int Option2 = Int32.Parse(Console.ReadLine());
                switch (Option2)
                {
                    case 1:
                        var Fries = new Fries();
                        Fries.FoodName();
                        Fries.FoodPrice();
                        Cost = Cost + Fries.Price;
                        break;
                    case 2:
                        var Chips = new Chips();
                        Chips.FoodName();
                        Chips.FoodPrice();
                        Cost = Cost + Chips.Price;
                        break;
                    case 0:
                        break;

                }
                Console.WriteLine("Bill is " + Cost + "€.");
                Console.ReadKey();
                Console.WriteLine("If you want to add another press a");
                string uuesti = Console.ReadLine();
                if(uuesti == "a")
                {
                    mdea();
                }
            }
            
        }
    }
}
