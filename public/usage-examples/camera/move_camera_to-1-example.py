import splashkit

def main():
    # Open a window
    splashkit.open_window("Camera Movement Example", 800, 600)
    
    # Load a bitmap for the background
    background = splashkit.load_bitmap("background", "background.png")
    
    # Create a sprite to follow with the camera
    player = splashkit.create_sprite(background)
    splashkit.sprite_set_x(player, 100)
    splashkit.sprite_set_y(player, 100)
    
    # Set initial camera position
    splashkit.set_camera_position(splashkit.vector_to(0, 0))
    
    splashkit.write_line("Camera Movement Example")
    splashkit.write_line("Press SPACE to move camera to player position")
    splashkit.write_line("Press ESC to exit")
    
    while not splashkit.window_close_requested("Camera Movement Example"):
        # Clear the screen
        splashkit.clear_screen()
        
        # Draw the background
        splashkit.draw_bitmap(background, 0, 0)
        
        # Draw the player sprite
        splashkit.draw_sprite(player)
        
        # Handle input
        if splashkit.key_typed(splashkit.SPACE_KEY):
            # Move camera to center on the player
            player_pos = splashkit.sprite_position(player)
            splashkit.move_camera_to(player_pos)
            splashkit.write_line("Camera moved to player position!")
        
        # Display camera position
        cam_pos = splashkit.camera_position()
        splashkit.draw_text("Camera X: " + str(cam_pos.x) + " Y: " + str(cam_pos.y), splashkit.COLOR_WHITE, 10, 10)
        
        # Refresh the screen
        splashkit.refresh_screen()
        
        # Process events
        splashkit.process_events()
        
        # Small delay
        splashkit.delay(16)
    
    # Clean up
    splashkit.free_sprite(player)
    splashkit.free_bitmap(background)

if __name__ == "__main__":
    main() 