using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facility
{
    public class Shop
    {
        private static bool _shopRange;


        public void Greetings() 
        {
            Console.WriteLine("Welcome to the shop, Master ");

            Console.WriteLine("Would you like to drink? Master");
            Drinks();

            Console.WriteLine("Master, want you to have a look on our range of products?");
            _shopRange = Console.ReadLine() == "yes" ? true : false;
            if (_shopRange)
            {
                Console.WriteLine("Dear MAster,These are the entire range of products in our store: ");
                ShopInventory();

            }
            else
            {
                Console.WriteLine("What do you want to do? Master");
            }
        }

        private void Drinks() 
        {
            int _choosenDrink;
            string[] _drinks = new string[2] { "Tea", "Coffee"};
            for (int i = 0; i < _drinks.Length; i++) 
            {
                int h = i;
                h++;
                Console.WriteLine($"{h}. {_drinks[i]}");
            }
            _choosenDrink = int.Parse(Console.ReadLine());
            _choosenDrink--;

            Console.WriteLine($"This Master is drinking {_drinks[_choosenDrink]}");     
            
        }

        private void ShopInventory() 
        {
            int _chosenItem;
            string[] _items = new string[10] 
            { "Blades of Chaos", "Magic staff", 
                "Time stone ", "Odin's Eye ", 
                "Captain America's Shield", "Baki's hand", 
                "Mjolnir", "Fourth Hokage's Kunai", 
                "Frostmourne", "LightSaber" };

            for (int p = 0; p < _items.Length; p++) 
            {
                int q = p;
                q++;
                Console.WriteLine($"{q}. {_items[p]}");
            }


        }
    }
}
