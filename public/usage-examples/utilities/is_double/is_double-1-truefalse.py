from splashkit import *

values = ["123", "45.67", "-50", "abc", "789", "0"]

for value in values:
    # Check if string is a valid double
    number = is_double(value)

    # Print the value along with the result using "true" or "false"
    write_line(f"{value} - {'true' if number else 'false'}")
