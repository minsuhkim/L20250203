using System.Drawing;

namespace L20250203
{
    internal class Program
    {

        static int Multiply(int a, int b)
        {
            return a * b;
        }

        static float Multiply(float a, float b)
        {
            return a * b;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(1, 2));
        }
    }
}