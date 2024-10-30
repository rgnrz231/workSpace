static void PrintNaturalNumbersRange(int firstNum, int secNum)
{
    if (firstNum <= secNum)
    {
        Console.Write($"{firstNum} ");
        if (firstNum != secNum) // условие для предотвращения бесконечной рекурсии    
        {
            PrintNaturalNumbersRange(firstNum + 1, secNum);
        }
    }
    else
    {
        Console.Write($"{firstNum} ");
        if (firstNum != secNum) // условие для предотвращения бесконечной рекурсии
        {
            PrintNaturalNumbersRange(firstNum - 1, secNum);
        }
    }
}

Console.WriteLine("Input your first integer number: ");
int firstInput = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input your second integer number: ");
int secInput = Convert.ToInt32(Console.ReadLine());

PrintNaturalNumbersRange(firstInput, secInput);