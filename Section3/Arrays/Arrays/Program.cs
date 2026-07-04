Console.WriteLine("Arrays");

int[] myArray = new int[4];

myArray[0] = 2;
//myArray[4] = 3;


//we can write this both types 
string[] weeksName = ["Sun","Mon", "Tue", "Wed", "thu", "Fri", "sat"];
string[] weeksName2 = {"Sun", "Mon", "Tue", "Wed", "thu", "Fri", "Sat"};

//for(int i = 0;i<weeksName.Length;i++)
//{
//    Console.WriteLine(weeksName[i]);
//}

//foreach loop

foreach(var day in weeksName)
{
    Console.WriteLine(day);
}

//Console.WriteLine(weeksName2[0]);

Console.ReadKey();