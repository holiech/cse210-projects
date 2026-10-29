using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is Your First Name.");
        string firstName = Console.ReadLine();

        Console.Write("What ia your last name");
        string lastName = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {lastName} {firstName}");
    }
}