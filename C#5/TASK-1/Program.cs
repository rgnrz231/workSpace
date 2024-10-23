Console.WriteLine("Enter the line index: ");
int rowIndex = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter column index: ");
int colIndex = Convert.ToInt32(Console.ReadLine());

int[,] CreateRandom2DArray(int rows, int cols, int min, int max)
{
    int[,] array = new int[rows, cols];
    Random rnd = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            array[i, j] = rnd.Next(min, max);
        }
    }
    return array;
}


void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine(" |");
    }
}


int? SearchValueByIndex(int[,] array, int rowIndex, int colIndex)
{

    if (rowIndex < array.GetLength(0) && colIndex < array.GetLength(1))
    {
        return array[rowIndex, colIndex];
    }
    return null;

}

int[,] array = CreateRandom2DArray(2, 3, 1, 10);

PrintMatrix(array);

Console.WriteLine();

int? value = SearchValueByIndex(array, rowIndex, colIndex);

if (value.HasValue)
{
    Console.WriteLine($"Value by specified indices: {value.Value}");
}
else
{
    Console.WriteLine("Specified indices outside of the array boundaries.");
}