#include "splashkit.h"

int main()
{
    open_window("Animation Demo", 800, 600);
    
    // Load animation script
    load_animation_script("player", "player.txt");
    
    // Create animation
    animation player_anim = create_animation("player", "WalkFront");
    
    // Main game loop
    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);
        
        // Update and draw animation
        update_animation(player_anim);
        draw_animation(player_anim, 400, 300);
        
        refresh_screen(60);
    }
    
    close_all_windows();
    return 0;
}
