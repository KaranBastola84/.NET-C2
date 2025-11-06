using ConsoleApp1;
using ConsoleApp1.class2;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("\n Task 1 Output:\n ");

        // Creating an instance of task1 and displaying info
        task1 task1 = new();
        task1.DisplayInfo();

        Console.WriteLine("\n Task 2 Output:\n ");

        //Task 2
        Circle c = new();
        
        // Attempting to modify the PI constant value
        // Circle.PI = 3.14159; // Uncomment to test the constant error:
        // This will cause a compilation error
        //The left-hand side of an assignment must be a variable, property or indexer (CS0131)
        
        Console.Write("Enter the radius of the circle: ");
        double radius = Convert.ToDouble(Console.ReadLine()); // take input from user
        Console.WriteLine($"Radius = {radius}:");
        Console.WriteLine($"Area of circle = {c.CalculateArea(radius)}");
        Console.WriteLine($"Perimeter of circle = {c.CalculatePerimeter(radius)}");

        Console.WriteLine("\n Task 3 Output:\n ");

        // Task 3
        task3 task3 = new();
        task3.DataTypes();

        Console.WriteLine("\n Task 4 Output:\n ");

        // Task 4
        task4 task4 = new();
        task4.ArrayOperations();
    }
}