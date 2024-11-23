#include "splashkit.h"

int main()
{
    write_line("Welcome to the Simple Calculator!");
    write_line("You can add or subtract two numbers.\n");

    string input1, input2, operation;

    while (true)
    {
        write_line("Enter the first number (or type 'exit' to quit):");
        input1 = read_line();

        // Check for exit condition
        if (to_lowercase(input1) == "exit")
        {
            break;
        }

        // Validate the first number
        if (!is_number(input1))
        {
            write_line("Oops! That's not a valid number. Please try again.\n");
            continue;
        }

        // Loop until the second number is valid
        bool valid_second_number = false;
        while (!valid_second_number)
        {
            write_line("Enter the second number:");
            input2 = read_line();

            // Validate the second number
            if (!is_number(input2))
            {
                write_line("Oops! That's not a valid number. Please try again.\n");
            }
            else
            {
                valid_second_number = true;
            }
        }

        write_line("Enter the operation (+ or -):");
        operation = read_line();

        // Check for valid operation
        if (operation != "+" && operation != "-")
        {
            write_line("Invalid operation. Please enter '+' or '-' only.\n");
            continue;
        }        

        // Convert inputs to double
        double num1 = convert_to_double(input1);
        double num2 = convert_to_double(input2);

        // Perform the operation
        if (operation == "+")
        {
            write_line("Result: " + std::to_string(num1 + num2)+ "\n");
        }
        else if (operation == "-")
        {
            write_line("Result: " + std::to_string(num1 - num2)+ "\n");
        }
    }

    write_line("Thank you for using the Simple Calculator!");
}
