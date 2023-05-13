namespace DecimalToBase
{
    class Prgram
    {
        static void Main(string[] args)
        {
            int number, baseNum, remainder;
            string newNumber = string.Empty;
            Console.Write("Enter the number: ");
            number = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter base: ");
            baseNum = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % baseNum;
                number /= baseNum;
                newNumber += remainder;
            }
            newNumber = new string(newNumber.Reverse().ToArray());
            Console.WriteLine(newNumber);
        }
    }
}