import splashkit


def main():
    # Open a window
    splashkit.open_window("Key Down Example", 800, 600)
    
    splashkit.write_line("Key Down Example")
    splashkit.write_line("Press and hold keys to see their state")
    splashkit.write_line("Press ESC to exit")
    
    while not splashkit.window_close_requested("Key Down Example"):
        # Clear the screen
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Check various keys and display their state
        if splashkit.key_down(splashkit.SPACE_KEY):
            splashkit.fill_circle(splashkit.COLOR_RED, 200, 200, 50)
            splashkit.draw_text("SPACE - PRESSED", splashkit.COLOR_RED, 50, 50)
        else:
            splashkit.draw_circle(splashkit.COLOR_GRAY, 200, 200, 50)
            splashkit.draw_text("SPACE - Released", splashkit.COLOR_GRAY, 50, 50)
        
        if splashkit.key_down(splashkit.LEFT_KEY):
            splashkit.fill_circle(splashkit.COLOR_BLUE, 400, 200, 50)
            splashkit.draw_text("LEFT - PRESSED", splashkit.COLOR_BLUE, 50, 100)
        else:
            splashkit.draw_circle(splashkit.COLOR_GRAY, 400, 200, 50)
            splashkit.draw_text("LEFT - Released", splashkit.COLOR_GRAY, 50, 100)
        
        if splashkit.key_down(splashkit.RIGHT_KEY):
            splashkit.fill_circle(splashkit.COLOR_GREEN, 600, 200, 50)
            splashkit.draw_text("RIGHT - PRESSED", splashkit.COLOR_GREEN, 50, 150)
        else:
            splashkit.draw_circle(splashkit.COLOR_GRAY, 600, 200, 50)
            splashkit.draw_text("RIGHT - Released", splashkit.COLOR_GRAY, 50, 150)
        
        if splashkit.key_down(splashkit.UP_KEY):
            splashkit.fill_circle(splashkit.COLOR_ORANGE, 300, 350, 50)
            splashkit.draw_text("UP - PRESSED", splashkit.COLOR_ORANGE, 50, 200)
        else:
            splashkit.draw_circle(splashkit.COLOR_GRAY, 300, 350, 50)
            splashkit.draw_text("UP - Released", splashkit.COLOR_GRAY, 50, 200)
        
        if splashkit.key_down(splashkit.DOWN_KEY):
            splashkit.fill_circle(splashkit.COLOR_PURPLE, 500, 350, 50)
            splashkit.draw_text("DOWN - PRESSED", splashkit.COLOR_PURPLE, 50, 250)
        else:
            splashkit.draw_circle(splashkit.COLOR_GRAY, 500, 350, 50)
            splashkit.draw_text("DOWN - Released", splashkit.COLOR_GRAY, 50, 250)
        
        # Instructions
        splashkit.draw_text("Hold down arrow keys and space to see changes", splashkit.COLOR_BLACK, 50, 500)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    return 0

if __name__ == "__main__":
    main() 