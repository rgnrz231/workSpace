using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Ввод индекса строки от пользователя
        Console.WriteLine("Enter the line index: ");
        int rowIndex = Convert.ToInt32(Console.ReadLine());

        // Ввод индекса столбца от пользователя
        Console.WriteLine("Enter column index: ");
        int colIndex = Convert.ToInt32(Console.ReadLine());

        // Ввод минимального числа для генерации случайных чисел в массиве
        Console.WriteLine("Enter the minimal number for generating numbers to be used in the array: ");
        int minIndex = Convert.ToInt32(Console.ReadLine());

        // Ввод максимального числа для генерации случайных чисел в массиве
        Console.WriteLine("Enter the maximal number for generating numbers to be used in the array: ");
        int maxIndex = Convert.ToInt32(Console.ReadLine());

        // Создание двумерного массива с случайными значениями
        int[,] array = CreateRandom2DArray(rowIndex, colIndex, minIndex, maxIndex);

        // Вывод созданного массива на экран
        Console.WriteLine("Generated array:");
        PrintMatrix(array);
        Console.WriteLine();

        // 
        SwapRows(array, 0, 2);
        Console.WriteLine("Your reversed array:");
        PrintMatrix(array);
    }

    // Метод для создания двумерного массива с случайными значениями
    public static int[,] CreateRandom2DArray(int rows, int cols, int min, int max)
    {
        int[,] array = new int[rows, cols];
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                array[i, j] = rnd.Next(min, max); // Заполнение массива случайными числами
            }
        }
        return array; // Возврат созданного массива
    }

    public static void SwapRows(int[,] array, int row1, int row2)
    {
        int cols = array.GetLength(1); // Получаем количество столбцов
        for (int i = 0; i < cols; i++)
        {
            int temp = array[row1, i];
            array[row1, i] = array[row2, i];
            array[row2, i] = temp;
        }
    }



    // Метод для вывода двумерного массива на экран
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам
        {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++) // Проход по столбцам
            {
                Console.Write($"{matrix[i, j],5 }"); // Вывод элемента массива
            }
            Console.WriteLine(" |");
        }
    }
}
