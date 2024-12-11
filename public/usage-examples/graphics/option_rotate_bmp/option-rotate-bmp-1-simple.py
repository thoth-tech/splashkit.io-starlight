from splashkit import *

# Open the window with the title "Rotate bitmap" and dimensions 800x600
open_window("Rotate bitmap", 800, 600)

# Load the bitmap for the clock hand from the file "clock_hand.png"
clockwise = load_bitmap("Clock Hand", "clock_hand.png")

# Load the bitmap for the clock face from the file "clock.png"
clock = load_bitmap("Clock", "clock.png")

# Main loop to rotate the clock hand through 360 degrees
for i in range(360):
    # Draw the clock hand bitmap rotated to the current angle (i degrees)
    draw_bitmap_with_options(clockwise, 100, 100, option_rotate_bmp(i))
    
    # Draw the clock face bitmap at the same position to keep it static
    draw_bitmap(clock, 100, 100)
    
    # Refresh the screen to display the updated drawings
    refresh_screen()
    
    # Pause for 100 milliseconds to create a smooth animation effect
    delay(100)
    
    # Clear the screen with a white background before the next frame
    clear_screen(color_white())

# Free all loaded bitmap resources to prevent memory leaks
free_all_bitmaps()

# Close the window to end the program
close_all_windows()
