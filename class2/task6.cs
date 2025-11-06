namespace ConsoleApp1.class2
{
    public class task6
    {
        public void GenericCollectionExample()
        {
            List<string> fruits = new List<string> { "Apple", "Banana", "Cherry" };

            // Adding and removing elements
            fruits.Add("Mango");

            fruits.Remove("Cherry");

            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Dictionary example
            Dictionary<int, string> fruitsDict = new Dictionary<int, string>
            {
                { 1, "Apple" },
                { 2, "Banana" },
                { 3, "Mango" }
            };

            fruitsDict.Add(4, "Orange");

            foreach (var pair in fruitsDict)
            {
                Console.WriteLine($"Key: {pair.Key}, Value: {pair.Value}");
            }

        }

    }
}