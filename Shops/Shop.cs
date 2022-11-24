using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Facility
{
    public abstract class Shop : FacilityBase
    {
        protected string[] _items;
        protected bool _shopRange;
        protected bool _buyAgain;

        public  virtual void Greetings()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the shop, Master ");
            ShopEntryGreetings();
        }



        protected void ShopEntryGreetings()
        {
            Console.WriteLine("Master, want you to have a look on our range of products?");
            _shopRange = Console.ReadLine() == "yes" ? true : false;
            Console.WriteLine("Please enter yes or no");
            if (_shopRange)
            {
                Console.WriteLine("Dear Master,These are the entire range of products in our store: ");
                ShopInventory();
            }
            else
            {
                Console.WriteLine("What do you want to do? Master");
            }
        }

        protected void ShopInventory()
        {
            bool _isCorrect;
            do
            {
                Console.Clear();
                int _chosenItem;
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