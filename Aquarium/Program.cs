namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine()); 
            double percentage = double.Parse(Console.ReadLine());

            double occupiedSpace = percentage / 100;

            double volumeAquarium = length * width * height;
            double volumeInLiters = volumeAquarium * 0.001;

            double requiredLiters = volumeInLiters * (1 - occupiedSpace);

            Console.WriteLine($"{requiredLiters:F2}");
        }
    }
}