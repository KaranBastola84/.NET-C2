namespace ConsoleApp1.class2
{
    public class task3
    {
        public void DataTypes()
        {
            // Declaring variables of different data types
            byte byteVar = 255; // 1 byte
            short shortVar = 32767; // 2 bytes
            int intVar = 2147483647; // 4 bytes
            long longVar = 9223372036854775807; // 8 bytes
            float floatVar = 3.40282347E+38F; // 4 bytes
            double doubleVar = 1.7976931348623157E+308; // 8 bytes
            decimal decimalVar = 79228162514264337593543950335M; // 16 bytes
            char charVar = 'A'; // 2 bytes
            bool boolVar = true; // 1 byte
            string stringVar = "Hello, World!"; // reference type

            string intToString = intVar.ToString(); // Converting int to string
            double stringToDouble = Convert.ToDouble("12345.67"); // Converting string to double

            // Displaying the values
            Console.WriteLine("Data Types and Their Values:");
            Console.WriteLine($"Byte: {byteVar}");
            Console.WriteLine($"Short: {shortVar}");
            Console.WriteLine($"Int: {intVar}");
            Console.WriteLine($"Long: {longVar}");
            Console.WriteLine($"Float: {floatVar}");
            Console.WriteLine($"Double: {doubleVar}");
            Console.WriteLine($"Decimal: {decimalVar}");
            Console.WriteLine($"Char: {charVar}");
            Console.WriteLine($"Bool: {boolVar}");
            Console.WriteLine($"String: {stringVar}");
            Console.WriteLine($"Int to String: \"{intToString}\" (Type: {intToString.GetType()})");
            Console.WriteLine($"String to Double: {stringToDouble} (Type: {stringToDouble.GetType()})   ");
        } 
    }
}