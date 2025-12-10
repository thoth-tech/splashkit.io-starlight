#include "splashkit.h"

int main()
{
    write_line("=== Update Animation Example ===");
    write_line("");
    
    // Load animation script and create animation
    animation_script script = load_animation_script("explosion", "explosion.txt");
    animation anim = create_animation(script, "Explosion");

    write_line("Starting animation sequence...");
    write_line("");
    
    int update_count = 0;
        draw_text("Frame Time: " + std::to_string(animation_frame_time(anim)), COLOR_GREEN, 300, 250);
        draw_text("Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"), COLOR_PURPLE, 300, 300);
        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        // Update the animation
        update_animation(anim);

        refresh_screen(60);
    }

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
