from splashkit import *
import random

# Open a window with the specified title and dimensions
open_window("Fill Triangle", 800, 600)


# Draw 50 random filled triangles on the window
for i in range(50):

    # Generate random coordinates for the three vertices of the triangle
    x1 = random.randint(0,800)
    y1 = random.randint(0,600)
    x2 = random.randint(0,800)
    y2 = random.randint(0,600)
    x3 = random.randint(0,800)
    y3 = random.randint(0,600)

    # Generate a random color for the triangle
    random_color = rgb_color(
        random.randint(0, 255), random.randint(0, 255), random.randint(0, 255)   
    )
    # Draw a filled triangle with the random color and vertices
    fill_triangle(random_color, x1, y1, x2, y2, x3, y3)

# Refresh the screen to display the drawn triangles
refresh_screen()

# Delay to keep the window open for 4 seconds
delay(4000)

# Close all open windows
close_all_windows()
