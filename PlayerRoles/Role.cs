using Facility;

public abstract class Role
{
    public string _roleName;
    protected int _choosenFacility;
    protected bool _visit;
    protected Shop _currentShop;
    protected Shop[] _availableShop;
    
    public virtual void Start()
    {
        _availableShop = new Shop[2] { new Potion(), new Relict() };
        Console.WriteLine("Greetings, Master!");
        Console.WriteLine($"Welcome to the role of {_roleName}");
        RoleSelection();
    }

    protected abstract void RoleSelection();
    
    protected virtual void ViewFacility(FacilityBase[] _availableFacility)
    {

        for (int i = 0; i != _availableFacility.Length; i++)
        {
            int h = i;
            h++;
            Console.WriteLine($"{h}. {_availableFacility[i].FacilityName}");
        }
        Console.WriteLine("Please insert a number");

    }
}
    

