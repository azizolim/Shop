
namespace Facility
{
    public class Potion: Shop
    {
        public Potion() 
        {
            _shopName = "Potion"; 
        }

        public override void PotionShopGreetings()
        {
            Console.WriteLine("Welcome to the potion shop, Master ");
           

            ShopEntryGreetings();

        }
    }
}
