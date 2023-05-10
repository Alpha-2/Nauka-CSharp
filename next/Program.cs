using System;

class Program
{
    static void Main(string[] args)
    {
        int liczba = 0;

        int number = int.Parse(Console.ReadLine());

        //while(true)
        //{
        //    if (a > 10)
        //    {
        //        break;
        //    }
        //    Console.WriteLine(a);
        //    a++;
        //}

        //for (int i = 0; i < 10; i++)
        //{
        //    if (i % 2 == 1)
        //    {
        //        continue;
        //    }
        //    Console.WriteLine(i);
        //}

        //jeden:
        //    Console.WriteLine("jeden");
        //    goto trzy;
        //Dwa:
        //    Console.WriteLine("Dwa");
        //trzy:
        //    Console.WriteLine("trzy");
        //    goto jeden;

        switch(liczba)
        {
            case 1:
                Console.WriteLine("Jeden");
                break;
            case 2:
                Console.WriteLine("22");
                break;

            default:
                Console.WriteLine("tak");
                break;

        }
        Console.ReadKey();
    }
}
