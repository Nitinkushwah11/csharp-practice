
            // TODO: Implement the calculator logic here
            Console.WriteLine("Enter the first number:");
            int first = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine("Choose an operation: +, -, *, /");
            string operation = Console.ReadLine();


            if (operation == "/" && second == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
            }
            else if (operation == "/")
            {
                Console.WriteLine("Result: " + (first / second));
            }
            else if (operation == "+")
            {
                Console.WriteLine("Result: " + (first + second));
            }
            else if (operation == "-")
            {
                Console.WriteLine("Result: " + (first - second));
            }
            else if (operation == "*")
            {
                Console.WriteLine("Result: " + (first * second));
            }
            else
            {
                Console.WriteLine("Invalid operation. Please choose +, -, *, or /.");
            }
Console.ReadKey();
