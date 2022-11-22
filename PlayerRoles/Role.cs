using Facility;

public abstract class Role 
{
    private int _choosenFacility;
    private bool _visit;
    public string _roleName;
    private Shop _currentShop;
    public virtual void Start()

    {
        Console.WriteLine("Greetings, Master!");
        Console.WriteLine($"Welcome to the role of {_roleName}");

        
        Console.WriteLine("Master which place you want to visit?");


        Shop[] _shop = new Shop[2] { new Potion(), new Relict() };
        for (int i = 0; i != _shop.Length; i++)
        {
            int h = i;
            h++;
            Console.WriteLine($"Places where we could go: {h}. {_shop[i]._shopName}");
            Console.WriteLine("Please insert a number of the place to choose");
        }
        
        _visit = int.TryParse(Console.ReadLine(), out _choosenFacility);
        if (_visit)
        {
            _choosenFacility--;
            _currentShop = _shop[_choosenFacility];
            _currentShop.Greetings();
            Console.Clear();
        }
    }
}

    

