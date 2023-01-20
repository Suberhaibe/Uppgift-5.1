using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hur många antal meningar vill du skriva in");
        int antal = int.Parse(Console.ReadLine());
        string[] meningar = new string[antal];

        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine("Skriv in valfri mening");
            meningar[i] = Console.ReadLine();
        }
        Console.WriteLine("Här visas meningarna du har skrivit in");
        for (int i = 0; i < antal; i++)
        {
            Console.WriteLine($"\n{meningar[i]}");
        }
    }
}
