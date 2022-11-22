using Facility;

internal class Program
{
    private static int _choosenPlace;

    static Potion _potion = new Potion();
    static Relict _relict = new Relict();

    private static void Main(string[] args)
    {
        Console.WriteLine("Good day, Master!");

        Console.WriteLine("Which place do you want to visit Master?");
        VisitFacility();

        if (_choosenPlace == 1)
        {
            _potion.PotionShopGreetings();
        }
        else
        {
            _relict.Greetings();
        }


        void VisitFacility()
        {
            string[] _facilities = new string[2] { "Potion Shop", "Relict Shop" };
            for (int i = 0; i < _facilities.Length; i++)
            {
                int h = i;
                h++;
                Console.WriteLine($"{h}. {_facilities[i]}");
            }
            _choosenPlace = int.Parse(Console.ReadLine());
            _choosenPlace--;
            Console.WriteLine($"Master, we're going to {_facilities[_choosenPlace]}");
            
        }



    }
}