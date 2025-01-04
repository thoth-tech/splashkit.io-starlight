from splashkit import *

write("Enter an angle: ")

# User inputs angle
input = read_line()
result = tangent(float(input))

# Write tangent to console
write("Tangent: ")
write_line(str(result))
