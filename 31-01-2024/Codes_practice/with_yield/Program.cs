class Program
{
    public static void Main(string[] args)
    {
        var numbers = GetEvenNumbers(10);
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }
        static IEnumerable<int> GetEvenNumbers(int max)
        {
     
            for (int i = 0; i < max; i++)
            {
                if (i % 2 == 0)
                {
                    yield return i;
                }
            }
        
        }
    }
}