from splashkit import *

encoded = "SGVsbG8gU3BsYXNoS2l0"

# Decode a Base64 string back to plain text
decoded = base64_decode(encoded)

# Print the Base64 input and decoded result
write_line("Base64: " + encoded)
write_line("Decoded: " + decoded)
