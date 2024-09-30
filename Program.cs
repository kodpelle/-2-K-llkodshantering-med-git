using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enkel kalkylator");
        Console.WriteLine("Ange operation (+, -, *, /");
        char operation = Console.ReadKey().KeyChar;
        Console.WriteLine("\nAnge det första talet");
        double num1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("\nAnge det andra talet");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;

        switch (operation)
        {
            case '+':
                result = num1 + num2;
                break;

            case '-':
                result = num1 - num2;
                break;

            case '*':
                result = num1 * num2;
                break;

            case '/':
                result = num1 / num2;
                break;
                
                default:
                Console.WriteLine("Ogiltig operation.");
                return;

        }
        Console.WriteLine($"Resultat: {result}");
        Console.ReadKey();

    }
}
