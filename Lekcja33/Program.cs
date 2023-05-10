using System;

namespace Lekcja33
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine($"Wynik = {Dzielenie(5)}");
            }
            catch (DivideByFiveException ex)
            {
                Console.WriteLine("Nie dziel przez 5!\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

        public static float Dzielenie(int a)
        {
            if (a == 5)
            {
                throw new DivideByFiveException("www");
            }
            return 10 / a;
               
        }
    }
    class DivideByFiveException : Exception
    {
        public DivideByFiveException()
        {
        }

        public DivideByFiveException(string message) : base(message)
        {
        }

        public DivideByFiveException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
