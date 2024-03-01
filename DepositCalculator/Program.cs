namespace DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double depositedAmount = double.Parse(Console.ReadLine());
            int term = int.Parse(Console.ReadLine());
            double annualInterestRate = double.Parse(Console.ReadLine());

            double amount = depositedAmount + (term * ((depositedAmount * annualInterestRate / 100) / 12));

            Console.WriteLine(amount);
        }
    }
}