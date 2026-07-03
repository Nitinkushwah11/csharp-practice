bool isLoggedIn;

// Assign a value to isLoggedIn based on user input or condition
isLoggedIn = true;


//if (isLoggedIn)
//{
//    Console.WriteLine("Welcome back!");
//}
//else
//{
//    Console.WriteLine("Please log in.");
//}
//Console.ReadKey();// CTRL + F5 other option 

//Console.WriteLine("Enter the age");
//int age = int.Parse(Console.ReadLine());

//if (age > 18)
//{
//    Console.WriteLine("You can give the bote..");
//}else if(age<15)
//{
//    Console.WriteLine("Go to the Scholl");
//}
//else
//{
//    Console.WriteLine("You are not eligible");
//}

//Console.WriteLine("Successfully excicuted...");


//Console.ReadKey();


//nested if 

// See https://aka.ms/new-console-template for more information
/*
int num1 = 0;
int num2 = 0;

bool isEqual = num1 == num2;

bool isNotEqual = num1 != num2;

Console.WriteLine("Please enter a whole number");

if (num1 == int.Parse(Console.ReadLine()))
{
    Console.WriteLine("Numbers are equal!");

    Console.WriteLine("Please enter your age");
    int age = int.Parse(Console.ReadLine());
    if (age >= 18)
    {
        Console.WriteLine("Please enter your address, " +
            "so that we can send you the price!");
        string address = Console.ReadLine();
    }
    else
    {
        Console.WriteLine("Sorry, you can't get your price due to your age!");
    }

}
else
{
    Console.WriteLine("Numbers aren't equal");
}
*/


/*
 * Console.WriteLine("How old are you? Write a whole number");
int age = int.Parse(Console.ReadLine());
bool isWithParents = false;

if (age >= 18)
{
    Console.WriteLine("Go party in the club!");
}
else if (age >= 13)
{
    Console.WriteLine("Are you with your parents? Answer with y or n");
    string isWithParentsString = Console.ReadLine();
    if (isWithParentsString == "y" || isWithParentsString == "Y")
    {
        Console.WriteLine("Go party in the club with your parents!");
    }
    else
    {
        Console.WriteLine("No party for you today");
    }

}
else
{
    Console.WriteLine("Go party in Kindergarten!");
}

Console.ReadKey();
*/

int age = 199;
if (age == 18)
{

    Console.WriteLine("1");
    age = 17;
}
else if (age == 17)

    Console.WriteLine("2");
else if (age == 19)

    Console.WriteLine("3");
else

    Console.WriteLine("Else 4");







Console.ReadKey();




