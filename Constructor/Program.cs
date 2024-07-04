namespace Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car maruti = new Car();

            maruti.CarStart();
            Console.WriteLine($"The speed of Maruti is {maruti.Speed}");

            Car tesla = new Car(11.5, "Tesla S", 5.5, "Big", 190.99);

            Console.WriteLine($"Model -> { tesla.Model.ToString()}\n" +
                $"Price -> {tesla.Price}\n" +
                $"Size -> {tesla.Size}\n" +
                $"Maximum Speed -> {tesla.Speed}");
            Console.Read();
        }
    }
}
