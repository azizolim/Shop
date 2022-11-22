
namespace Facility
{
    public class Potion: Shop
    {
        public Potion() 
        {
            _shopName = "Potion";
            _items = new string[5]
                { "Blades of Chaos", "Magic staff",
                "Time stone ", "Odin's Eye ",
                "Captain America's Shield"};

        }
    }
}
