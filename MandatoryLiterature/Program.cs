namespace MandatoryLiterature
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pagesInHour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            var totalReadingTime = pages / pagesInHour;
            var requiredHours = totalReadingTime/ days;

            Console.WriteLine(requiredHours);
        }
    }
}