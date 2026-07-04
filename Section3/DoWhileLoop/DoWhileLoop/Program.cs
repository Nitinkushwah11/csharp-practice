/*
Console.WriteLine("Hello, World!");

int num;
do
{
    Console.WriteLine("Enter a possitive Nimber or whole number");
    num = int.Parse(Console.ReadLine());

}
while (num<=0);

Console.WriteLine("Finally we out the loop");
*/

//avgerage calculation

int sum = 0;
int count = 0;
int num=0;

do
{
    Console.WriteLine("Enter the Students Numbers");
    num = int.Parse(Console.ReadLine());
    if (num != -1)
    {
        sum += num;
        count++;
    }
} while (num != -1);

int avg = sum / count;
Console.WriteLine("The avgerage is " + avg);


Console.ReadKey();