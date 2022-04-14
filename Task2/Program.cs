int[,] FillArray(int row, int column)
{
    int[,] array = new int[row, column];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        array[i, j] = rnd.Next(-10, 11);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
        Console.Write($"{array[i, j]}\t");
        }
    Console.WriteLine();
    }
}

void LowestSum(int[,] arr)
{
    int strNum = 0;
    int temp = 0;
    int sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum = sum + arr[i,j];
        }
        if (temp > sum)
        {
            temp = sum;
            strNum = i;
        }
        sum = 0;
    }
    Console.WriteLine($"Индекс строки с меньшей суммой: {strNum}");
}

int[,] Array = FillArray(5,5);
PrintArray(Array);
Console.WriteLine();
LowestSum(Array);