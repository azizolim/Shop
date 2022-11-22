
namespace Facility
{
    public class Potion: Shop
    {
        public Potion() 
        {
            _shopName = "Potion";
            _items = new string[5]
                { "Potion of Health ", "Potion of Magic",
                "Reincarnation potion", "Amortensa ",
                "Potion of Strenght"};

        }
    }
}
