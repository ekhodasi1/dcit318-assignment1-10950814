using System;

class TicketPriceCalculator
{
    static void Main(string[] args)
    {
        Console.Write("Enter your age: ");
        if (int.TryParse(Console.ReadLine(), out int age) && age > 0)
        {
            int price = (age <= 12 || age >= 65) ? 7 : 10;
            Console.WriteLine($"Your ticket price is: GHC{price}");
        }
        else
        {
            Console.WriteLine("Invalid age. Please enter a valid number greater than 0.");
        }
    }
}
