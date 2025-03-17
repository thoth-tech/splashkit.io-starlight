from splashkit import *

# Set number of displays
disp_count = number_of_displays()

# Decalre Variables
disp_y = []

# Check for more that 1 display
if disp_count > 1:
    # Loop through displays
    for i in range(disp_count):
        
        # Get details for display
        disp_details = display_details(i)

        # Get Y coordinate info for display
        disp_y.append(display_y(disp_details))
    
    # Check that all displays are on the same Y to determine verticality  
    for i in range(len(disp_y) - 1):
        if (disp_y[i] != disp_y[i + 1]):
            write_line("Your displays are at different heights")
            break
else: 
    write_line("You only have 1 display") 
