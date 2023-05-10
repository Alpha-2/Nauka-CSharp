using System;

namespace ObiektoweProgramowanieCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Napisz tak albo nie");
                string userInput = Console.ReadLine();

                Reputation userAnswer = new Reputation(userInput);

                switch (userAnswer.reply)
                {
                    case "tak":
                        Console.Clear();
                        Console.WriteLine("Tak");
                        break;
                    case "nie":
                        Console.Clear();
                        Console.WriteLine("Nie");
                        break;
                    case "exit":
                        Reputation.IsEnabled = false;
                        break;
                    default:
                        Console.Clear();
                        Console.WriteLine("błąd!");
                        break;
                }
                if (Reputation.IsEnabled == false)
                    Environment.Exit(0);
            }
            while (Reputation.IsEnabled);
        }
    }
}
