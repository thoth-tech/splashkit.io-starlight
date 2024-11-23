from splashkit import *

# Prompt user for input string and delimiter
write("Enter a string to split: ")
text = read_line()

write("Enter a delimiter character: ")
delimiter = read_line()

# Ensure the delimiter is a single character
if len(delimiter) != 1:
    write_line("Please enter a single character as the delimiter.")
else:
    # Split the input string
    result = split(text, delimiter)

    # Display the split substrings
    write_line("Split result:")
    for part in result:
        write_line(f"- {part}")
