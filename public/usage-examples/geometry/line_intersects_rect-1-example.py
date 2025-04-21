from splashkit import *

def main():
    # Create and open a new window 
    open_window("Line Width Example", 800, 600)

    # Set line width to 10
    option_line_width(10)
    # Draws a black rectangle with the current line width at position (100, 100).
    draw_rectangle(Color.Black, 100, 100, 200, 150)

    # Set line width to 5
    option_line_width(5)
    # Draws a red rectangle with the current line width at position (400, 100).
    draw_rectangle(Color.Red, 400, 100, 200, 150)

    refresh_screen()

    # Keep the window open until the user closes it
    while not quit_requested():
        process_events()

main()
