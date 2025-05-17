from splashkit import *

write_line("Welcome to the hexadecimal to ipv4 converter.")

# Prompt the user for a hexadecimal input
write_line("Please enter a hexadecimal number:") 

# Read the input from the user
hex_input = read_line()

# Convert the hexadecimal string to ipv4
ipv4_value = hex_str_to_ipv4(hex_input)

# Display the result in ipv4 format
write_line(f"The hexadecimal value in ipv4 format is: {ipv4_value}")