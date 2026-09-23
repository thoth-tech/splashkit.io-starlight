from splashkit import *

write_line("Hello! Welcome to the hexadecimal to MAC address converter.")

# Prompt the user for a hexadecimal input, which must start with 0x
write_line("Please enter a hexadecimal MAC string (e.g., 0x1A2B3C4D5E6F):")

# Read the input from the user
hex_input = read_line()

# Convert the hexadecimal string to a colon separated MAC address
mac_address = hex_to_mac(hex_input)

# Display the result in XX:XX:XX:XX:XX:XX format
write_line(f"The hexadecimal string as a MAC address is: {mac_address}")
