from splashkit import *


first_ip = 2130706433
second_ip = 3232235777
third_ip = 134744072

# Convert decimal IP values into IPv4 addresses
first_address = dec_to_ipv4(first_ip)
second_address = dec_to_ipv4(second_ip)
third_address = dec_to_ipv4(third_ip)

print("Decimal to IPv4 Conversion")
print()

print(str(first_ip) + " -> " + first_address)
print(str(second_ip) + " -> " + second_address)
print(str(third_ip) + " -> " + third_address)