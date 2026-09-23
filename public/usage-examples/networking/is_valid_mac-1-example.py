from splashkit import *

write_line("Hello! Welcome to the MAC address checker.")

# Prompt the user for a MAC address in XX:XX:XX:XX:XX:XX format
write_line("Please enter a MAC address (e.g., 1A:2B:3C:4D:5E:6F):")

# Read the input from the user
mac_input = read_line()

# Check the address before trying to convert or store it
address_is_valid = is_valid_mac(mac_input)

# Tell the user whether the address can be used
if address_is_valid:
    write_line(f"{mac_input} is a valid MAC address.")
else:
    write_line(f"{mac_input} is not a valid MAC address.")
