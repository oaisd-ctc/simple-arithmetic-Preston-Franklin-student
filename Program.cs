using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Provide a number to perform addition");
        int addNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to add to " + addNumberOne + ".");
        int addNumberTwo = Convert.ToInt32(Console.ReadLine());
        int addResult = addNumberOne + addNumberTwo;
        Console.WriteLine("The final answer is " + addResult + ".");
        Console.WriteLine("Provide a number to perform subtraction");
        int subtractNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to subtract  from " + subtractNumberOne + ".");
        int subtractNumberTwo = Convert.ToInt32(Console.ReadLine());
        int subtractResult = subtractNumberOne - subtractNumberTwo;
        Console.WriteLine("The final answer is " + subtractResult + ".");
        Console.WriteLine("Provide a number to perform multiplication");
        int multiplyNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to multiply " + multiplyNumberOne + " by.");
        int multiplyNumberTwo = Convert.ToInt32(Console.ReadLine());
        int multiplyResult = multiplyNumberOne * multiplyNumberTwo;
        Console.WriteLine("The final answer is " + multiplyResult + ".");
        Console.WriteLine("Provide a number to perform integer division");
        int intDivideNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to divide " + intDivideNumberOne + " by.");
        int intDivideNumberTwo = Convert.ToInt32(Console.ReadLine());
        int intDivideResult = intDivideNumberOne / intDivideNumberTwo;
        Console.WriteLine("The final answer is " + intDivideResult + ".");
        Console.WriteLine("Provide a number to perform float division");
        float floatDivideNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to divide " + floatDivideNumberOne + " by.");
        float floatDivideNumberTwo = Convert.ToInt32(Console.ReadLine());
        float floatDivideResult = floatDivideNumberOne / floatDivideNumberTwo;
        Console.WriteLine("The final answer is " + floatDivideResult + ".");
        Console.WriteLine("Provide a number to perform modulus.");
        int modulusNumberOne = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Provide another number to perform modulus.");
        int modulusNumberTwo = Convert.ToInt32(Console.ReadLine());
        int modulusResult = modulusNumberOne % modulusNumberTwo;
        Console.WriteLine("The final answer is " + modulusResult + ".");
    }

}