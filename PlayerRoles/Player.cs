using Facility;
using System.Security.Cryptography.X509Certificates;

public delegate void ShowInventory();
public delegate void AddToInventory(string product); 
public class Player : Role
{
    private AddToInventory _addInventoryDelegate;
    private ShowInventory _showInventoryDelegate;
    private List<string> _inventory; 
    public Player()
    {
        _roleName= "Player";
        _inventory = new List<string>();
        _addInventoryDelegate = AddToInventory;
        _showInventoryDelegate = ShowInventory;
    }

    protected override void RoleSelection()
    {
            Console.WriteLine("Master which place you want to visit?");
            ViewFacility(_availableShop);

            _visit = int.TryParse(Console.ReadLine(), out _choosenFacility);
            if (_visit)
            {
                _choosenFacility--;
                _currentShop = _availableShop[_choosenFacility];
                _currentShop.Initialize(_addInventoryDelegate, _showInventoryDelegate);
                _currentShop.Greetings();
            
                Console.Clear();
            }
    }

    private void AddToInventory(string product) 
    {
        _inventory.Add(product);
        Console.WriteLine($"This {product} is in our inventory");
    }

    private void ShowInventory() 
    {
        Console.WriteLine($"Master, this is our inventory ");
        for (int i = 0; i < _inventory.Count; i++) 
        {
            int q = i;
            q++;
            Console.WriteLine($"{q}. {_inventory[i]}");
        } 
    }
   
    
}
