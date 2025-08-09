#include "splashkit.h"

int main()
{
    open_window("Animation End Detection", 800, 600);
    
    // Load animation script and bitmap for explosion effect
    animation_script explosion_script = load_animation_script("explosion", "explosion.txt");
    bitmap explosion_bmp = load_bitmap("explosion", "explosion.png");
    bitmap_set_cell_details(explosion_bmp, 64, 64, 5, 5, 25); // 5x5 grid, 25 frames
    
    // Create animation that plays once
    animation explosion_anim = create_animation(explosion_script, "explode");
    
    point_2d explosion_pos = {400, 300};
    bool show_explosion = false;
    
    while (!quit_requested())
    {
        process_events();
        
        // Press SPACE to trigger explosion
        if (key_typed(key_space))
        {
            restart_animation(explosion_anim);
            show_explosion = true;
        }
        
        if (show_explosion)
        {
            update_animation(explosion_anim);
            
            // Check if animation has ended
            if (animation_ended(explosion_anim))
            {
                show_explosion = false;
            }
        }
        
        clear_screen(color_black());
        
        // Draw explosion if active
        if (show_explosion)
        {
            draw_bitmap(explosion_bmp, explosion_pos.x - 32, explosion_pos.y - 32,
                       option_with_animation(explosion_anim));
        }
        
        // Draw instructions and status
        draw_text("Press SPACE to trigger explosion", color_white(), 10, 10);
        draw_text("Explosion Active: " + std::string(show_explosion ? "Yes" : "No"), 
                 color_white(), 10, 30);
        draw_text("Animation Ended: " + std::string(animation_ended(explosion_anim) ? "Yes" : "No"), 
                 color_white(), 10, 50);
        draw_text("Current Frame: " + std::to_string(animation_current_cell(explosion_anim)), 
                 color_white(), 10, 70);
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(explosion_anim);
    free_animation_script(explosion_script);
    free_bitmap(explosion_bmp);
    close_all_windows();
    
    return 0;
}
