#include "splashkit.h"

int main()
{
    open_window("Animation Ended Example", 800, 600);

    // Load animation script and create animation
    animation_script script = load_animation_script("kermit", "kermit.txt");
    animation anim = create_animation(script, "SplashKitOnlineDemo");

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display animation state
        draw_text("Animation Ended Example", COLOR_BLACK, 280, 100);
        draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 200);

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
