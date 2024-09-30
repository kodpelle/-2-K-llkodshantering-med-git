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
    //la till ref-modiferare för att de lagrar korrekt resultat i num2
    public double mDivision(ref double num1, ref double num2)
    {
        while (num2 == 0)
        {
            Console.WriteLine("Du kan inte dividera med 0, ange ett giltigt tal");
            num2 = Convert.ToDouble(Console.ReadLine());
        }
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

    //Metod för felhantering vid val av operator.
    public char ValidOperation()
    {
        Console.WriteLine("Ange operation: (+, -, *, /");
        char operation;
        do
        {
            operation = Console.ReadKey().KeyChar;
            //Snygggar till konsolen
            Console.WriteLine();
            //om man ger en ogiltig inmatning så får man ett meddelande
            if (operation != '+' && operation != '-' && operation != '*' && operation != '/')
            {
                Console.WriteLine("Ogiltig inmatning, ange: +, -, * eller /");
            }
        }
        //kör loopen tills man angett korrekt operator
        while (operation != '+' && operation != '-' && operation != '*' && operation != '/');
        //returnar korrekt operator
        return operation;
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
        //instanser för användning av metoder i klasserna
        Operation op = new Operation();
        inputs Inputs = new inputs();

        Console.WriteLine("Enkel kalkylator");
        //Hämtar och validerar operatorn
        char operation = Inputs.ValidOperation();

        //Hämtar och validerar de två talen
        double num1 = Inputs.ValidDouble("Ange det första talet");
        double num2 = Inputs.ValidDouble("Ange det andra talet");

        double result = 0;

        switch (operation)
        {
            case '+':
                result = op.mAddition(num1, num2);
                break;

            case '-':
                result = op.mSubtract(num1, num2);
                break;

            case '*':
                result = op.mMultiplication(num1, num2);
                break;

            case '/':
                result = op.mDivision(ref num1, ref num2);
                break;
                
                default:
                Console.WriteLine("Ogiltig operation.");
                return;

        }
        Console.WriteLine($"Resultatet av {num1}{operation}{num2} = {result}");
        Console.ReadKey();

    }
}
