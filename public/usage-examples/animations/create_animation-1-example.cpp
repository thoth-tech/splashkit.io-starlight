#include "splashkit.h"

int main()
{
    // Open a window
    open_window("Animation Example", 800, 600);
    
    // Load a bitmap for the animation
    bitmap anim_bitmap = load_bitmap("animation_frames", "animation_frames.png");
    
    // Create an animation with 4 frames, 100ms per frame
    animation anim = create_animation("walking", anim_bitmap, 4, 100);
    
    // Create a sprite to display the animation
    sprite anim_sprite = create_sprite(anim_bitmap);
    sprite_start_animation(anim_sprite, anim);
    
    // Position the sprite in the center of the window
    sprite_set_x(anim_sprite, 350);
    sprite_set_y(anim_sprite, 250);
    
    while (!window_close_requested("Animation Example"))
    {
        // Clear the screen
        clear_screen();
        
        // Update the sprite animation
        update_sprite_animation(anim_sprite);
        
        // Draw the sprite
        draw_sprite(anim_sprite);
        
        // Refresh the screen
        refresh_screen();
        
        // Process events
        process_events();
        
        // Small delay
        delay(16);
    }
    
    // Clean up
    free_animation(anim);
    free_sprite(anim_sprite);
    free_bitmap(anim_bitmap);
    
    return 0;
} 