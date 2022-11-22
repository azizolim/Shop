using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facility
{
    public abstract class Shop
    {
        public string _shopName; 
        protected bool _shopRange;
        protected bool _buyAgain;
        public  virtual void Greetings()
        {
            Console.WriteLine("Welcome to the shop, Master ");
            RelictShopGreetings();
        }

        protected void RelictShopGreetings()
        {
            Console.WriteLine("Master, want you to have a look on our range of products?");
            _shopRange = Console.ReadLine() == "yes" ? true : false;
            if (_shopRange)
            {
                Console.WriteLine("Dear Master,These are the entire range of products in our store: ");
                RelictInventory();
            }
            else
            {
                Console.WriteLine("What do you want to do? Master");
            }
        }

        protected void RelictInventory()
        {
            bool _isCorrect;
            do
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
                Console.WriteLine("Did you made up your mind Master?");
                do
                {

                    _isCorrect = int.TryParse(Console.ReadLine(), out _chosenItem);
                    if (_isCorrect)
                    {
                        _chosenItem--;
                        Console.WriteLine($"Master you have just bought {_items[_chosenItem]}");
                    }
                    else 
                    {
                        Console.Write("Please input a valid number");
                    }
                }
                while (!_isCorrect);

                  Console.WriteLine("Would you like to buy something else, Master?");
                 _buyAgain = Console.ReadLine() == "yes" ? true : false;
            }
            while (_buyAgain);
            Console.WriteLine("What do you want to do? Master");
        }
    }
}