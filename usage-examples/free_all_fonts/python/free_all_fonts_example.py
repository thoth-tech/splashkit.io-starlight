import splashkit

# opening a window
window = splashkit.open_window("Usage Example", 800, 600)
# loading the font
font = splashkit.load_font("Arial", "C:/Users/jangh/Desktop/SplashKitTestCpp/splashkit.io-starlight/src/fonts/arial.ttf")

# creating a loop so that the window stays open
while not splashkit.window_close_requested(window):
    # to keep the window responsive so that it can process whatever
    # events that may happen
    splashkit.process_events()
    # clearing the window
    splashkit.clear_screen(splashkit.color_white())
    # with the loaded font, we will be drwaing the text to display
    splashkit.draw_text("Hello, This is Usage Example", splashkit.color_black(), font, 32, 100, 100)
    # refreshing the screen 
    splashkit.refresh_screen()

# freeing all the fonts after the end of the loop and before exiting
splashkit.free_all_fonts()

# closing the window
splashkit.close_window(window)
