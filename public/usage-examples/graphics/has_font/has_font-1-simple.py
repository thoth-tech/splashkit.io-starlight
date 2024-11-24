from splashkit import *

my_font = None

# Check if program has font
write("Font available before loading: ")
write_line(str(has_font(my_font)))

# Load font
my_font = load_font("MyFont", "RobotoSlab.ttf")

# Check if program has font again
write("Font available after loading: ")
write_line(str(has_font(my_font)))
