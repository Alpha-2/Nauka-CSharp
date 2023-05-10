using System;

namespace Tak
{
    class Program
    {
        static void Main(string[] args)

        {
            // deklaracja zmiennych

            float maxFloatValue = float.MaxValue;
            float minFloatValue = float.MinValue;
            int maxIntValue = int.MaxValue;
            int minIntValue = int.MinValue;
            short maxShortValue = short.MaxValue;
            short minShortValue = short.MinValue;
            long maxLongValue = long.MaxValue;
            long minLongValue = long.MinValue;
            byte maxByteValue = byte.MaxValue;
            byte minByteValue = byte.MinValue;

            Console.WriteLine("Maksymalna wartość Float: " + maxFloatValue);
            Console.WriteLine("Maksymalna wartość Int: " + maxIntValue);
            Console.WriteLine("Maksymalna wartość Short: " + maxShortValue);
            Console.WriteLine("Maksymalna wartość Long: " + maxLongValue);
            Console.WriteLine("Maksymalna wartość Byte: " + maxByteValue);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Minimalna Wartość Float: " + minFloatValue);
            Console.WriteLine("Minimalna Wartość Int: " + minIntValue);
            Console.WriteLine("Minimalna Wartość Short: " + minShortValue);
            Console.WriteLine("Minimalna Wartość Long: " + minLongValue);
            Console.WriteLine("Minimalna Wartość Byte: " + minByteValue);

            Console.ReadKey();
        }
    }
}
