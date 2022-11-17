using Facility;

internal class Program
{
    private static bool _visit;
    private static void Main(string[] args)
    {
        Shop _shop = new Shop();
        Console.WriteLine("Greetings, Master!");

        Console.WriteLine("Master would you like to visit shop?");
        _visit = Console.ReadLine() == "yes" ? true : false;
        if (_visit)
        {
            Console.WriteLine(" Master is going to the shop");
            _shop.Greetings();

        }
        else 
        {
            Console.WriteLine("What do you want to do? Master");
        }
    }
}