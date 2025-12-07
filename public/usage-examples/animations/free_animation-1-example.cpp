#include "splashkit.h"

int main()
{
    open_window("Free Animation Example", 800, 600);

    // Load animation script
    animation_script script = load_animation_script("kermit", "kermit.txt");

    // Create animation
    animation anim = create_animation(script, "SplashKitOnlineDemo");
    bool animation_exists = true;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display instructions
        draw_text("Free Animation Demo", COLOR_BLACK, 300, 100);

        if (animation_exists)
        {
            draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 200);
            draw_text("Animation Status: Active", COLOR_GREEN, 300, 250);
            draw_text("Press F to FREE the animation", COLOR_ORANGE, 270, 400);

            update_animation(anim);
        }
        else
        {
            draw_text("Animation Status: Freed", COLOR_RED, 300, 250);
            draw_text("Press C to CREATE new animation", COLOR_ORANGE, 260, 400);
        }

        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        // Free animation when F is pressed
        if (key_typed(F_KEY) && animation_exists)
        {
            free_animation(anim);
            animation_exists = false;
        }

        // Create new animation when C is pressed
        if (key_typed(C_KEY) && !animation_exists)
        {
            anim = create_animation(script, "SplashKitOnlineDemo");
            animation_exists = true;
        }

        refresh_screen(60);
    }

    // Final cleanup
    if (animation_exists)
    {
        free_animation(anim);
    }
    free_animation_script(script);

    close_all_windows();
    return 0;
}
