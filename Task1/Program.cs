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

int[,] Filtration(int[,] arr)
{
    int temp = 0;
    int max = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) ; j++)
        {
            max = arr[i,j];
            for(int l = j; l < arr.GetLength(1); l++)
            {
                if (max < arr[i,l])
                {
                    temp = max;
                    max = arr[i,l];
                    arr[i,l] = temp;
                }
            }
            arr[i,j] = max;
        }   
    }
    return arr;
}

int[,] Array = FillArray(5,5);
PrintArray(Array);
Console.WriteLine();
Filtration(Array);
PrintArray(Array);