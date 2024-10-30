using System;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your sentence that you want to reverse: ");
        string input = Console.ReadLine();
        string reverseResult = reverseString(input);

        Console.WriteLine($"Your reversed sentece: {reverseResult}");
    }
    public static string reverseString(string str)
    {
        string[] spacedWords = str.Split(' '); // разбиение строки на слова

        string result = string.Empty;
        for (int i = spacedWords.Length - 1; i >= 0; i--)
        {
            result += spacedWords[i] + " ";
        }
        result = result.Trim(); // удаляет лишний пробел в конце

        return result;
    }
}


