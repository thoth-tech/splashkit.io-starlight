from splashkit import *

# Open a window
open_window("Rectangle on Bitmap", 400, 400)
# Create a bitmap
bmp = create_bitmap("bricks",400,400)

# Draw 50 random rectangles on the bitmap
for i in range(50):

                x = rnd_int(350); 
                y = rnd_int(350); 
                width = rnd_int(50); 
                height = rnd_int(50); 
                # Generate a random color
                randomColor = rgb_color(rnd_int(255), rnd_int(255), rnd_int(255)); 
                # Draw the rectangle with the random color on the bitmap
                draw_rectangle_on_bitmap(bmp, randomColor, x, y, width, height)



# Draw the bitmap onto the window
draw_bitmap(bmp, 0,0)

# Refresh the screen
refresh_screen()

# Delay to keep the window open for 5 seconds
delay(5000)

# Close all open windows
close_all_windows()