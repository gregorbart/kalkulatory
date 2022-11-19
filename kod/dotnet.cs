using System;

// UŻYJ DOTNET 7.0 ABY DZIAŁAŁ DOBRZE!

namespace Kalkulator
{
    class Program
    {
        static void Main(string[] args)
        {

                double num1 = 0;
                double num2 = 0;
                double result = 0;

                Console.Write("Wprowadź Pierwszą liczbę: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Wprowadź Drugą liczbę: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Wprowadź Działanie: ");
                Console.WriteLine("\t+ : Dodaj");
                Console.WriteLine("\t- : Odejmnij");
                Console.WriteLine("\t* : Pomnórz");
                Console.WriteLine("\t/ : Podziel");
                Console.Write("Wprowadź Działanie: ");


                switch (Console.ReadLine())
                {
                    case "+":
                        result = num1 + num2;
                        Console.WriteLine($"{num1}+{num2}="+result);
                        break;
                    case "-":
                        result = num1 - num2;
                        Console.WriteLine($"{num1}-{num2}="+result);
                        break;
                    case "*":
                        result = num1 * num2;
                        Console.WriteLine($"{num1}*{num2}="+result);
                        break;
                    case "/":
                        result = num1 / num2;
                        Console.WriteLine($"{num1}/{num2}="+result);
                        break;
                    default:
                        Console.WriteLine("Nie prawidłowe działanie");
                        break;
                }
                Console.WriteLine("Kliknij enter aby wyłączyć aplikacje...");
                Console.ReadKey();
        }
    }
}
