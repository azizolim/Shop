using Facility;

public class Player : Role
{
    public Player()
    {
            _roleName= "Player";
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
                _currentShop.Greetings();
                Console.Clear();
            }
    }

   
    
}
