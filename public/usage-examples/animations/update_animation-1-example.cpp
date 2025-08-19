#include "splashkit.h"
#include <cmath>

int main()
{
    open_window("Update Animation Demo", 600, 400);
    
    // Create a spinner bitmap with 6 frames
    bitmap spinner_bmp = create_bitmap("spinner", 480, 80);
    clear_bitmap(spinner_bmp, color_white());
    
    // Draw 6 rotating frames
    for (int i = 0; i < 6; i++)
    {
        int x = i * 80;
        // Draw spinner background
        fill_circle_on_bitmap(spinner_bmp, color_light_blue(), x + 40, 40, 30);
        draw_circle_on_bitmap(spinner_bmp, color_black(), x + 40, 40, 30);
        
        // Draw rotating line (different angles)
        float angle = i * 60.0f; // 60 degrees per frame
        float radians = angle * 3.14159f / 180.0f; // Convert to radians
        int end_x = x + 40 + (int)(25 * cos(radians));
        int end_y = 40 + (int)(25 * sin(radians));
        draw_line_on_bitmap(spinner_bmp, color_red(), x + 40, 40, end_x, end_y);
        
        // Frame number
        draw_text_on_bitmap(spinner_bmp, std::to_string(i), color_black(), x + 37, 35);
    }
    
    bitmap_set_cell_details(spinner_bmp, 80, 80, 6, 1, 6);
    
    // Simulate update_animation functionality
    timer update_timer = create_timer("update");
    start_timer(update_timer);
    int current_frame = 0;
    bool auto_update = true;
    int update_count = 0;
    
    while (!window_close_requested("Update Animation Demo"))
    {
        process_events();
        
        // Toggle auto-update with SPACE
        if (key_typed(SPACE_KEY))
            auto_update = !auto_update;
            
        // Manual update with ENTER
        if (key_typed(RETURN_KEY))
        {
            current_frame = (current_frame + 1) % 6;
            update_count++;
        }
        
        // Auto update every 300ms
        if (auto_update && timer_ticks(update_timer) > 300)
        {
            // Simulate update_animation(anim) call
            current_frame = (current_frame + 1) % 6;
            update_count++;
            start_timer(update_timer);
        }
        
        clear_screen(color_white());
        
        // Draw current animation frame
        draw_bitmap(spinner_bmp, 250, 150, option_part_bmp(current_frame * 80, 0, 80, 80));
        
        // Show update information
        draw_text("update_animation() Demo", color_black(), 10, 10);
        draw_text("Function called " + std::to_string(update_count) + " times", color_green(), 10, 40);
        draw_text("Current frame: " + std::to_string(current_frame), color_blue(), 10, 70);
        draw_text("Auto-update: " + (auto_update ? string("ON") : string("OFF")), 
                 auto_update ? color_green() : color_red(), 10, 100);
        
        // Show function usage
        draw_text("Function Usage:", color_black(), 10, 140);
        draw_text("update_animation(my_animation);  // Advances to next frame", 
                 color_dark_green(), 10, 170);
        
        // Controls
        draw_text("Controls:", color_black(), 10, 220);
        draw_text("SPACE - Toggle auto-update", color_gray(), 20, 250);
        draw_text("ENTER - Manual update", color_gray(), 20, 280);
        
        // Show all frames
        draw_text("All Frames:", color_black(), 10, 320);
        for (int i = 0; i < 6; i++)
        {
            draw_bitmap(spinner_bmp, 10 + (i * 45), 350, option_part_bmp(i * 80, 0, 80, 80));
            if (i == current_frame)
            {
                draw_rectangle(color_red(), 8 + (i * 45), 348, 44, 44, option_line_width(3));
            }
        }
        
        refresh_screen(60);
    }
    
    free_bitmap(spinner_bmp);
    free_timer(update_timer);
    
    return 0;
}
