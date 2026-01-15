from splashkit import *

# Set number of displays
disp_count = number_of_displays()

# Declare Variables
display_y_values = []

# Only compare display positions if more than one display is connected
if disp_count > 1:
    # Loop through displays
    for i in range(disp_count):
        
        # Get details for display
        disp_details = display_details(i)

        # Get Y coordinate info for display
        display_y_values.append(display_y(disp_details))
    
    # Check that all displays are on the same Y coordinate and aligned horizontally   
    for i in range(len(display_y_values) - 1):
        if (display_y_values[i] != display_y_values[i + 1]):
            write_line("Your displays are at different heights")
            break
else: 
    write_line("You only have 1 display") 
