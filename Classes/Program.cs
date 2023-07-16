namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var corolla = new Car();
            corolla.Make = "Toyota";
            corolla.Model = "Corolla";
            corolla.Year = 2023;
            Console.WriteLine("Make    Model  Year");
            Console.WriteLine("-------------------");
            Console.WriteLine($"{corolla.Make} {corolla.Model} {corolla.Year}");
        }
    }
}
