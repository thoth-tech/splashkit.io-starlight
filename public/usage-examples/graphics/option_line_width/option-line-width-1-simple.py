from splashkit import *

# Open a window titled "Ripple Effect" with dimensions 800x600
open_window("Ripple Effect", 800, 600)

# Loop to draw 10 concentric circles with increasing radius and line width
for i in range(1 , 10):
    # Draw a circle with a center at (200, 200), increasing radius and line width
    # The radius is multiplied by 15 for each iteration, and line width increases by 1 each time
    draw_circle_with_options(color_blue(), 200, 200, i * 15, option_line_width(i))


# Refresh the screen to display the drawn circles
refresh_screen()

# Pause the program for 5000 milliseconds (5 seconds) to allow viewing the effect
delay(5000)

# Close the window after the delay
close_all_windows()
