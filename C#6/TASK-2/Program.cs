using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your word that you want to change: ");
        string str = Console.ReadLine(); 
        string result = ChangeYouSymbToLower(str);
        Console.WriteLine(result);
    }

    public static string ChangeYouSymbToLower(string arg)
    {
        string lower = arg.ToLower();
        return lower;
    }
}
