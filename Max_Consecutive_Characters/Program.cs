namespace Max_Consecutive_Characters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the string: ");
            string line = Console.ReadLine();
            int max = int.MinValue;
            for(int i = 0; i < line.Length - 1; i++)
            {
                int current = 1;
                if (line[i] != line[i + 1])
                {
                    current++;
                    for(int j = i + 1; j < line.Length - 1; j++)
                    {
                        if (line[j] != line[j + 1])
                            current++;
                        else break;
                    }
                }
                if (max < current)
                    max = current;
            }
            Console.WriteLine("Max number of consecutive characters: " + max);
        }
    }
}