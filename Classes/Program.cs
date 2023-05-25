namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var firstCar = new Car();
            firstCar.Make = "Tesla";
            firstCar.Model = "Model 3";
            firstCar.Year = 2023;


            Console.WriteLine($"this car is a {firstCar.Year} {firstCar.Make} {firstCar.Model}");
        }
    }
}
