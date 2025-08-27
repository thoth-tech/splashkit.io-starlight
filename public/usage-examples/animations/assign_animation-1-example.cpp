#include "splashkit.h"

int main()
{
    open_window("Character Animation Switcher", 600, 400);
    
    // Create a bitmap with different animation sequences
    bitmap sprite_bmp = create_bitmap("sprite", 240, 160);
    clear_bitmap(sprite_bmp, color_white());
    
    // Top row: "walk" animation (3 frames)
    for (int i = 0; i < 3; i++)
    {
        int x = i * 80;
        fill_rectangle_on_bitmap(sprite_bmp, color_light_green(), x, 0, 80, 80);
        draw_rectangle_on_bitmap(sprite_bmp, color_black(), x, 0, 80, 80);
        draw_text_on_bitmap(sprite_bmp, "Walk" + std::to_string(i + 1), color_black(), x + 15, 35);
    }
    
    // Bottom row: "jump" animation (3 frames)
    for (int i = 0; i < 3; i++)
    {
        int x = i * 80;
        fill_rectangle_on_bitmap(sprite_bmp, color_light_blue(), x, 80, 80, 80);
        draw_rectangle_on_bitmap(sprite_bmp, color_black(), x, 80, 80, 80);
        draw_text_on_bitmap(sprite_bmp, "Jump" + std::to_string(i + 1), color_black(), x + 15, 115);
    }
    
    bitmap_set_cell_details(sprite_bmp, 80, 80, 3, 2, 6);
    
    // Simulate animation assignment without external files
    int current_sequence = 0; // 0 = walk (top row), 1 = jump (bottom row)
    string current_name = "walk";
    timer frame_timer = create_timer("frame");
    start_timer(frame_timer);
    int frame_index = 0;
    
    while (!window_close_requested("Character Animation Switcher"))
    {
        process_events();
        
        // Switch to walk animation with W key
        if (key_typed(W_KEY))
        {
            // Simulate assign_animation(anim, script, "walk")
            current_sequence = 0;
            current_name = "walk";
            frame_index = 0; // Reset to first frame
        }
        
        // Switch to jump animation with J key
        if (key_typed(J_KEY))
        {
            // Simulate assign_animation(anim, script, "jump")
            current_sequence = 1;
            current_name = "jump";
            frame_index = 0; // Reset to first frame
        }
        
        // Update animation frame
        if (timer_ticks(frame_timer) > 600)
        {
            frame_index = (frame_index + 1) % 3; // Cycle through 3 frames
            start_timer(frame_timer);
        }
        
        clear_screen(color_white());
        
        // Draw the current animation frame
        int source_y = current_sequence * 80; // 0 for walk (top), 80 for jump (bottom)
        draw_bitmap(sprite_bmp, 250, 150, 
                   option_part_bmp(frame_index * 80, source_y, 80, 80));
        
        // Show current assignment
        draw_text("assign_animation() Demo", color_black(), 10, 10);
        draw_text("Current Animation: " + current_name, color_blue(), 10, 40);
        draw_text("Frame: " + std::to_string(frame_index), color_green(), 10, 70);
        draw_text("Sequence: " + (current_sequence == 0 ? string("Top Row") : string("Bottom Row")), 
                  color_purple(), 10, 100);
        
        // Show available animations
        draw_text("Available Animations:", color_black(), 10, 150);
        draw_text("W - Assign 'walk' animation", current_name == "walk" ? color_red() : color_gray(), 20, 180);
        draw_text("J - Assign 'jump' animation", current_name == "jump" ? color_red() : color_gray(), 20, 210);
        
        // Visual indicator
        color indicator_color = current_name == "walk" ? color_green() : color_blue();
        draw_text("Currently playing: " + current_name + " animation", indicator_color, 10, 320);
        
        // Show both sequences for reference
        draw_text("Walk Frames:", color_green(), 400, 50);
        for (int i = 0; i < 3; i++)
        {
            draw_bitmap(sprite_bmp, 400 + (i * 40), 80, option_part_bmp(i * 80, 0, 80, 80));
        }
        
        draw_text("Jump Frames:", color_blue(), 400, 180);
        for (int i = 0; i < 3; i++)
        {
            draw_bitmap(sprite_bmp, 400 + (i * 40), 210, option_part_bmp(i * 80, 80, 80, 80));
        }
        
        refresh_screen(60);
    }
    
    free_bitmap(sprite_bmp);
    free_timer(frame_timer);
    
    return 0;
}
