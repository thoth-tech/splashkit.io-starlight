#include "splashkit.h"

int main()
{
    open_window("Animation Frame Updates", 800, 600);
    
    // Load animation script and bitmap
    animation_script coin_script = load_animation_script("spinning_coin", "coin.txt");
    bitmap coin_bmp = load_bitmap("coin", "coin.png");
    bitmap_set_cell_details(coin_bmp, 32, 32, 8, 1, 8); // 8 frames of spinning coin
    
    // Create animation
    animation coin_spin = create_animation(coin_script, "spin");
    
    point_2d coin_pos = {400, 300};
    
    while (!quit_requested())
    {
        process_events();
        
        // Update animation with different speeds based on keyboard input
        if (key_down(key_space))
        {
            // Fast animation - update with 2x speed
            update_animation(coin_spin, 2.0f);
        }
        else if (key_down(key_left_shift))
        {
            // Slow animation - update with 0.5x speed
            update_animation(coin_spin, 0.5f);
        }
        else
        {
            // Normal animation speed
            update_animation(coin_spin);
        }
        
        clear_screen(color_dark_blue());
        
        // Draw spinning coin
        draw_bitmap(coin_bmp, coin_pos.x - 16, coin_pos.y - 16, 
                   option_with_animation(coin_spin));
        
        // Draw instructions and animation info
        draw_text("Spinning Coin Animation", color_white(), 10, 10);
        draw_text("SPACE: Fast, SHIFT: Slow, Normal: Default", color_white(), 10, 30);
        draw_text("Current Frame: " + std::to_string(animation_current_cell(coin_spin)), 
                 color_white(), 10, 50);
        draw_text("Frame Time: " + std::to_string(animation_frame_time(coin_spin)), 
                 color_white(), 10, 70);
        draw_text("Animation Ended: " + std::string(animation_ended(coin_spin) ? "Yes" : "No"), 
                 color_white(), 10, 90);
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(coin_spin);
    free_animation_script(coin_script);
    free_bitmap(coin_bmp);
    close_all_windows();
    
    return 0;
}
