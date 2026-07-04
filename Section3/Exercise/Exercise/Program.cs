Console.WriteLine("Hello, World!");
int[,] array2D = {
                                {1,2,3},
                                {4,5,6},
                                {7,8,9}

            };

Console.WriteLine(array2D.Length);
Console.WriteLine(array2D.Rank);
//GetLength
int sum = 0;
for (int i = 0; i < array2D.GetLength(0); i++)
{
    for (int j = 0; j < array2D.GetLength(1); j++)
    {
        sum += array2D[i, j];
        
    }

    Console.WriteLine(sum);
    sum = 0;
}

Console.ReadKey();