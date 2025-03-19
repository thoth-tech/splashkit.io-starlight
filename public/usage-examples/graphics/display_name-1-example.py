from splashkit import *

# Set number of displays
num_displays = number_of_displays()

# Print main display details and number of displays
write_line(f"Your main display is called: {display_name(display_details(0))}")
write_line(f"You have {num_displays} displays connected.")

# Print names for secondary displays
write_line(f"Your secondary displays are called: ")
for i in range(1,num_displays):
    write_line(display_name(display_details(i)))