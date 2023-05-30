using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Console Application!");

        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        Console.WriteLine("Hello, " + name + "!");

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
