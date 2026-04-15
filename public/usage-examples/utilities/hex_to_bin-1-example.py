from splashkit import write_line, hex_to_bin

hex_value = "1F3A"
binary_value = hex_to_bin(hex_value)  # SplashKit function

write_line("Hex: " + hex_value)
write_line("Binary: " + binary_value)
