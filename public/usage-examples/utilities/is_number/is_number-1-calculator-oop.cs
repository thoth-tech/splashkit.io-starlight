using SplashKitSDK;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            SplashKit.WriteLine("Welcome to the Simple Calculator!");
            SplashKit.WriteLine("You can add or subtract two numbers.\n");

            while (true)
            {
                SplashKit.WriteLine("Enter the first number (or type 'exit' to quit):");
                string input1 = SplashKit.ReadLine();

                // Check for exit condition
                if (SplashKit.ToLowercase(input1) == "exit")
                {
                    break;
                }

                // Validate the first number
                if (!SplashKit.IsNumber(input1))
                {
                    SplashKit.WriteLine("Oops! That's not a valid number. Please try again.\n");
                    continue;
                }

                string input2 = "";
                
                // Loop until the second number is valid
                bool validSecondNumber = false;

                while (!validSecondNumber)
                {
                    SplashKit.WriteLine("Enter the second number:");
                    input2 = SplashKit.ReadLine();

                    // Validate the second number
                    if (!SplashKit.IsNumber(input2))
                    {
                        SplashKit.WriteLine("Oops! That's not a valid number. Please try again.\n");
                    }
                    else
                    {
                        validSecondNumber = true;
                    }
                }

                SplashKit.WriteLine("Enter the operation (+ or -):");
                string operation = SplashKit.ReadLine();

                // Check for valid operation
                if (operation != "+" && operation != "-")
                {
                    SplashKit.WriteLine("Invalid operation. Please enter '+' or '-' only.\n");
                    continue;
                }

                // Convert inputs to double
                double num1 = SplashKit.ConvertToDouble(input1);
                double num2 = SplashKit.ConvertToDouble(input2);

                // Perform the operation
                if (operation == "+")
                {
                    SplashKit.WriteLine("Result: " + (num1 + num2) + "\n");
                }
                else if (operation == "-")
                {
                    SplashKit.WriteLine("Result: " + (num1 - num2) + "\n");
                }
            }

            SplashKit.WriteLine("Thank you for using the Simple Calculator!");
        }
    }
}