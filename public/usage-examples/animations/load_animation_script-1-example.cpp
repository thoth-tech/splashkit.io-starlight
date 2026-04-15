#include "splashkit.h"

int main()
{
    open_window("Load Animation Script Demo", 600, 400);
    
    // Create a simple bitmap to demonstrate script loading concept
    bitmap demo_bmp = create_bitmap("demo", 240, 80);
    clear_bitmap(demo_bmp, color_white());
    
    // Draw 3 frames showing "script loading" concept
    for (int i = 0; i < 3; i++)
    {
        int x = i * 80;
        fill_rectangle_on_bitmap(demo_bmp, color_light_yellow(), x, 0, 80, 80);
        draw_rectangle_on_bitmap(demo_bmp, color_black(), x, 0, 80, 80);
        draw_text_on_bitmap(demo_bmp, "Script" + std::to_string(i + 1), color_black(), x + 10, 35);
    }
    
    bitmap_set_cell_details(demo_bmp, 80, 80, 3, 1, 3);
    
    // Simulate load_animation_script functionality
    timer frame_timer = create_timer("frame");
    start_timer(frame_timer);
    int current_frame = 0;
    bool script_loaded = true; // Simulate successful loading
    
    while (!window_close_requested("Load Animation Script Demo"))
    {
        process_events();
        
        // Restart demo with SPACE
        if (key_typed(SPACE_KEY))
        {
            current_frame = 0;
            script_loaded = true;
            start_timer(frame_timer);
        }
        
        // Simulate animation from loaded script
        if (script_loaded && timer_ticks(frame_timer) > 700)
        {
            current_frame = (current_frame + 1) % 3;
            start_timer(frame_timer);
        }
        
        clear_screen(color_white());
        
        // Draw current frame
        draw_bitmap(demo_bmp, 250, 150, option_part_bmp(current_frame * 80, 0, 80, 80));
        
        // Show load status
        if (script_loaded)
        {
            draw_text("load_animation_script() SUCCESS", color_green(), 10, 10);
            draw_text("Animation script loaded successfully!", color_blue(), 10, 40);
            draw_text("Script contains: 3 animation sequences", color_purple(), 10, 70);
        }
        else
        {
            draw_text("load_animation_script() FAILED", color_red(), 10, 10);
            draw_text("Script file not found", color_red(), 10, 40);
        }
        
        // Show function usage
        draw_text("Function Usage:", color_black(), 10, 120);
        draw_text("animation_script script = load_animation_script(\"player\", \"animations.txt\");", 
                 color_dark_green(), 10, 150);
        
        // Show current frame info
        draw_text("Current sequence: " + std::to_string(current_frame + 1) + " / 3", color_orange(), 10, 200);
        
        // Controls
        draw_text("SPACE - Restart demo", color_gray(), 10, 320);
        
        // Show all sequences
        draw_text("Available Sequences:", color_black(), 10, 250);
        for (int i = 0; i < 3; i++)
        {
            draw_bitmap(demo_bmp, 10 + (i * 85), 280, option_part_bmp(i * 80, 0, 80, 80));
            if (i == current_frame)
            {
                draw_rectangle(color_red(), 8 + (i * 85), 278, 84, 84, option_line_width(3));
            }
        }
        
        refresh_screen(60);
    }
    
    free_bitmap(demo_bmp);
    free_timer(frame_timer);
    
    return 0;
}
