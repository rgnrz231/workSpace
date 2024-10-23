using System.Diagnostics.CodeAnalysis;

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
        SearchMinimalRow(array);
        
        
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

    // Мктод для поиска строки с на майшеньшей суммой элементов
    public static void SearchMinimalRow(int[,] array)
    {
        int minSum = int.MaxValue; // Инициализация переменной minSum на максимально возможное значение
        int minSumIndex = -1; // Инициализация индекса строки с наименьшей суммой
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int sum = 0; // Обнуление суммы для каждой строки
            for (int j = 0; j < array.GetLength(1); j++)
            {
                sum += array[i, j]; // Подсчет суммы элементов строки
            }
            if (sum < minSum)
            {
                minSum = sum; // Обновление минимальной суммы
                minSumIndex = i; // Обновление индекса строки с наименьшей суммой
            }
        }
        Console.WriteLine($"The string with the smallest sum of elements is indexed: {minSumIndex}, sum: {minSum}");
    }




    // Метод для вывода двумерного массива на экран
    public static void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++) // Проход по строкам
        {
            Console.Write("|");
            for (int j = 0; j < matrix.GetLength(1); j++) // Проход по столбцам
            {
                Console.Write($"{matrix[i, j],4}"); // Вывод элемента массива
            }
            Console.WriteLine("  |");
        }
    }
}
