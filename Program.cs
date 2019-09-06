using System;

namespace C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Enter depth of piramid in integers only");
            //int depth = Convert.ToInt16(Console.ReadLine());
            BuildPiramid(5);
            Console.ReadKey();
        }

        static void BuildPiramid(int depth)
        {
            for(int i = 0; i<depth;i++)
            {
                Console.WriteLine();
                for(int j=0;j<i;j++)
                {
                     Console.Write("*");
                }
            }
        }
    }
}
