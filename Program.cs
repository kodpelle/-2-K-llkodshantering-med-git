using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//skapar simpla metoder för + - * & / istället för att göra uträkning i switch
class Operation
{
    public double mAddition(double num1, double num2)
    {
        return num1 + num2;
    }
    public double mSubtract(double num1, double num2)
    {
        return num1 - num2;
    }
    public double mMultiplication(double num1, double num2)
    {
        return num1 * num2;
    }
    public double mDivision(double num1, double num2)
    {
        do
        {
            if (num2 == 0)
            {
                Console.WriteLine("Du kan inte dividera med 0, försök igen");
                num2 = Convert.ToDouble(Console.ReadLine());
            }
        }
        while (num2 == 0);
        return num1 / num2;
    }
}
internal class Program
{
    static void Main(string[] args)
    {
        Operation op = new Operation();
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
