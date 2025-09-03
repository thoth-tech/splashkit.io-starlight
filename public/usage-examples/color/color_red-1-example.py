import splashkit


def main():
    # Open a window
    splashkit.open_window("Color Red Example", 800, 600)
    
    # Get the red color
    red_color = splashkit.color_red()
    
    splashkit.write_line("Color Red Example")
    splashkit.write_line("Drawing shapes in red color")
    splashkit.write_line("Press any key to exit")
    
    while not splashkit.window_close_requested("Color Red Example"):
        # Clear the screen to white
        splashkit.clear_screen(splashkit.COLOR_WHITE)
        
        # Draw a red circle
        splashkit.fill_circle(red_color, 200, 200, 100)
        
        # Draw a red rectangle
        splashkit.fill_rectangle(red_color, 400, 150, 150, 100)
        
        # Draw a red triangle
        splashkit.fill_triangle(red_color, 600, 300, 700, 200, 650, 400)
        
        # Draw red text
        splashkit.draw_text("Red Color Example", red_color, 50, 50)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    return 0

if __name__ == "__main__":
    main() 