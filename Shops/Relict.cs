namespace Facility
{
    public class Relict: Shop
    {
        
        bool _wantdrink;

        public Relict() 
        {
            _shopName = "Relict";
            _items = new string[10]
                { "Blades of Chaos", "Magic staff",
                "Time stone ", "Odin's Eye ",
                "Captain America's Shield", "Baki's hand",
                "Mjolnir", "Fourth Hokage's Kunai",
                "Frostmourne", "LightSaber" };
        }
        
        public override void Greetings()
        {
            Console.WriteLine("Welcome to the shop, Master ");
            Console.WriteLine("Would you like to drink something?");
            _wantdrink = Console.ReadLine() == "yes" ? true : false;
            if (_wantdrink)
            {
                Console.WriteLine("Choose a drink Master");
                Drinks();
            }
            
                ShopEntryGreetings();
            
        }        
        
        private void Drinks()
        {
            int _choosenDrink;
            string[] _drinks = new string[2] { "Tea", "Coffee" };
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
    }
}
