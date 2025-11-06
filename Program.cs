using System.Diagnostics;
using ConsoleApp1;
using ConsoleApp1.class2;

class Program
{
    public static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("=== C# Task Menu ===");
            Console.WriteLine("1. Task 1: String Interpolation");
            Console.WriteLine("2. Task 2: Constants and Circle");
            Console.WriteLine("3. Task 3: Data Types and Type Conversion");
            Console.WriteLine("4. Task 4: Arrays and Array Methods");
            Console.WriteLine("5. Task 5: DateTime Operations");
            Console.WriteLine("6. Task 6: Generic Collections (List & Dictionary)");
            Console.WriteLine("0. Exit");
            Console.Write("\nEnter your choice: ");

            string choice = Console.ReadLine() ?? "";
            Console.Clear();

            switch (choice)
            {
                case "1":
                    Console.WriteLine("\n Task 1 Output:\n ");
                    task1 task1 = new();
                    task1.DisplayInfo();
                    break;
                case "2":
                    Console.WriteLine("\n Task 2 Output:\n ");
                    Circle task2 = new();
                    Console.Write("Enter the radius of the circle: ");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Radius = {radius}:");
                    Console.WriteLine($"Area of circle = {task2.CalculateArea(radius)}");
                    Console.WriteLine($"Perimeter of circle = {task2.CalculatePerimeter(radius)}");
                    break;
                case "3":
                    Console.WriteLine("\n Task 3 Output:\n ");
                    task3 task3 = new();
                    task3.DataTypes();
                    break;
                case "4":
                    Console.WriteLine("\n Task 4 Output:\n ");
                    task4 task4 = new();
                    task4.ArrayOperations();
                    break;
                case "5":
                    Console.WriteLine("\n Task 5 Output:\n ");
                    task5 task5 = new();
                    task5.DateTimeExample();
                    break;
                case "6":
                    Console.WriteLine("\n Task 6 Output:\n ");
                    task6 task6 = new();
                    task6.GenericCollectionExample();
                    break;
                case "0":
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
            Console.WriteLine("\nPress any key to return to the menu...");
            Console.ReadKey();
        }
    }
}