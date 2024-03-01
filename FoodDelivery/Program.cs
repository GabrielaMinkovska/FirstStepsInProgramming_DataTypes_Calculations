namespace FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chickenMenus = int.Parse(Console.ReadLine());
            int fishMenus = int.Parse(Console.ReadLine());
            int vegeterianMenus = int.Parse(Console.ReadLine());

            var pricePerChickenMenu = 10.35;
            var pricePerFishMenu = 12.40;
            var pricePerVegeterianMenu = 8.15;
            var deliveryFee = 2.50;

            var totalCostForMenus = chickenMenus * pricePerChickenMenu + fishMenus * pricePerFishMenu + vegeterianMenus * pricePerVegeterianMenu;
            var desetPrice = totalCostForMenus * 20 / 100;

            var totalOrderPrice = totalCostForMenus + desetPrice + deliveryFee;

            Console.WriteLine(totalOrderPrice);

        }
    }
}