namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 5;

            for (int i = 0; i < size; i++)
            {
                Console.Write($"{i + 1}열:");
                for (int j = 0; j < size - (i+1); j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
        }
    }
}