from splashkit import *
# Load font and size 
load_font("BebasNeue", "BebasNeue.ttf")
font_load_size_name_as_string("BebasNeue", 20)

# Prompt user 
write("What size would you like to check?: ")
input = read_line()

# Convert input to integer 
size = convert_to_integer(input)
is_Size = font_has_size_name_as_string("BebasNeue", size)

# If user input is size of font 
if is_Size:
    write_line("APPROVED")
    write_line("Current font size is " + input)
else: # If user input is not size of font
    write_line("ERROR")
    write_line("Font size is NOT " + input)
