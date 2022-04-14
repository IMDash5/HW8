int[,,] FillArray(int x, int y, int z)
{
    int[,,] array = new int[x, y, z];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int l = 0; l < array.GetLength(2); l++)
            {
                array[i, j, l] = rnd.Next(10, 100);
            }
        }
    }
    return array;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for(int l = 0; l < array.GetLength(2); l++)
            {
                Console.Write($"({i},{j},{l}) - {array[i, j, l]}\t");
            }
        }
    Console.WriteLine();
    }
}

int[,,] Array = FillArray(3,3,3);
PrintArray(Array);