using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        char[,] array = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
            };
        string result = ConvertArrayToString(array);
        Console.WriteLine(result);
    }
    public static string ConvertArrayToString(char[,] arr)
    {
        StringBuilder res = new StringBuilder(); // ""

        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                res.Append(arr[i, j]);
            }
        }
        return res.ToString();
    }

}
