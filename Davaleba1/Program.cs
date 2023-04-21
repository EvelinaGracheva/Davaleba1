// See https://aka.ms/new-console-template for more information

using System;

class Program
{
    static void Main(string[] args)
    {
        string Username = "Evelina";
        string Password = "Password";

        int attempts = 0;
        string username, password;
        do
        {
            Console.Write("Enter your username: ");
            username = Console.ReadLine();

            Console.Write("Enter your password: ");
            password = Console.ReadLine();

            if (username == Username && password == Password)
            {
                Console.WriteLine("Login successful!");
                return;
            }
            else
            {
                Console.WriteLine("Incorrect username or password. Please try again.");
                attempts++;
            }
        } 
        while (attempts < 5);

        Console.WriteLine("Error.Maximum number of login attempts exceeded.");
    }
}
