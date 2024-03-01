namespace Redecorating
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int requiredAmountOfNylon = int.Parse(Console.ReadLine());
            int requiredAmountOfPaint = int.Parse(Console.ReadLine());
            int quantityOfThinner = int.Parse(Console.ReadLine());
            int neededHoursCreftmen = int.Parse(Console.ReadLine());

            var pricePerProtectiveNylon = 1.50;
            var pricePerLiterOfPaint = 14.50;
            var pricePerLiterOfPaintThinner = 5;
          
            var nylonAmount = (requiredAmountOfNylon + 2) *pricePerProtectiveNylon;
            var paintAmount = (requiredAmountOfPaint + requiredAmountOfPaint * 10/100) * pricePerLiterOfPaint;
            var thinnerAmount = quantityOfThinner * pricePerLiterOfPaintThinner;
            var bagPrice = 0.40;
            var totalAmountForMaterials = nylonAmount + paintAmount + thinnerAmount +bagPrice;
            var amountForCraftmen = (totalAmountForMaterials * 30/100) * neededHoursCreftmen;

            var totalAmount = totalAmountForMaterials + amountForCraftmen;

            Console.WriteLine(totalAmount);

        }
    }
}