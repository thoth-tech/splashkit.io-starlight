from splashkit import *

write_line("Welcome to the Terminal Input Checker!")
write_line("Type something and press Enter to see it echoed back.")
write_line("Type 'exit' and press Enter to quit the program.")

while True:
    # Check if there's input waiting in the terminal
    if terminal_has_input():
        # Read and echo the input
        input_text = read_line()
        if input_text == "exit":
            write_line("Exiting the program...")
            break
        write_line("You typed: " + input_text)
