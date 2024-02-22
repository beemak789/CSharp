Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");

var firstAsText = Console.ReadLine();
// what if the user does not input a number?
var number1 = int.Parse(firstAsText);

Console.WriteLine("Input the second number");
var secondAsText = Console.ReadLine();
var number2 = int.Parse(secondAsText);

Console.WriteLine("What do you want to do with those numbers?");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");

var choice = Console.ReadLine();

    if (choice == "A" || choice == "a")
    {
        var sum = number1 + number2;
        PrintFinalEquation(number1, number2, sum, "+");
    }
    else if (choice == "S" || choice == "s")
    {
        var difference = number1 - number2;
        PrintFinalEquation(number1, number2, difference, "-");
    }
    else if (choice == "M" || choice == "m")
    {
        var product  = number1 * number2;
        PrintFinalEquation(number1, number2, product, "*");
    }
    else
    {
        Console.WriteLine("Invalid option");
    }


    //operator is a reserved keyword 
void PrintFinalEquation (int num1, int num2, int result, string @operator)
{
    Console.WriteLine($"{num1} {@operator} {num2} = {result}");
}



Console.WriteLine("Press any key to close");
Console.ReadKey();