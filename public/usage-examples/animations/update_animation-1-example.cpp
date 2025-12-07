#include "splashkit.h"

int main()
{
    open_window("Update Animation Example", 800, 600);

    // Load animation script and create animation
    animation_script script = load_animation_script("kermit", "kermit.txt");
    animation anim = create_animation(script, "SplashKitOnlineDemo");

    // Animation loop
    while (!quit_requested() && !animation_ended(anim))
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display current animation state
        draw_text("Update Animation Demo", COLOR_BLACK, 300, 100);
        draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 200);
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
