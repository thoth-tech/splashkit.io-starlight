#include "splashkit.h"

int main()
{
    open_window("Free Animation Script Example", 800, 600);

    // Load animation script
    animation_script script = load_animation_script("kermit", "kermit.txt");
    bool script_loaded = true;

    animation anim = create_animation(script, "SplashKitOnlineDemo");
    bool animation_exists = true;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Display instructions
        draw_text("Free Animation Script Demo", COLOR_BLACK, 280, 100);

        if (script_loaded)
        {
            draw_text("Script Status: LOADED", COLOR_GREEN, 300, 200);

            if (animation_exists)
            {
                draw_text("Animation Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 250);
                update_animation(anim);
            }

            draw_text("Press F to free animation script", COLOR_ORANGE, 260, 400);
            draw_text("(Will also free the animation)", COLOR_GRAY, 280, 430);

            if (key_typed(F_KEY))
            {
                // First free the animation that uses this script
                if (animation_exists)
                {
                    free_animation(anim);
                    animation_exists = false;
                }
                // Then free the animation script
                free_animation_script(script);
                script_loaded = false;
            }
        }
        else
        {
            draw_text("Script Status: FREED", COLOR_RED, 300, 200);
            draw_text("Press L to load new script", COLOR_ORANGE, 280, 400);

            if (key_typed(L_KEY))
            {
                script = load_animation_script("kermit", "kermit.txt");
                script_loaded = true;
                anim = create_animation(script, "SplashKitOnlineDemo");
                animation_exists = true;
            }
        }

        draw_text("Press ESC to exit", COLOR_GRAY, 320, 500);

        refresh_screen(60);
    }

    // Final cleanup
    if (animation_exists)
    {
        free_animation(anim);
    }
    if (script_loaded)
    {
        free_animation_script(script);
    }

    close_all_windows();
    return 0;
}
