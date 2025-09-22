#include "splashkit.h"

int main()
{
    open_window("Create Animation Demo", 400, 300);
    
    // Load bitmap and set cell details
    bitmap walk_bitmap = load_bitmap("walk", "walk.png");
    bitmap_set_cell_details(walk_bitmap, 73, 105, 4, 4, 16);
    
    // Load animation script
    animation_script walk_script = load_animation_script("walk", "walk.txt");
    
    // Create animation from script using the "walk" animation name
    animation walk_anim = create_animation(walk_script, "walk");
    
    // Main loop
    while (!quit_requested())
    {
        process_events();
        clear_screen(color_white());
        
        // Draw animated bitmap
        draw_bitmap(walk_bitmap, 150, 100, option_with_animation(walk_anim));
        update_animation(walk_anim);
        
        refresh_screen(60);
    }
    
    close_all_windows();
    return 0;
}
