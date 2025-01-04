from splashkit import *

write("Enter an angle: ")

# User inputs angle
input = read_line()
result = sine(float(input))

# Write sine to console
write("Sine: ")
write_line(str(result))
