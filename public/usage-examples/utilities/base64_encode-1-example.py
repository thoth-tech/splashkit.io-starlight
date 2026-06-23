from splashkit import *

text = "Hello SplashKit"

# Encode a plain string into Base64
encoded = base64_encode(text)

# Print the original and encoded values
write_line("Original: " + text)
write_line("Base64: " + encoded)