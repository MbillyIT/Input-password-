using System;

class Program
{
    static void Main()
    {
        Console.InputEncoding = System.Text.Encoding.UTF8;
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.WriteLine("введіть пароль:");
        string input = Console.ReadLine();

        if (input == "admin")
        {
            Console.WriteLine("Пароль правильний:");
        }
        else Console.WriteLine("Пароль не є правильним");
    }
}