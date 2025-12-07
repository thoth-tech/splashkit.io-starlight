#include "splashkit.h"

int main()
{
    open_window("Load Animation Script", 800, 600);

    // Load an animation script from file
    animation_script kermit_script = load_animation_script("kermit", "kermit.txt");

    // Check if the script was loaded successfully
    if (has_animation_script("kermit"))
    {
        clear_screen(COLOR_WHITE);
        draw_text("Animation Script Loaded Successfully!", COLOR_GREEN, 250, 280);
        draw_text("Script Name: kermit", COLOR_BLACK, 300, 320);
        draw_text("Animation Count: " + std::to_string(animation_count(kermit_script)), COLOR_BLUE, 280, 360);
        refresh_screen();
    }

    delay(5000);

    // Free the animation script when done
    free_animation_script(kermit_script);

    close_all_windows();
    return 0;
}
