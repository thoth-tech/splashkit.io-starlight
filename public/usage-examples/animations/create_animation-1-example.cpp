#include "splashkit.h"

int main()
{
    open_window("Sprite Animation Creation", 800, 600);
    
    // Load animation script and bitmap
    animation_script walk_script = load_animation_script("walk_cycle", "walk.txt");
    bitmap character_bmp = load_bitmap("character", "character.png");
    bitmap_set_cell_details(character_bmp, 64, 64, 4, 1, 4); // 4 frames in a row
    
    // Create animation from the script
    animation walk_animation = create_animation(walk_script, "walk");
    
    point_2d character_pos = {100, 300};
    
    while (!quit_requested())
    {
        process_events();
        
        // Move character to the right
        character_pos.x += 2;
        if (character_pos.x > 800) character_pos.x = -64;
        
        // Update animation
        update_animation(walk_animation);
        
        clear_screen(color_white());
        
        // Draw walking character
        draw_bitmap(character_bmp, character_pos.x, character_pos.y, 
                   option_with_animation(walk_animation));
        
        // Display animation information
        draw_text("Walking Character Animation", color_black(), 10, 10);
        draw_text("Animation Name: " + animation_name(walk_animation), color_black(), 10, 30);
        draw_text("Current Frame: " + std::to_string(animation_current_cell(walk_animation)), 
                 color_black(), 10, 50);
        draw_text("Animation Ended: " + std::string(animation_ended(walk_animation) ? "Yes" : "No"), 
                 color_black(), 10, 70);
        
        refresh_screen(60);
    }
    
    // Clean up resources
    free_animation(walk_animation);
    free_animation_script(walk_script);
    free_bitmap(character_bmp);
    close_all_windows();
    
    return 0;
}
