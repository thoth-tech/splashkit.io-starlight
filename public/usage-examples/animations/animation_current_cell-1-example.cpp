#include "splashkit.h"

int main()
{
    // Setup animation window
    window window = open_window("Animation Current Cell", 800, 600);
    
    // Create a simple bitmap programmatically for demonstration
    bitmap demo_bmp = create_bitmap("demo", 320, 64);
    clear_bitmap(demo_bmp, color_white());
    
    // Draw 8 numbered frames on the bitmap
    for (int i = 0; i < 8; i++)
    {
        int x = i * 40;
        fill_rectangle_on_bitmap(demo_bmp, color_light_gray(), x, 0, 40, 64);
        draw_rectangle_on_bitmap(demo_bmp, color_black(), x, 0, 40, 64);
        draw_text_on_bitmap(demo_bmp, std::to_string(i), color_black(), x + 15, 25);
    }
    
    // Set cell details for 8 frames
    bitmap_set_cell_details(demo_bmp, 40, 64, 8, 1, 8);
    
    // Variables for manual animation control
    int current_frame = 0;
    timer animation_timer = create_timer("anim_timer");
    start_timer(animation_timer);
    bool paused = false;
    
    while (!window_close_requested(window))
    {
        process_events();
        
        // Control animation with spacebar
        if (key_typed(SPACE_KEY))
            paused = !paused;
            
        // Manual frame control with arrow keys
        if (key_typed(LEFT_KEY) && current_frame > 0)
            current_frame--;
        if (key_typed(RIGHT_KEY) && current_frame < 7)
            current_frame++;
            
        // Auto-advance frame every 800ms
        if (!paused && timer_ticks(animation_timer) > 800)
        {
            current_frame = (current_frame + 1) % 8;
            start_timer(animation_timer);
        }
        
        clear_screen(color_light_blue());
        
        // Demonstrate animation_current_cell by showing the frame
        // (In real usage, you'd get this from animation_current_cell(animation))
        bitmap_set_cell_details(demo_bmp, 40, 64, 8, 1, 8);
        
        // Draw the current frame using bitmap with cell
        draw_bitmap(demo_bmp, 300, 200, option_part_bmp(current_frame * 40, 0, 40, 64));
        
        // Draw frame information 
        draw_text("Animation Current Cell Demo", color_black(), 10, 10);
        draw_text("Current Cell: " + std::to_string(current_frame), color_red(), 10, 50);
        draw_text("Frame Value: " + std::to_string(current_frame), color_dark_green(), 10, 80);
        
        // Draw controls
        draw_text("Controls:", color_black(), 10, 150);
        draw_text("SPACE - Pause/Resume", color_blue(), 20, 180);
        draw_text("LEFT/RIGHT - Manual Control", color_blue(), 20, 200);
        
        // Animation status
        string status = paused ? "PAUSED" : "PLAYING";
        color status_color = paused ? color_red() : color_green();
        draw_text("Status: " + status, status_color, 10, 250);
        
        // Progress indicator
        draw_text("Animation Progress:", color_black(), 10, 320);
        int progress_width = 300;
        int progress_x = 10;
        int progress_y = 350;
        
        // Background bar
        draw_rectangle(color_white(), progress_x, progress_y, progress_width, 20);
        draw_rectangle(color_black(), progress_x, progress_y, progress_width, 20, option_line_width(2));
        
        // Progress fill (0-7 frames)
        float progress = (float)current_frame / 7.0f;
        int fill_width = (int)(progress * (progress_width - 4));
        draw_rectangle(color_orange(), progress_x + 2, progress_y + 2, fill_width, 16);
        
        // Frame markers
        for (int i = 0; i <= 7; i++)
        {
            int marker_x = progress_x + (i * (progress_width / 7));
            draw_line(color_gray(), marker_x, progress_y - 5, marker_x, progress_y + 25);
            draw_text(std::to_string(i), color_gray(), marker_x - 5, progress_y + 30);
        }
        
        // Show all frames for reference
        draw_text("All Frames:", color_black(), 10, 450);
        for (int i = 0; i < 8; i++)
        {
            draw_bitmap(demo_bmp, 10 + (i * 45), 480, option_part_bmp(i * 40, 0, 40, 64));
            if (i == current_frame)
            {
                draw_rectangle(color_red(), 8 + (i * 45), 478, 44, 68, option_line_width(3));
            }
        }
        
        refresh_screen(60);
    }
    
    // Clean up resources
    free_bitmap(demo_bmp);
    free_timer(animation_timer);
    close_window(window);
    
    return 0;
}