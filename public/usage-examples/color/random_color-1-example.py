from splashkit import *


win = open_window("Random Color", 800, 600)

originalColor = random_color()
currentColor = originalColor

    # Main loop
while not window_close_requested(win):
        # Process user input events
        process_events()

        # Left click: change to a new random color
        if mouse_clicked(MouseButton.left_button):

            currentColor = random_color()
        # Right click: return to original color    
        elif mouse_clicked(MouseButton.right_button):

            currentColor = originalColor

        
        clear_screen(currentColor)


        refresh_screen()


close_all_windows()

