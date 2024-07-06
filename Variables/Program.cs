namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool Food = true; //boolean return true of false & initialize the t or f value
            char symbol = '!'; // char contain only single value or character and denoted by ''

            Console.WriteLine("Enter the name of food you want!"); // to display the msg for user
            String Name = Console.ReadLine(); // to read the value obtain as String from user

            Console.WriteLine($"Enter The quantity for {Name}!");
            int Quantity = Convert.ToInt32(Console.ReadLine()); // Number value should convert into int/double
                                                                // to read as real number not as string

            Console.WriteLine($"Enter the price of {Name}!");
            double Price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n");

            if (Food)
            {
                Console.WriteLine($"Is it {Name} => {Food}");
                Console.WriteLine($"The no. of {Name} is {Quantity}\n" +
                    $"Price for {Name} is Rs.{Price}\n" +
                    $"Total Price is Rs.{Price * Quantity}\n" +
                    $"Thank you for buying our {Name}{symbol}");
                Console.ReadKey(); 
            }
            
        }
    }
}
