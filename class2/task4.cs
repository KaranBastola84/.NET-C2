namespace ConsoleApp1.class2
{
    public class task4
    {
        public void ArrayOperations()
        {
            // a single-dimensional integer array
            int[] numbers = { 5, 2, 9, 1, 5, 6 };

            Console.WriteLine("Original Array:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // Sorting the array
            Array.Sort(numbers);
            Console.WriteLine("Sorted Array:");
            foreach (int item in numbers)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("\n");

            // Reversing the array
            Array.Reverse(numbers);
            Console.WriteLine("Reversed Array (Descending):");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i] + " ");
            }

            // Array.IndexOf example
            int index = Array.IndexOf(numbers, 5);
            if (index != -1)
            {
                Console.WriteLine($"\n\nElement 5 found at index: {index}");
            }
            else
            {
                Console.WriteLine("\n\nElement 5 not found in the array.");
            }
        }
    }
}