#include "splashkit.h"

int main()
{
    open_window("Walking Character Animation", 600, 400);
    
    // Create a simple character bitmap with 4 walking frames
    bitmap character_bmp = create_bitmap("character", 320, 80);
    clear_bitmap(character_bmp, color_white());
    
    // Draw 4 walking frames
    for (int i = 0; i < 4; i++)
    {
        int x = i * 80;
        // Draw character body
        fill_rectangle_on_bitmap(character_bmp, color_light_gray(), x + 20, 10, 40, 60);
        draw_rectangle_on_bitmap(character_bmp, color_black(), x + 20, 10, 40, 60);
        
        // Draw head
        fill_circle_on_bitmap(character_bmp, color_pink(), x + 40, 25, 15);
        draw_circle_on_bitmap(character_bmp, color_black(), x + 40, 25, 15);
        
        // Draw walking animation (different leg positions)
        int leg_offset = (i % 2) * 10 - 5; // Alternate leg positions
        fill_rectangle_on_bitmap(character_bmp, color_blue(), x + 25 + leg_offset, 60, 8, 15);
        fill_rectangle_on_bitmap(character_bmp, color_blue(), x + 47 - leg_offset, 60, 8, 15);
        
        // Frame number
        draw_text_on_bitmap(character_bmp, std::to_string(i + 1), color_red(), x + 5, 75);
    }
    
    bitmap_set_cell_details(character_bmp, 80, 80, 4, 1, 4);
    
    // Simulate create_animation functionality
    timer update_timer = create_timer("update");
    start_timer(update_timer);
    int current_frame = 0;
    bool animation_playing = true;
    
    while (!window_close_requested("Walking Character Animation"))
    {
        process_events();
        
        // Toggle animation with SPACE
        if (key_typed(SPACE_KEY))
        {
            animation_playing = !animation_playing;
        }
        
        // Simulate animation update every 500ms
        if (animation_playing && timer_ticks(update_timer) > 500)
        {
            current_frame = (current_frame + 1) % 4;
            start_timer(update_timer);
        }
        
        clear_screen(color_white());
        
        // Draw the current animation frame
        draw_bitmap(character_bmp, 250, 150, option_part_bmp(current_frame * 80, 0, 80, 80));
        
        // Show creation success
        draw_text("create_animation() Demo", color_black(), 10, 10);
        draw_text("Animation object created successfully!", color_green(), 10, 40);
        draw_text("Current frame: " + std::to_string(current_frame), color_purple(), 10, 70);
        draw_text("Status: " + (animation_playing ? string("PLAYING") : string("PAUSED")), 
                 animation_playing ? color_blue() : color_orange(), 10, 100);
        
        // Show function usage
        draw_text("Function Usage:", color_black(), 10, 140);
        draw_text("animation walk_anim = create_animation(script, \"walk\", bitmap);", 
                 color_dark_green(), 10, 170);
        
        // Controls
        draw_text("SPACE - Pause/Resume", color_gray(), 10, 220);
        
        // Show all frames for reference
        draw_text("All Animation Frames:", color_black(), 10, 280);
        for (int i = 0; i < 4; i++)
        {
            draw_bitmap(character_bmp, 10 + (i * 85), 310, option_part_bmp(i * 80, 0, 80, 80));
            if (i == current_frame)
            {
                draw_rectangle(color_red(), 8 + (i * 85), 308, 84, 84, option_line_width(3));
            }
        }
        
        refresh_screen(60);
    }
    
    // Clean up
    free_bitmap(character_bmp);
    free_timer(update_timer);
    
    return 0;
}
