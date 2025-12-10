#include "splashkit.h"

int main()
{
    // Load animation script and create animation
    animation_script script = load_animation_script("explosion", "explosion.txt");
    animation anim = create_animation(script, "Explosion");

    write_line("=== Animation Frame Time Example ===");
    write_line("");
    write_line("Tracking frame time during animation...");
    write_line("");

        // Get and display frame time using animation_frame_time
        float frame_time = animation_frame_time(anim);
        draw_text("Frame Time: " + std::to_string(frame_time) + " ms", COLOR_GREEN, 300, 250);

        // Display instructions
        draw_text("Frame time shows how long this frame lasts", COLOR_PURPLE, 230, 350);
        draw_text("Press R to restart animation", COLOR_ORANGE, 280, 450);
        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        if (key_typed(R_KEY))
        {
            restart_animation(anim);
        }

        // Only update if animation hasn't ended
        if (!animation_ended(anim))
        {
            update_animation(anim);
        }

        refresh_screen(60);
    }

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
