using System;

namespace Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Zastav Sumka";
            ZastavSumka();
        }

        static void ZastavSumka()
        {
            Console.WriteLine("Zvol si směr východ/západ/sever/jih");
            string smer = Console.ReadLine().ToLower();

            switch (smer)
            {
                case "východ":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Bohužel, potkal jsi Broučka a nesthil jsi zábranit příchodu Sumka.");
                    Console.ReadLine();
                    break;
                case "západ":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Skvělé, podařilo se ti zlikvidovat sumčí knír.");
                    Console.ReadLine();
                    break;
                case "sever":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Natrefil jsi na kunu a potřebovala nakrmit, Sumek se stihl dostavit na místo včas :(");
                    Console.ReadLine();
                    break;
                case "jih":
                    Console.BackgroundColor = ConsoleColor.DarkGreen;
                    Console.WriteLine("Potkal jsi Salima a společně jste Sumka zastavili!");
                    Console.ReadLine();
                    break;
                case "exit":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Neplatný příkaz!");
                    ZastavSumka();
                    break;
            }
        }
    }
}

