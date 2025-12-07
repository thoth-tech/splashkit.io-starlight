#include "splashkit.h"

int main()
{
    open_window("Animation Entered Frame Example", 800, 600);

    // Load animation script and create animation
    animation_script script = load_animation_script("kermit", "kermit.txt");
    animation anim = create_animation(script, "SplashKitOnlineDemo");

    int frame_enter_count = 0;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display animation state
        draw_text("Animation Entered Frame Example", COLOR_BLACK, 260, 100);
        draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 200);

        // Check if animation entered a new frame using animation_entered_frame
        if (animation_entered_frame(anim))
        {
            frame_enter_count++;
            draw_text("Just entered NEW FRAME!", COLOR_GREEN, 290, 280);
        }
        else
        {
            draw_text("Same frame as before", COLOR_GRAY, 310, 280);
        }

        draw_text("Frame Entry Count: " + std::to_string(frame_enter_count), COLOR_PURPLE, 300, 340);

        // Display instructions
        draw_text("Press R to restart animation", COLOR_ORANGE, 280, 450);
        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        if (key_typed(R_KEY))
        {
            restart_animation(anim);
            frame_enter_count = 0;
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
