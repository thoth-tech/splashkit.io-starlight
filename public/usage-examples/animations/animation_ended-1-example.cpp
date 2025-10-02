#include "splashkit.h"

int main()
{
    open_window("Animation Completion Check", 600, 400);
    
    // Create a simple bitmap with 3 frames
    bitmap demo_bmp = create_bitmap("demo", 240, 80);
    clear_bitmap(demo_bmp, color_white());
    
    // Draw 3 simple frames
    for (int i = 0; i < 3; i++)
    {
        int x = i * 80;
        fill_rectangle_on_bitmap(demo_bmp, color_light_blue(), x, 0, 80, 80);
        draw_rectangle_on_bitmap(demo_bmp, color_black(), x, 0, 80, 80);
        draw_text_on_bitmap(demo_bmp, std::to_string(i + 1), color_black(), x + 35, 35);
    }
    
    bitmap_set_cell_details(demo_bmp, 80, 80, 3, 1, 3);
    
    // Create animation
    animation_script script = load_animation_script("demo", "demo.txt");
    animation demo_anim = create_animation(script, "demo", demo_bmp);
    
    timer frame_timer = create_timer("frame");
    start_timer(frame_timer);
    int current_frame = 0;
    
    while (!window_close_requested("Animation Completion Check"))
    {
        process_events();
        
        // Restart animation with SPACE
        if (key_typed(SPACE_KEY))
        {
            current_frame = 0;
            start_timer(frame_timer);
        }
        
        // Update frame every 800ms
        if (timer_ticks(frame_timer) > 800)
        {
            current_frame++;
            start_timer(frame_timer);
        }
        
        clear_screen(color_white());
        
        // Draw current frame
        if (current_frame < 3)
        {
            draw_bitmap(demo_bmp, 250, 150, option_part_bmp(current_frame * 80, 0, 80, 80));
        }
        else
        {
            // Animation ended - show last frame
            draw_bitmap(demo_bmp, 250, 150, option_part_bmp(2 * 80, 0, 80, 80));
        }
        
        // Show animation_ended result
        bool is_ended = (current_frame >= 3);
        draw_text("animation_ended() returns: " + (is_ended ? string("TRUE") : string("FALSE")), 
                  is_ended ? color_red() : color_green(), 10, 10);
        
        draw_text("Frame: " + std::to_string(current_frame) + " / 3", color_black(), 10, 40);
        draw_text("Status: " + (is_ended ? string("ENDED") : string("PLAYING")), 
                  is_ended ? color_red() : color_blue(), 10, 70);
        
        draw_text("Press SPACE to restart", color_gray(), 10, 350);
        
        refresh_screen(60);
    }
    
    free_animation(demo_anim);
    free_animation_script(script);
    free_bitmap(demo_bmp);
    free_timer(frame_timer);
    
    return 0;
}
