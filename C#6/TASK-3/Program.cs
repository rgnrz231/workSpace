using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your word that you want to change: ");
        string input = Console.ReadLine();

        bool isPalindrome = IsPalindrome(input);

        if (isPalindrome)
        {
            Console.WriteLine($"{input} is Palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} isn't Palindrome.");
        }
    }
    public static bool IsPalindrome(string str)
    {
        // Преобразуем строку в нижний регистр
        string lowerResult = ChangeYouSymbToLower(str);

        char[] charArray = lowerResult.ToCharArray();
        Array.Reverse(charArray);
        string reversedArray = new string(charArray);
        return lowerResult == reversedArray;
    }
}
