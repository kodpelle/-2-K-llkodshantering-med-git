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
    //Ser till att man inte kan dela med 0
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
class inputs
{
    //Metod för att hantera inmatning av ett tal och felhantera
    public double ValidDouble(string prompt)
    {
        double number;
        Console.WriteLine(prompt);
        //använder metoden TryDouble för att felhantera ogiltig inmatning. När man gjort rätt inmatning så returneras number.
        while (!TryDouble(Console.ReadLine(), out number))
        {
            Console.WriteLine("Felaktig inmatning, försök igen!");
        }
        return number;
    }


    // skapar en metod för TryParse för att kunna kalla på den när jag vill felhantera
    public bool TryDouble(string input, out double result)
    {
        return double.TryParse(input, out result);
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
