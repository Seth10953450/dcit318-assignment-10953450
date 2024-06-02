using System;

namespace TicketPriceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your age: ");
            string input = Console.ReadLine() ?? string.Empty; 
            if (int.TryParse(input, out int age) && age >= 0)
            {
                int ticketPrice = (age <= 12 || age >= 65) ? 7 : 10;
                Console.WriteLine($"Ticket Price: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid age.");
            }
        }
    }
}
