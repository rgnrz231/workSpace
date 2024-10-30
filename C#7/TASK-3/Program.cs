using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Input your numbers separated by space: ");
        string inputArray = Console.ReadLine();
        int[] array = ConvertToIntArray(inputArray);
        ReverseArray(array, 0, array.Length - 1);
        // Печать результата
        Console.WriteLine("Reversed array: " + string.Join(" ", array));
    }

    static void ReverseArray(int[] array, int start, int end)
    {
        // Условие завершения
        if (start >= end) return;

        // Обмен первых и последних элементов
        int temp = array[start];
        array[start] = array[end];
        array[end] = temp;

        // Рекурсивный вызов для подмассива
        ReverseArray(array, start + 1, end - 1);
    }

    static int[] ConvertToIntArray(string inpValue)
    {
        string[] numbers = inpValue.Split(' ');
        int[] arrValue = new int[numbers.Length];
        for (int i = 0; i < arrValue.Length; i++)
        {
            arrValue[i] = Convert.ToInt32(numbers[i]);
        }
        return arrValue;
    }
}