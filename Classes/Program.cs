namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            Car car1 = new Car()
            {
                Make = "Ford",
                Model = "Fusion",
                Year = 2013,
            };
            Console.WriteLine($"{car1.Make} {car1.Model} {car1.Year}" );
        }
    }
}
