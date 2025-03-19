from splashkit import *

write_line("Display Coordinates")
write_line("------------------------------------")
# Loop through displays
for i in range(number_of_displays()):
    # Set details for display
    disp_details = display_details(i)

    # Write info to console
    write_line(f"Display Number: {i + 1} is located at: {display_x(disp_details)}, {display_y(disp_details)} Coordinates on the display map")
    write_line("")


