from splashkit import *

input_str = "Hello World"
encoded = base64_encode(input_str)

write_line("Original: " + input_str)
write_line("Encoded: " + encoded)