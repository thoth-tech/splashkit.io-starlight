from splashkit import *

write_line("Hello! Welcome to the MAC address to hexadecimal converter.")

# Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
write_line("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):")

# Read the input from the user
mac_input = read_line()

# Convert the MAC address to hexadecimal format
mac_as_hex = mac_to_hex(mac_input)

# Display the result in hexadecimal format
write_line(f"The MAC address in hexadecimal format is: {mac_as_hex}")
