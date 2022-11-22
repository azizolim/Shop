using Facility;

public abstract class Role 
{
    public string _roleName;
    private Shop _currentShop;
    private bool _visit;
    private int _choosenFacility;
    public virtual void Start()

    {
        Shop[] _shop = new Shop[2] { new Potion(), new Relict() };
        Console.WriteLine("Greetings, Master!");
        Console.WriteLine($"Welcome to the role of {_roleName}");

        Console.WriteLine("Master which place you want to visit?");
        for (int i = 0; i != _shop.Length; i++)
        {
            int h = i;
            h++;
            Console.WriteLine($"Places where we could go: {h}. {_shop[i]._shopName}");
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

    

