using Microsoft.Win32;
using System;

namespace CookieClicker
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int cookies = 0;
            int clickValue = 1;

            Console.Title = "Cookie Clicker";

            RegistryKey key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\CookieClicker");

            if (key != null)
            {
                string cookiesValue = key.GetValue("Cookies") as string;
                if (int.TryParse(cookiesValue, out int cookiesParsed))
                {
                    cookies = cookiesParsed;
                    Console.WriteLine($"Z tvé předchozí hry ti zbylo: {cookies} sušenek.");
                }
                key.Close();
            }

            RegistryKey subKey = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\CookieClicker");

            while (true)
            {
                Console.WriteLine($"AKtuální stav sušenek: {cookies}");
                Console.Write("Přidat (A), Odejít (E) nebo Resetovat (R)? ");
                string action = Console.ReadLine()?.ToLower();

                switch (action)
                {
                    case "a":
                        cookies += clickValue;
                        if (cookies >= 100)
                        {
                            Console.WriteLine("BOOST!");
                            clickValue += 2;
                            cookies -= 100;
                        }
                        break;
                    case "e":
                        subKey.SetValue("Cookies", cookies.ToString());
                        return;
                    case "r":
                        try
                        {
                            subKey.SetValue("Cookies", "0");
                            Console.WriteLine("Sušenky vyresetovány!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Chyba během resetu: {e}");
                        }
                        cookies = 0;
                        clickValue = 1;
                        break;
                    default:
                        Console.WriteLine("Neplatný příkaz!");
                        break;
                }

            }
        }
    }
}
