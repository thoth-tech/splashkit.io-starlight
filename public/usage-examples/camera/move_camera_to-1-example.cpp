#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Camera Movement Example", 800, 600);
    
    // Load a bitmap for the background
    bitmap background = load_bitmap("background", "background.png");
    
    // Create a sprite to follow with the camera
    sprite player = create_sprite(background);
    sprite_set_x(player, 100);
    sprite_set_y(player, 100);
    
    // Set initial camera position
    set_camera_position(vector_to(0, 0));
    
    write_line("Camera Movement Example");
    write_line("Press SPACE to move camera to player position");
    write_line("Press ESC to exit");
    
    while (!window_close_requested("Camera Movement Example"))
    {
        // Clear the screen
        clear_screen();
        
        // Draw the background
        draw_bitmap(background, 0, 0);
        
        // Draw the player sprite
        draw_sprite(player);
        
        // Handle input
        if (key_typed(SPACE_KEY))
        {
            // Move camera to center on the player
            point_2d player_pos = sprite_position(player);
            move_camera_to(player_pos);
            write_line("Camera moved to player position!");
        }
        
        // Display camera position
        point_2d cam_pos = camera_position();
        draw_text("Camera X: " + to_string(cam_pos.x) + " Y: " + to_string(cam_pos.y), COLOR_WHITE, 10, 10);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    // Clean up
    free_sprite(player);
    free_bitmap(background);
    
    return 0;
} 