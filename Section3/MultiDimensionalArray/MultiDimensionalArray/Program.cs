

int[,] array2Ddeclaration = new int[4,6];
int[,] array2D = { { 1, 2 }, { 2, 3 } };

//Console.WriteLine(array2D[1,0]);

//3D dimensional initialized 3D array 

int[,,] array3DDimensional = new int[3, 3, 3];

string[,,] array3D =
{
    {
        {"000","001","010" }
      
    },
    {
        {"100","101","121" }
    }
};

//Console.WriteLine(array3D[0, 0,0]);


//TIC TAK TOE field

string[,] tictaktoefiled =
{
    {"O","X","X" },
    {"O","X","O" },
    {"X","O","O" }


};

//Console.WriteLine(tictaktoefiled[0,0]);

//jagged array

int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[]{1,2,3,4};
jaggedArray[1] = new int[]{ 1,2};
jaggedArray[2] = new int[]{ 1,2,3,4,5,6};

for(int i = 0; i< jaggedArray.Length;i++)
{
    Console.Write("Row " + i + " : ");
    for(int j = 0; j < jaggedArray[i].Length;j++)
    {
        Console.Write(jaggedArray[i][j]+ " ");
    }

    Console.WriteLine();
}



Console.ReadKey();
