namespace BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int annualBasketballTrainingFee = int.Parse(Console.ReadLine());

            var sneakersPrice = annualBasketballTrainingFee - (annualBasketballTrainingFee * 0.40);
            var teamPrice = sneakersPrice - (sneakersPrice * 0.20);
            var ballPrice = teamPrice / 4;
            var accessories = ballPrice / 5;

            var totalPrice = sneakersPrice + teamPrice + ballPrice + accessories + annualBasketballTrainingFee;

            Console.WriteLine(totalPrice);
        }
    }
}