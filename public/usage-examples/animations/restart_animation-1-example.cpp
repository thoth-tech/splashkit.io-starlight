#include "splashkit.h"

int main()
{
    write_line("=== Restart Animation Example ===");
    write_line("");
    
    // Load animation script and create animation
    animation_script script = load_animation_script("explosion", "explosion.txt");
    animation anim = create_animation(script, "Explosion");

    int restart_count = 0;
    
    write_line("Initial State:");
    write_line("  Current Cell: " + std::to_string(animation_current_cell(anim)));
    write_line("  Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"));
    write_line("");
        draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 200);
        draw_text("Restart Count: " + std::to_string(restart_count), COLOR_GREEN, 300, 250);
        draw_text("Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"), COLOR_PURPLE, 300, 300);
        draw_text("Press SPACE to restart animation", COLOR_ORANGE, 250, 400);
        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        // Restart animation when space is pressed
        if (key_typed(SPACE_KEY))
        {
            restart_animation(anim);
            restart_count++;
        }

        update_animation(anim);
        refresh_screen(60);
    }

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
