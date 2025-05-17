from splashkit import *

write_line("Welcome to the hexadecimal to dec converter.")

# Prompt the user for a hexadecimal input
write_line("Please enter a hexadecimal number:") 

# Read the input from the user
hex_input = read_line()

# Convert the hexadecimal string to dec
dec_value = hex_to_dec_string(hex_input)

# Display the result in dec format
write_line(f"The hexadecimal value in dec format is: {dec_value}")