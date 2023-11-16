namespace Enum
{
    class Program
    {
        enum Level
        {
            Low,
            Medium,
            High
        }
        enum Months
        {
            January,    // 0
            February,   // 1
            March,      // 2
            April,      // 3
            May,        // 4
            June,       // 5
            July        // 6
        }
        enum Months2
        {
            January,    // 0
            February,   // 1
            March = 6,    // 6 assign your own enum values, and the next items will update their numbers accordingly:
            April,      // 7
            May,        // 8
            June,       // 9
            July        // 10
        }

        // throw
        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        static void Main(string[] args)
        {
            Level myVar = Level.Medium;
            Console.WriteLine(myVar);//Medium
            // switch statement
            switch (myVar)
            {
                case Level.Low:
                    Console.WriteLine("Low level");
                    break;
                case Level.Medium:
                    Console.WriteLine("Medium level");
                    break;
                case Level.High:
                    Console.WriteLine("High level");
                    break;
            }


            int myNum = (int)Months.April; //To get the integer value from an item, you must explicitly convert the item to an int
            Console.WriteLine(myNum);

            int myNum2= (int)Months2.April;
            Console.WriteLine(myNum2);

            //throw
            checkAge(15); // System.ArithmeticException: 'Access denied - You must be at least 18 years old.' 
            checkAge(20); // Access granted - You are old enough! 
            // try and catch and finally
            try
            {
                int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }

}
