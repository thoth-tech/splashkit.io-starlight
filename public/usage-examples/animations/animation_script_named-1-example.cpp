#include "splashkit.h"

int main()
{
    open_window("Animation Script Management", 800, 600);
    
    // Load multiple animation scripts
    animation_script player_script = load_animation_script("player_anims", "player.txt");
    animation_script enemy_script = load_animation_script("enemy_anims", "enemy.txt");
    animation_script effects_script = load_animation_script("effect_anims", "effects.txt");
    
    // Load bitmaps
    bitmap player_bmp = load_bitmap("player", "player.png");
    bitmap enemy_bmp = load_bitmap("enemy", "enemy.png");
    bitmap effects_bmp = load_bitmap("effects", "effects.png");
    
    bitmap_set_cell_details(player_bmp, 64, 64, 4, 4, 16);
    bitmap_set_cell_details(enemy_bmp, 48, 48, 3, 3, 9);
    bitmap_set_cell_details(effects_bmp, 32, 32, 2, 4, 8);
    
    // Create animations
    animation player_anim = create_animation(player_script, "walk");
    animation enemy_anim = create_animation(enemy_script, "patrol");
    animation effect_anim = create_animation(effects_script, "explosion");
    
    string script_names[3] = {"player_anims", "enemy_anims", "effect_anims"};
    int selected_script = 0;
    
    while (!quit_requested())
    {
        process_events();
        
        // Switch between scripts with arrow keys
        if (key_typed(key_left_arrow))
        {
            selected_script = (selected_script - 1 + 3) % 3;
        }
        else if (key_typed(key_right_arrow))
        {
            selected_script = (selected_script + 1) % 3;
        }
        
        // Get script by name using animation_script_named
        animation_script current_script = animation_script_named(script_names[selected_script]);
        
        // Update animations
        update_animation(player_anim);
        update_animation(enemy_anim);
        update_animation(effect_anim);
        
        clear_screen(color_light_gray());
        
        // Draw entities
        draw_bitmap(player_bmp, 100, 200, option_with_animation(player_anim));
        draw_bitmap(enemy_bmp, 300, 200, option_with_animation(enemy_anim));
        draw_bitmap(effects_bmp, 500, 200, option_with_animation(effect_anim));
        
        // Draw labels
        draw_text("Player", color_blue(), 100, 180);
        draw_text("Enemy", color_red(), 300, 180);
        draw_text("Effects", color_green(), 500, 180);
        
        // Draw UI
        draw_text("Animation Script Management", color_black(), 10, 10);
        draw_text("Use LEFT/RIGHT arrows to select script", color_black(), 10, 30);
        draw_text("Selected Script: " + script_names[selected_script], color_purple(), 10, 60);
        
        // Show script information
        if (current_script == player_script)
        {
            draw_text(">>> PLAYER SCRIPT SELECTED <<<", color_blue(), 10, 90);
            draw_text("Contains: walk, idle, run, jump animations", color_blue(), 10, 110);
            draw_rectangle(color_blue(), 95, 175, 74, 74, option_line_width(3));
        }
        else if (current_script == enemy_script)
        {
            draw_text(">>> ENEMY SCRIPT SELECTED <<<", color_red(), 10, 90);
            draw_text("Contains: patrol, attack, death animations", color_red(), 10, 110);
            draw_rectangle(color_red(), 295, 175, 58, 58, option_line_width(3));
        }
        else if (current_script == effects_script)
        {
            draw_text(">>> EFFECTS SCRIPT SELECTED <<<", color_green(), 10, 90);
            draw_text("Contains: explosion, spark, smoke animations", color_green(), 10, 110);
            draw_rectangle(color_green(), 495, 175, 42, 42, option_line_width(3));
        }
        
        // Demonstrate script validation
        draw_text("Script Validation:", color_black(), 10, 140);
        
        // Check if scripts exist
        bool player_exists = (animation_script_named("player_anims") != nullptr);
        bool enemy_exists = (animation_script_named("enemy_anims") != nullptr);
        bool effects_exists = (animation_script_named("effect_anims") != nullptr);
        bool invalid_exists = (animation_script_named("nonexistent") != nullptr);
        
        string player_status = player_exists ? "✓ Found" : "✗ Missing";
        string enemy_status = enemy_exists ? "✓ Found" : "✗ Missing";
        string effects_status = effects_exists ? "✓ Found" : "✗ Missing";
        string invalid_status = invalid_exists ? "✗ Error" : "✓ Correctly Not Found";
        
        color found_color = color_green();
        color missing_color = color_red();
        
        draw_text("player_anims: " + player_status, 
                 player_exists ? found_color : missing_color, 200, 140);
        draw_text("enemy_anims: " + enemy_status, 
                 enemy_exists ? found_color : missing_color, 200, 160);
        draw_text("effect_anims: " + effects_status, 
                 effects_exists ? found_color : missing_color, 200, 180);
        draw_text("nonexistent: " + invalid_status, found_color, 200, 200);
        
        // Show current script details
        draw_text("Current Script Details:", color_black(), 10, 300);
        if (current_script != nullptr)
        {
            draw_text("Script is valid and loaded", color_green(), 10, 320);
            draw_text("Can create animations from this script", color_green(), 10, 340);
        }
        else
        {
            draw_text("Script not found or invalid", color_red(), 10, 320);
        }
        
        refresh_screen(60);
    }
    
    // Clean up
    free_animation(player_anim);
    free_animation(enemy_anim);
    free_animation(effect_anim);
    free_animation_script(player_script);
    free_animation_script(enemy_script);
    free_animation_script(effects_script);
    free_bitmap(player_bmp);
    free_bitmap(enemy_bmp);
    free_bitmap(effects_bmp);
    close_all_windows();
    
    return 0;
}
