import splashkit

def main():
    # Open a window
    splashkit.open_window("Log Example", 800, 600)
    
    splashkit.write_line("Log Example")
    splashkit.write_line("Check the console/terminal for logged messages")
    splashkit.write_line("Press any key to exit")
    
    # Log different types of messages
    splashkit.log("INFO", "Application started successfully")
    splashkit.log("DEBUG", "Debug information: Window opened at 800x600")
    splashkit.log("WARNING", "This is a warning message")
    splashkit.log("ERROR", "This is an error message")
    
    # Log with different message types
    splashkit.log("INFO", "User clicked the start button")
    splashkit.log("DEBUG", "Button position: x=100, y=200")
    splashkit.log("INFO", "Game score: 1500 points")
    splashkit.log("WARNING", "Low memory warning: 10MB remaining")
    
    while not splashkit.window_close_requested("Log Example"):
        # Clear the screen
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Display logging information
        splashkit.draw_text("Log Example - Check Console/Terminal", splashkit.COLOR_BLACK, 50, 50)
        splashkit.draw_text("The following messages have been logged:", splashkit.COLOR_BLACK, 50, 100)
        
        splashkit.draw_text("INFO: Application started successfully", splashkit.COLOR_BLUE, 70, 150)
        splashkit.draw_text("DEBUG: Debug information: Window opened at 800x600", splashkit.COLOR_GREEN, 70, 180)
        splashkit.draw_text("WARNING: This is a warning message", splashkit.COLOR_ORANGE, 70, 210)
        splashkit.draw_text("ERROR: This is an error message", splashkit.COLOR_RED, 70, 240)
        splashkit.draw_text("INFO: User clicked the start button", splashkit.COLOR_BLUE, 70, 270)
        splashkit.draw_text("DEBUG: Button position: x=100, y=200", splashkit.COLOR_GREEN, 70, 300)
        splashkit.draw_text("INFO: Game score: 1500 points", splashkit.COLOR_BLUE, 70, 330)
        splashkit.draw_text("WARNING: Low memory warning: 10MB remaining", splashkit.COLOR_ORANGE, 70, 360)
        
        # Instructions
        splashkit.draw_text("Look at your console/terminal to see the actual log messages", splashkit.COLOR_BLACK, 50, 450)
        splashkit.draw_text("Press any key to exit", splashkit.COLOR_BLACK, 50, 500)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    # Log application exit
    splashkit.log("INFO", "Application shutting down")
    
    return 0

if __name__ == "__main__":
    main() 