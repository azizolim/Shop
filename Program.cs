using Facility;
using System.Runtime.CompilerServices;

internal partial class Program
{
    public static string _roleName;
    private static bool _play;
    private static int _choosenRole;
    private static Role _currentRole;
    private static void Main(string[] args)
    {
        PlayerSelect();
    }
    private static void PlayerSelect() 
    {
        Console.WriteLine("Greetings, Master!");
        Console.WriteLine("Master which Role you want to play?");
        Role[] _role = new Role[2] { new Player(), new Manager() };
        for (int i = 0; i != _role.Length; i++)
        {
            int h = i;
            h++;
            Console.WriteLine($"Roles which we could play: {h}. {_role[i]._roleName}");
        }
        
        _play = int.TryParse(Console.ReadLine(), out _choosenRole);
        if (_play)
        {
            _choosenRole--;
            _currentRole = _role[_choosenRole];
            _currentRole.Start();
            //Console.Clear();
        }
    }
}