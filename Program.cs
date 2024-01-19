int integer1 = 0; int integer2 = 0;

Console.WriteLine("Simple Calculator in C#\r");
Console.WriteLine("------------------------\n");

// Ask the user to type the first number.
Console.WriteLine("Type a number, and then press Enter");
integer1 = Convert.ToInt32(Console.ReadLine());

// Ask the user to type the second number.
Console.WriteLine("Type another number, and then press Enter");
integer2 = Convert.ToInt32(Console.ReadLine());

// Ask the user to choose an option.
Console.WriteLine("Choose an option from the following list:");
Console.WriteLine("\ta - Addition");
Console.WriteLine("\ts - Subtraction");
Console.WriteLine("\tm - Multiplication");
Console.WriteLine("\td - Division");
Console.Write("Your option? ");

// Use a switch statement to do the math.
switch (Console.ReadLine())
{
    case "a":
        Console.WriteLine($"Your result: {integer1} + {integer2} = " + (integer1 + integer2));
        break;
    case "s":
        Console.WriteLine($"Your result: {integer1} - {integer2} = " + (integer1 - integer2));
        break;
    case "m":
        Console.WriteLine($"Your result: {integer1} * {integer2} = " + (integer1 * integer2));
        break;
    case "d":
        Console.WriteLine($"Your result: {integer1} / {integer2} = " + (integer1 / integer2));
        break;
}
// Wait for the user to respond before closing.
Console.Write("Press any key to close the Calculator console app...");
Console.ReadKey();