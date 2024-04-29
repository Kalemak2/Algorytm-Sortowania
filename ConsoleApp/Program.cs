namespace ConsoleApp
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            int[] ints = new int[10];
            while (n < ints.Length)
            {
                Console.Write($"Podaj {n + 1} liczbe:");
                int.TryParse(Console.ReadLine(), out ints[n]);
                n = n + 1;
            }

            Sort.MaxNumber(ints);

            foreach (int i in ints)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
