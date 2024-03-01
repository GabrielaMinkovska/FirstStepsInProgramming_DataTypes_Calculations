namespace TeachingMaterials
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int penPackage = int.Parse(Console.ReadLine());
            int markersPackage = int.Parse(Console.ReadLine());
            int boardCleanerLiters = int.Parse(Console.ReadLine());
            int discont = int.Parse(Console.ReadLine());

            var priceRerOnePenPackage = 5.80;
            var pricePerMarkersPackage = 7.20;
            var pricePerLiterBoardCleaner = 1.20;

            var price = penPackage * priceRerOnePenPackage + markersPackage * pricePerMarkersPackage + boardCleanerLiters * pricePerLiterBoardCleaner;
            var priceAfterDiscount = price - (price * discont / 100);

            Console.WriteLine(priceAfterDiscount);

        }
    }
}