using System;

class TriangleTypeIdentifier
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the lengths of the three sides of the triangle:");

        Console.Write("Side 1: ");
        double side1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 2: ");
        double side2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Side 3: ");
        double side3 = Convert.ToDouble(Console.ReadLine());

        if (side1 <= 0 || side2 <= 0 || side3 <= 0)
        {
            Console.WriteLine("Sides must be positive numbers.");
            return;
        }

        if (side1 + side2 > side3 && side2 + side3 > side1 && side1 + side3 > side2)
        {
            if (side1 == side2 && side2 == side3)
                Console.WriteLine("The triangle is Equilateral.");
            else if (side1 == side2 || side2 == side3 || side1 == side3)
                Console.WriteLine("The triangle is Isosceles.");
            else
                Console.WriteLine("The triangle is Scalene.");
        }
        else
        {
            Console.WriteLine("The lengths do not form a valid triangle.");
        }
    }
}
