from splashkit import *

# Open a window to display the random colours
open_window("Random Colour Grid", 640, 480)

while not quit_requested():
    process_events()

    # Clear the screen before drawing
    clear_screen(Color.WHITE)

    # Draw a grid of squares with random colours
    for row in range(4):
        for col in range(4):
            random_colour = random_rgb_color(255)

            fill_rectangle(random_colour, 80 + col * 120, 80 + row * 80, 80, 50)
            draw_rectangle(Color.BLACK, 80 + col * 120, 80 + row * 80, 80, 50)

    # Add a label to explain the example
    draw_text("Each square uses random_rgb_color()", Color.BLACK, 150, 420)

    # Refresh the screen to show updated colours
    refresh_screen_with_target_fps(2)

# Close the window when the program ends
close_all_windows()