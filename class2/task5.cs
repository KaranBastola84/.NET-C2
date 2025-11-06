namespace ConsoleApp1.class2
{
    public class task5
    {
        public void DateTimeExample()
        {
            DateTime Birthday = new(2004, 08, 14);
            DateTime now = DateTime.Now;
            TimeSpan age = now - Birthday;
            int ageInYears = (int)(age.TotalDays / 365.25);

            Console.WriteLine($"Birthday: {Birthday.ToShortDateString()}");
            Console.WriteLine($"Current Date and Time: {now}");
            Console.WriteLine($"Age in years: {ageInYears} years");

            DateTime newDate = Birthday.AddDays(10);
            Console.WriteLine($"Date after adding 10 days to birthday: {newDate.ToShortDateString()}");
        }
    }
}