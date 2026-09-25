from splashkit import *

write_line("Hello! Welcome to the hexadecimal to IPv4 converter.")

# Prompt the user for a hexadecimal input, which must start with 0x
write_line("Please enter a hexadecimal IPv4 string (e.g., 0x7F000001):")

# Read the input from the user
hex_input = read_line()

# Convert the hexadecimal string to a dotted decimal IPv4 address
ip_address = hex_str_to_ipv4(hex_input)

# Display the result in dotted decimal format
write_line(f"The hexadecimal string as an IPv4 address is: {ip_address}")
