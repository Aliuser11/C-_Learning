//// Declare variables and then initialize to zero.
//double num1 = 0; double num2 = 0;

//// Display title as the C# console calculator app.
//Console.WriteLine("Console Calculator in C#\r");
//Console.WriteLine("------------------------\n");

//// Ask the user to type the first number.
//Console.WriteLine("Type a number, and then press Enter");
//num1 = Convert.ToDouble(Console.ReadLine());

//// Ask the user to type the second number.
//Console.WriteLine("Type another number, and then press Enter");
//num2 = Convert.ToDouble(Console.ReadLine());

//// Ask the user to choose an option.
//Console.WriteLine("Choose an option from the following list:");
//Console.WriteLine("\ta - Add");
//Console.WriteLine("\ts - Subtract");
//Console.WriteLine("\tm - Multiply");
//Console.WriteLine("\td - Divide");
//Console.Write("Your option? ");

//// Use a switch statement to do the math.
//switch (Console.ReadLine())
//{
//    case "a":
//        Console.WriteLine($"Your result: {num1} + {num2} = "+ (num1 + num2));
//        break;
//    case "s":
//        Console.WriteLine($"Your result: {num1} - {num2} = " + (num1 - num2));
//        break;
//    case "m":
//        Console.WriteLine($"Your result: {num1} * {num2} = " + (num1 * num2));
//        break;
//    case "d":
//        // Ask the user to enter a non-zero divisor until they do so.
//        while (num2 == 0)
//        {
//            Console.WriteLine("Enter a non-zero divisor: ");
//            num2 = Convert.ToDouble(Console.ReadLine());
//        }
//        Console.WriteLine($"Your result: {num1} / {num2} = " + (num1 / num2));
//        break;
//}

//// Wait for the user to respond before closing.
//Console.Write("Press any key to close the Calculator console app...");
//Console.ReadKey();
using CalculatorLibrary;
namespace CalculatorProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Console Calculator in C#\r");
            Console.WriteLine("------------------------\n");

            Calculator calculator = new Calculator();
            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanNum1 = 0;
                while (!double.TryParse(numInput1, out cleanNum1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanNum2 = 0;
                while (!double.TryParse(numInput2, out cleanNum2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("Choose an operator from the following list:");
                Console.WriteLine("\ta - Add");
                Console.WriteLine("\ts - Subtract");
                Console.WriteLine("\tm - Multiply");
                Console.WriteLine("\td - Divide");
                Console.Write("Your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = calculator.DoOperation(cleanNum1, cleanNum2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error.\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
                if (Console.ReadLine() == "n") endApp = true;

                Console.WriteLine("\n"); // Friendly linespacing.
            }
            // Add call to close the JSON writer before return
            calculator.Finish();
            return;
        }
    }
}