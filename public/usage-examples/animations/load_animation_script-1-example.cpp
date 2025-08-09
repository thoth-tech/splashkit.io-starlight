#include "splashkit.h"

int main()
{
    open_window("Dancing Frog Animation", 800, 600);
    
    // Load the frog bitmap with animation cells
    bitmap frog_bmp = load_bitmap("frog", "frog.png");
    bitmap_set_cell_details(frog_bmp, 73, 105, 4, 4, 16); // 4x4 grid, 16 total frames
    
    // Load animation script that defines the dancing sequence
    animation_script dance_script = load_animation_script("dance", "dance.txt");
    
    // Create an animation from the script
    animation frog_dance = create_animation(dance_script, "dance");
    
    point_2d frog_pos = {400, 300};
    
    while (!quit_requested())
    {
        process_events();
        
        // Update the animation
        update_animation(frog_dance);
        
        clear_screen(color_light_green());
        
        // Draw the frog with current animation frame
        draw_bitmap(frog_bmp, frog_pos.x - 36, frog_pos.y - 52, 
                   option_with_animation(frog_dance));
        
        // Show animation info
        draw_text("Press ESC to exit", color_black(), 10, 10);
        draw_text("Animation: " + animation_name(frog_dance), color_black(), 10, 30);
        draw_text("Current Cell: " + std::to_string(animation_current_cell(frog_dance)), 
                 color_black(), 10, 50);
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(frog_dance);
    free_animation_script(dance_script);
    free_bitmap(frog_bmp);
    close_all_windows();
    
    return 0;
}
