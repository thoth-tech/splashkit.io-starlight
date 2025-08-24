import splashkit

def main():
    # Open a window
    splashkit.open_window("Point At Example", 800, 600)
    
    # Create various points using point_at function
    center = splashkit.point_at(400, 300)
    top_left = splashkit.point_at(100, 100)
    top_right = splashkit.point_at(700, 100)
    bottom_left = splashkit.point_at(100, 500)
    bottom_right = splashkit.point_at(700, 500)
    
    splashkit.write_line("Point At Example")
    splashkit.write_line("Creating and drawing points")
    splashkit.write_line("Press any key to exit")
    
    while not splashkit.window_close_requested("Point At Example"):
        # Clear the screen
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Draw the center point
        splashkit.fill_circle(splashkit.COLOR_RED, center, 10)
        splashkit.draw_text("Center", splashkit.COLOR_BLACK, center.x + 15, center.y - 10)
        
        # Draw corner points
        splashkit.fill_circle(splashkit.COLOR_BLUE, top_left, 8)
        splashkit.draw_text("Top Left", splashkit.COLOR_BLACK, top_left.x + 15, top_left.y - 10)
        
        splashkit.fill_circle(splashkit.COLOR_GREEN, top_right, 8)
        splashkit.draw_text("Top Right", splashkit.COLOR_BLACK, top_right.x - 60, top_right.y - 10)
        
        splashkit.fill_circle(splashkit.COLOR_ORANGE, bottom_left, 8)
        splashkit.draw_text("Bottom Left", splashkit.COLOR_BLACK, bottom_left.x + 15, bottom_left.y + 15)
        
        splashkit.fill_circle(splashkit.COLOR_PURPLE, bottom_right, 8)
        splashkit.draw_text("Bottom Right", splashkit.COLOR_BLACK, bottom_right.x - 70, bottom_right.y + 15)
        
        # Draw lines connecting points
        splashkit.draw_line(splashkit.COLOR_GRAY, top_left, top_right)
        splashkit.draw_line(splashkit.COLOR_GRAY, top_right, bottom_right)
        splashkit.draw_line(splashkit.COLOR_GRAY, bottom_right, bottom_left)
        splashkit.draw_line(splashkit.COLOR_GRAY, bottom_left, top_left)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    return 0

if __name__ == "__main__":
    main()