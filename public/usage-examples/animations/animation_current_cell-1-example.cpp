#include "splashkit.h"

int main()
{
    open_window("Current Frame Tracking", 800, 600);
    
    // Load animation script and bitmap for character states
    animation_script states_script = load_animation_script("character_states", "states.txt");
    bitmap character_bmp = load_bitmap("character", "character.png");
    bitmap_set_cell_details(character_bmp, 64, 64, 8, 2, 16); // 8x2 grid, 16 frames
    
    // Create animation
    animation character_anim = create_animation(states_script, "idle");
    
    point_2d character_pos = {400, 300};
    int prev_cell = -1;
    
    while (!quit_requested())
    {
        process_events();
        
        // Update animation
        update_animation(character_anim);
        
        // Get current animation cell
        int current_cell = animation_current_cell(character_anim);
        
        // Detect frame changes
        if (current_cell != prev_cell)
        {
            write_line("Frame changed from " + std::to_string(prev_cell) + 
                      " to " + std::to_string(current_cell));
            prev_cell = current_cell;
        }
        
        clear_screen(color_light_blue());
        
        // Draw character
        draw_bitmap(character_bmp, character_pos.x - 32, character_pos.y - 32,
                   option_with_animation(character_anim));
        
        // Draw frame information
        draw_text("Current Frame Tracking", color_black(), 10, 10);
        draw_text("Current Cell: " + std::to_string(current_cell), color_black(), 10, 30);
        draw_text("Total Frames: 16", color_black(), 10, 50);
        
        // Draw frame indicator bar
        int bar_width = 400;
        int bar_x = 200;
        int bar_y = 100;
        
        draw_rectangle(color_gray(), bar_x - 2, bar_y - 2, bar_width + 4, 24);
        draw_rectangle(color_white(), bar_x, bar_y, bar_width, 20);
        
        // Draw current frame position
        int frame_pos = (current_cell * bar_width) / 16;
        draw_rectangle(color_red(), bar_x + frame_pos - 2, bar_y, 4, 20);
        
        // Draw frame numbers
        for (int i = 0; i <= 16; i += 4)
        {
            int x = bar_x + (i * bar_width) / 16;
            draw_text(std::to_string(i), color_black(), x - 5, bar_y + 25);
        }
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(character_anim);
    free_animation_script(states_script);
    free_bitmap(character_bmp);
    close_all_windows();
    
    return 0;
}
