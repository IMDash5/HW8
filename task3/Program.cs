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

int[,] Multiply(int[,] arr1, int[,] arr2)
{
    int MultSum = 0;
    int[,] array = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int m = 0; m < arr1.GetLength(1); m++)
            {
                MultSum = MultSum + arr1[i, m] * arr2[m, j];
            }
            array[i,j] = MultSum;
            MultSum = 0;
        }
    }
    return array;
}


int[,] Array = FillArray(3,4);
int[,] Array2 = FillArray(4,3);
PrintArray(Array);
Console.WriteLine();
PrintArray(Array2);
int[,] Result = Multiply(Array, Array2);
Console.WriteLine();
PrintArray(Result);

