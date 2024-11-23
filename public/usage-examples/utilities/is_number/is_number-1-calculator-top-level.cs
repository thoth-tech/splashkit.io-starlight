using static SplashKitSDK.SplashKit;

WriteLine("Welcome to the Simple Calculator!");
WriteLine("You can add or subtract two numbers.\n");

while (true)
{
    WriteLine("Enter the first number (or type 'exit' to quit):");
    string input1 = ReadLine();

    // Check for exit condition
    if (input1.ToLower() == "exit")
    {
        break;
    }

    // Validate the first number
    if (!IsNumber(input1))
    {
        WriteLine("Oops! That's not a valid number. Please try again.\n");
        continue;
    }
    
    string input2 = "";

    // Loop until the second number is valid
    bool validSecondNumber = false;
    while (!validSecondNumber)
    {
        WriteLine("Enter the second number:");
        input2 = ReadLine();

        // Validate the second number
        if (!IsNumber(input2))
        {
            WriteLine("Oops! That's not a valid number. Please try again.\n");
        }
        else
        {
            validSecondNumber = true;
        }
    }

    WriteLine("Enter the operation (+ or -):");
    string operation = ReadLine();

    // Check for valid operation
    if (operation != "+" && operation != "-")
    {
        WriteLine("Invalid operation. Please enter '+' or '-' only.\n");
        continue;
    }

    // Convert inputs to double
    double num1 = ConvertToDouble(input1);
    double num2 = ConvertToDouble(input2);

    // Perform the operation
    if (operation == "+")
    {
        WriteLine("Result: " + (num1 + num2) + "\n");
    }
    else if (operation == "-")
    {
        WriteLine("Result: " + (num1 - num2) + "\n");
    }
}

WriteLine("Thank you for using the Simple Calculator!");
