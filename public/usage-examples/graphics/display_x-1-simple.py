from splashkit import *

# Set number of displays
DispCount = number_of_displays()

write_line("***Display Coordinates***")
write_line("********************************")
# Loop through displays
for i in range(DispCount):

    # Set details for display
    disp_details = display_details(i)

    # Get coordinate info for display
    disp_x = display_x(disp_details)
    disp_y = display_y(disp_details)


    # Get name for display
    DispName = display_name(disp_details)

    # Write info to console

    write_line(f"Display Number: {i + 1} is located at: {disp_x}, {disp_y} Coordinates on the display map")
    write_line("")

write_line("********************************")
