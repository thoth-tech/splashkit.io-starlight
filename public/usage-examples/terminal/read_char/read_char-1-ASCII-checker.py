from splashkit import *

write_line("Check the ASCII value of a character.")
write_line("Press 'q' to quit, or type any character to see its ASCII value.")

while True:
    write("Enter a character: ")
    input_char = read_char()  # Read a single character input

    if input_char == 'q':  # Quit if 'q' is pressed
        write_line("You pressed 'q'. Exiting the program. Goodbye!")
        break
    else:
        # Display the ASCII value of the character
        write_line(f"You pressed '{input_char}' (ASCII: {ord(input_char)}).")