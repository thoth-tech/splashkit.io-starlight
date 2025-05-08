import splashkit

# Open a window and load a font
window = splashkit.open_window("Usage Example", 800, 600)
font = splashkit.load_font("Arial", "src/fonts/arial.ttf")

# Main loop to keep the window open
while not splashkit.window_close_requested(window):
    splashkit.process_events()
    splashkit.clear_screen(splashkit.color_white())

    # Display a message
    splashkit.draw_text("Hello, This is Usage Example", splashkit.color_black(), font, 32, 100, 100)
    splashkit.refresh_screen()

# Free fonts and close the window
splashkit.free_all_fonts()
splashkit.close_window(window)
