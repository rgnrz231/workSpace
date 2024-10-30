static int AckermannFunction(int firstNum, int secNum)
{
    if (firstNum == 0)
    {
        return secNum + 1;
    }
    else if (secNum == 0)
    {
        return AckermannFunction(firstNum - 1, 1);
    }
    else
    {
        return AckermannFunction(firstNum - 1, AckermannFunction(firstNum, secNum - 1));
    }
}

Console.WriteLine("Input your first number: ");
int firstInput = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input your second number: ");
int secInput = Convert.ToInt32(Console.ReadLine());

int result = AckermannFunction(firstInput, secInput);
Console.WriteLine($"The result of the Ackermann function is: {result}");