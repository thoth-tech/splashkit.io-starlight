from splashkit import *

write_line("Welcome to the Simple Calculator!")
write_line("You can add or subtract two numbers.\n")

while True:
    write_line("Enter the first number (or type 'exit' to quit):")
    input1 = read_line()

    # Check for exit condition
    if to_lowercase(input1) == "exit":
        break

    # Validate the first number
    if not is_number(input1):
        write_line("Oops! That's not a valid number. Please try again.\n")
        continue

    # Loop until the second number is valid
    valid_second_number = False
    while not valid_second_number:
        write_line("Enter the second number:")
        input2 = read_line()

        # Validate the second number
        if not is_number(input2):
            write_line("Oops! That's not a valid number. Please try again.\n")
        else:
            valid_second_number = True

    write_line("Enter the operation (+ or -):")
    operation = read_line()

    # Check for valid operation
    if operation != "+" and operation != "-":
        write_line("Invalid operation. Please enter '+' or '-' only.\n")
        continue

    # Convert inputs to double
    num1 = convert_to_double(input1)
    num2 = convert_to_double(input2)

    # Perform the operation
    if operation == "+":
        write_line("Result: " + str(num1 + num2) + "\n")
    elif operation == "-":
        write_line("Result: " + str(num1 - num2) + "\n")

write_line("Thank you for using the Simple Calculator!")
