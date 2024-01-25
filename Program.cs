using System;

class Calculator
{
    public static (int result, string operationName) DoOperation(int num1, int num2, int op)
    {
        int result = 0;
        string operationName = "";

        //determines the operation to be performed based on the op parameter
        switch (op)
        {
            case 1:
                result = num1 + num2;
                operationName = "Addition";
                break;
            case 2:
                result = num1 - num2;
                operationName = "Subtraction";
                break;
            case 3:
                result = num1 * num2;
                operationName = "Multiplication";
                break;
            case 4:

                //makes sure num2 is not 0
                if (num2 != 0)
                {
                    result = num1 / num2;
                    operationName = "Division";
                }
                else
                {
                    Console.WriteLine("Division by zero is not allowed.");
                }
                break;
            
            //triggers when the provided input is not between 1 and 4
            default:
                Console.WriteLine("Invalid operation number.");
                break;
        }

        //returns the result and the operationName
        return (result, operationName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        bool endApp = false;
        Console.WriteLine("-------------------------");
        Console.WriteLine("| * Simple Calculator * |");
        Console.WriteLine("-------------------------\n");

        while (!endApp)
        {
            int numInput1 = 0;
            int numInput2 = 0;
            int result = 0;
            string operationName = "";
            int option = 0;

            Console.Write("Enter the first number: ");
            while (!int.TryParse(Console.ReadLine(), out numInput1))
            {
                Console.Write("Not valid input. Please enter an integer value: ");
            }

            Console.Write("Enter the second number: ");
            while (!int.TryParse(Console.ReadLine(), out numInput2))
            {
                Console.Write("Not valid input. Please enter an integer value: ");
            }

            Console.WriteLine("Choose an operation");
            Console.WriteLine("\t1. Addition");
            Console.WriteLine("\t2. Subtraction");
            Console.WriteLine("\t3. Multiplication");
            Console.WriteLine("\t4. Division");
            Console.Write("\nEnter the operation number (1-4): ");


            //parse the input as an integer then store in the option variable
            //also checks if the input is between 1 and 4
            while (!int.TryParse(Console.ReadLine(), out option) || option < 1 || option > 4)
            {
                Console.Write("Invalid input. Please enter a number between 1 and 4: ");
            }

            //After the loop, a try-catch block is used to handle potential exceptions that might occur during the execution of the calculator operation.
            try
            {
                var (resultValue, operation) = Calculator.DoOperation(numInput1, numInput2, option);
                result = resultValue;
                operationName = operation;

                Console.WriteLine("\nResult of {0}: {1}\n", operationName, result);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred: " + e.Message);
            }

            Console.Write("Press 'n' then Enter to close the app, OR press any other key and Enter to continue: ");
            if (Console.ReadLine().ToLower() == "n") endApp = true;

            Console.WriteLine("\n");
        }
    }
}
