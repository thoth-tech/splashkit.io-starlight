from splashkit import *

write("Enter an angle: ")

# User inputs angle
input = convert_to_double(read_line())
result = cosine(float(input))

# Write cosine to console
write("Cosine: ")
write_line(str(result))
