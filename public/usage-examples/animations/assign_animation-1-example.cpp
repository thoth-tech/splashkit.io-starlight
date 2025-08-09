#include "splashkit.h"

int main()
{
    open_window("Animation State Switching", 800, 600);
    
    // Load animation script and bitmap for player character
    animation_script player_script = load_animation_script("player_states", "player.txt");
    bitmap player_bmp = load_bitmap("player", "player.png");
    bitmap_set_cell_details(player_bmp, 64, 64, 4, 4, 16); // 4x4 grid, 16 frames
    
    // Create animation starting with idle state
    animation player_anim = create_animation(player_script, "idle");
    
    point_2d player_pos = {400, 300};
    string current_state = "idle";
    
    while (!quit_requested())
    {
        process_events();
        
        // Switch animations based on keyboard input
        if (key_typed(key_num_1))
        {
            assign_animation(player_anim, "idle");
            current_state = "idle";
        }
        else if (key_typed(key_num_2))
        {
            assign_animation(player_anim, "walk");
            current_state = "walk";
        }
        else if (key_typed(key_num_3))
        {
            assign_animation(player_anim, "run");
            current_state = "run";
        }
        else if (key_typed(key_num_4))
        {
            assign_animation(player_anim, "jump");
            current_state = "jump";
        }
        
        // Update animation
        update_animation(player_anim);
        
        clear_screen(color_light_gray());
        
        // Draw player character
        draw_bitmap(player_bmp, player_pos.x - 32, player_pos.y - 32,
                   option_with_animation(player_anim));
        
        // Draw instructions and current state
        draw_text("Animation State Switching", color_black(), 10, 10);
        draw_text("Press 1-4 to change animation:", color_black(), 10, 30);
        draw_text("1: Idle  2: Walk  3: Run  4: Jump", color_black(), 10, 50);
        draw_text("Current State: " + current_state, color_red(), 10, 80);
        draw_text("Animation: " + animation_name(player_anim), color_blue(), 10, 100);
        draw_text("Frame: " + std::to_string(animation_current_cell(player_anim)), 
                 color_blue(), 10, 120);
        
        // Draw state indicator
        int indicator_x = 10;
        int indicator_y = 150;
        
        if (current_state == "idle") draw_rectangle(color_green(), indicator_x, indicator_y, 50, 20);
        else draw_rectangle(color_gray(), indicator_x, indicator_y, 50, 20);
        draw_text("IDLE", color_white(), indicator_x + 10, indicator_y + 5);
        
        indicator_x += 60;
        if (current_state == "walk") draw_rectangle(color_green(), indicator_x, indicator_y, 50, 20);
        else draw_rectangle(color_gray(), indicator_x, indicator_y, 50, 20);
        draw_text("WALK", color_white(), indicator_x + 10, indicator_y + 5);
        
        indicator_x += 60;
        if (current_state == "run") draw_rectangle(color_green(), indicator_x, indicator_y, 50, 20);
        else draw_rectangle(color_gray(), indicator_x, indicator_y, 50, 20);
        draw_text("RUN", color_white(), indicator_x + 15, indicator_y + 5);
        
        indicator_x += 60;
        if (current_state == "jump") draw_rectangle(color_green(), indicator_x, indicator_y, 50, 20);
        else draw_rectangle(color_gray(), indicator_x, indicator_y, 50, 20);
        draw_text("JUMP", color_white(), indicator_x + 10, indicator_y + 5);
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(player_anim);
    free_animation_script(player_script);
    free_bitmap(player_bmp);
    close_all_windows();
    
    return 0;
}
