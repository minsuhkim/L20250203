namespace L20250203
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            int[,] data = new int[size,size];
            
            for(int i=0; i<size; i++)
            {
                for(int j=0; j<size; j++)
                {
                    data[i, j] = i * 10 + j + 1;
                }
            }

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(data[i, j]);
                    Console.Write('\t');
                }
                Console.WriteLine();
            }
        }
    }
}