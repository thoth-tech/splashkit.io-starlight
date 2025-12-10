#include "splashkit.h"

int main()
{
    // Load animation script and create animation
    animation_script script = load_animation_script("explosion", "explosion.txt");
    animation anim = create_animation(script, "Explosion");

    write_line("=== Animation Ended Example ===");
    write_line("");
    
    // Check animation state initially
    write_line("Initial State:");
    write_line("Current Cell: " + std::to_string(animation_current_cell(anim)));
    write_line("Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"));
    write_line("");
    
    // Update animation multiple times to reach the end
    write_line("Updating animation...");
    for (int i = 0; i < 50; i++)
    {
        update_animation(anim, 0.1f);

        // Check if animation has ended using animation_ended
        if (animation_ended(anim))
        {
            draw_text("Animation Status: ENDED", COLOR_RED, 300, 250);
            draw_text("Press R to restart", COLOR_ORANGE, 310, 350);

            if (key_typed(R_KEY))
            {
                restart_animation(anim);
            }
        }
        else
        {
            draw_text("Animation Status: RUNNING", COLOR_GREEN, 300, 250);
            update_animation(anim);
        }

        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        refresh_screen(60);
    }

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
