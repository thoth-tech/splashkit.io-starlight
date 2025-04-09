from splashkit import *

write_line("***Display Info***")

# Loop through displays
for i in range(number_of_displays()):

    # Set details for display
    disp_details = display_details(i)
    
    # Write info to console
    write_line("***********************************")
    write_line(f"  Display Number: {i + 1}")
    write_line(f"   Name: {display_name(disp_details)}"  )
    write_line(f"   Coordinates (X,Y): {display_x(disp_details)}, {display_y(disp_details)}" )
    write_line(f"   Resolution: {display_width(disp_details)}x{display_height(disp_details)}")
    
write_line("***********************************")