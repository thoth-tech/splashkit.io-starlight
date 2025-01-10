from splashkit import *

write_line("Welcome to the Terminal Input Checker!")
write_line("Type something and press Enter to see it echoed back.")
write_line("Type 'exit' and press Enter to quit the program.")

input_text = ""

while input_text != "exit":
    # Check if there's input waiting in the terminal
    if terminal_has_input():
        # Read the input
        input_text = read_line()
        if input_text != "exit":
            write_line("You typed: " + input_text)
        else:
            input = "" # If no input, continue waiting

write_line("Exiting the program...")
