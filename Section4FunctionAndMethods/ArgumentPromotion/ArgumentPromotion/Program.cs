Console.WriteLine("Hello, World!");
void DisplayNumber(double number)
{
    Console.WriteLine("The number is: " + number);
}

int myInt = 42;
DisplayNumber(myInt); // Implicit promotion from int to double

//===========

void CalculateArea(double radius)
{
    double area = Math.PI * radius * radius;
    Console.WriteLine("The area is: " + area);
}

int myRadius = 5;
CalculateArea(myRadius); // Implicitly promoted from int to double  
                         //The area is: 78.53981633974483

//=================================
/*
Argument Promotion in Method Overloading
void PrintValue(int value)
{
    Console.WriteLine("Integer: " + value);
}

void PrintValue(double value)
{
    Console.WriteLine("Double: " + value);
}

float myFloat = 10.5f;
PrintValue(myFloat); // Promoted to double

*/

/*
 * 
 * When using explicit casting, you are forcing a conversion, which may lead to data loss:
   int x = 10;
   double y = (double)x; // Explicit casting
 */