/*
 * 1. What are Parameter Modifiers?
When you pass a value to a method in C#, it is typically passed by value—which means that the method works with a copy of the data. However, sometimes, we want to pass a reference to the original data or control how the data is passed. This is where parameter modifiers come in.

Passing Notes in a Classroom
Imagine you are in a classroom, and a teacher asks you to share some notes with a friend. There are three ways you could do this:

Passing a copy of your notes (pass by value) – Your friend gets a photocopy of the notes, but if they write on it, your original notes remain unchanged.

Passing your original notebook (pass by reference using ref) – Your friend directly writes in your notebook, modifying your notes.

Giving your friend a blank sheet (out parameter) – You hand them a blank sheet, and they must write something on it before returning it to you.

Letting your friend read but not edit (in parameter) – You hand them your notes, but they can only read and not make any changes.

Now, let’s break down each of these parameter modifiers in detail.


 */


/*
ref Modifier(Passing by Reference)



void ModifyValue(ref int number)
{
    number += 10; // Modify the original value
}

int myNumber = 5;
ModifyValue(ref myNumber);
Console.WriteLine(myNumber); // Output: 15

Console.ReadKey();
*/


/*
 * 3. out Modifier (Passing by Reference with Initialization Inside the Method)
What is out?
The out modifier is similar to ref, but with one key difference: the method must assign a value to the out parameter before returning.


void GetValues(out int result)
{
    result = 42; // Must be assigned before the method exits
}
 
int myValue;
GetValues(out myValue);
Console.WriteLine(myValue); // Output: 42

Step-by-Step Explanation
The GetValues method accepts an integer by reference using out.

The method assigns 42 to result before exiting.

The original variable myValue is modified with the new value.
 * 
 * Example: Returning Multiple Values
void Calculate(int x, int y, out int sum, out int product)
{
    sum = x + y;
    product = x * y;
}
 
int a = 5, b = 3, sum, product;
Calculate(a, b, out sum, out product);
Console.WriteLine($"Sum: {sum}, Product: {product}");
// Output: Sum: 8, Product: 15
 */


/*
 4. in Modifier (Passing Read-Only Reference)
What is in?
The in modifier allows us to pass a variable by reference, but it cannot be modified inside the method. This is useful when passing large structures or objects efficiently without allowing them to be changed.

Basic Syntax
void PrintValue(in int number)
{
    Console.WriteLine(number); // Allowed
    // number += 10; // Not allowed (will cause a compile error)
}
 
int myNumber = 100;
PrintValue(in myNumber);
Key Points about in
✔️ The variable must be initialized before passing it.

✔️ The method cannot modify the parameter.

✔️ Useful for performance optimization when working with large objects.

*/


/*
 * 5. Comparing ref, out, and in
Feature                                    ref      out         in

Requires initialization before passing? ✅ Yes    ❌ No        ✅ Yes

Method must assign a value?              ❌ No    ✅ Yes       ❌ No

Can be modified inside the method?       ✅ Yes   ✅ Yes       ❌ No

Use case Modify existing data Return multiple values Pass large objects efficiently
 */

