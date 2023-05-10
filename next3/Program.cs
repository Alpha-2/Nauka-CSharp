using System;

namespace next3
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[,] tab = new int[2, 3];
            //tab[0,0] = 1;
            //tab[0, 1] = 1;
            //tab[0,2] = 1;
            //tab[1,0] = 10;
            //tab[1,1] = 10;
            //tab[1, 2] = 10;

            //for (int i = 0; i < tab.GetLength(0); i++)
            //{
            //    for (int j = 0; j < tab.GetLength(1); j++)
            //    {
            //        Console.Write(tab[i,j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            int[][] tab = new int[2][];

            tab[0] = new int[3];
            tab[1] = new int[2];

            tab[0][0] = 12;

            Console.ReadKey();
        }
    }
}
