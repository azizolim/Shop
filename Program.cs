using Facility;
using System.Runtime.CompilerServices;

internal class Program
{
    private static int _visit;
    private static void Main(string[] args)
    {
        Shop[] _shop = new Shop[2] { new Potion(), new Relict() };
        Console.WriteLine("Greetings, Master!");

        Console.WriteLine("Master which place you want to visit?");
        for (int i = 0; i != _shop.Length; i++)
        {
            int h = i;
                h++;
            Console.WriteLine($"Places where we could go: {h}. {_shop[i]._shopName}");
        }   
    }
}