from splashkit import *

def main():
    # Open a window with a title and fixed size
    window = open_window("Bitmap Named Example", 800, 600)

    # Load the bitmap and assign it a name "logo"
    load_bitmap("logo", "splashkit.png")

    # Retrieve the bitmap using its assigned name
    image = bitmap_named("logo")

    # Calculate the position to center the image on the screen
    x = (800 - bitmap_width(image)) // 2
    y = (600 - bitmap_height(image)) // 2

    # Clear the screen to white for visibility
    clear_screen(color_white())

    # Draw the bitmap centered on the screen
    draw_bitmap(image, x, y)

    # Output the bitmap name to the terminal (not on screen)
    write_line("Bitmap name: " + bitmap_name(image))

    # Display the result at 60 FPS for smoothness
    refresh_screen_with_target_fps(60)

    # Delay to allow user to view the output
    delay(3000)

    # Close the window when done
    close_window(window)

# Run the program
main()