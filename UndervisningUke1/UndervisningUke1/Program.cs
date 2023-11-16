// See https://aka.ms/new-console-template for more information
using System.Collections;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

//Menu();
ArrayTest();
void ArrayTest()
{
    var numbers = new int[10];
    var fruits = new string[] { "Banana", "Strawberry", "Cherry" };

    numbers[0] = 1;

    foreach(var fruit in fruits)
    {
        Console.WriteLine(fruit);
    }
}

void Menu()
{
    var isRunning = true;

    while (isRunning) {
        Console.WriteLine($"Choose a number between 0 -> 9, press x to finish ");
        //Random random = new Random();
        //var displayNum = random.Next(0, 10);

        var displayNum = Console.ReadLine();
        var displayInt = 0;
        if(displayNum == "x")
        {
            isRunning = false;
            break;
        }
        else
        {
            displayInt = int.Parse(displayNum);
        }

        Console.WriteLine("What do want to do?");
        Console.WriteLine("Add: + ");
        Console.WriteLine("Subtract: -");
        Console.WriteLine("Multiply: *");
        Console.WriteLine("Divide: /");

        var userInput = Console.ReadLine();

        Console.WriteLine($"What number do you want to {userInput}");

        var userNumber = Console.ReadLine();
        var userNumberAsInt = int.Parse(userNumber);

        if (userInput == "+")
        {
            displayInt = Add(displayInt, userNumberAsInt);
        }
        else if (userInput == "-")
        {
            displayInt = Subtract(displayInt, userNumberAsInt);
        }
        else if (userInput == "*")
        {
            displayInt = Multiply(displayInt, userNumberAsInt);
        }
        else if (userInput == "/")
        {
            displayInt = Divide(displayInt, userNumberAsInt);
        }

        Console.WriteLine("Displayvalue: " + displayInt);
    }
}

int Add(int firstNumber,int secondNumber)
{
    return firstNumber + secondNumber;
}
int Subtract(int firstNumber, int secondNumber)
{
    return firstNumber - secondNumber;
}
int Multiply(int firstNumber, int secondNumber)
{
    return firstNumber * secondNumber;
}
int Divide(int firstNumber, int secondNumber)
{
    return firstNumber / secondNumber;
}


