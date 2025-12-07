#include "splashkit.h"

int main()
{
    open_window("Create Animation Example", 800, 600);

    // Load the animation script
    animation_script script = load_animation_script("kermit", "kermit.txt");

    // Create an animation from the script
    animation anim = create_animation(script, "SplashKitOnlineDemo");

    // Display animation information
    clear_screen(COLOR_WHITE);
    draw_text("Animation Created Successfully!", COLOR_GREEN, 280, 200);
    draw_text("Animation Name: SplashKitOnlineDemo", COLOR_BLACK, 260, 250);
    draw_text("Current Cell: " + std::to_string(animation_current_cell(anim)), COLOR_BLUE, 300, 300);
    draw_text("Animation Ended: " + string(animation_ended(anim) ? "Yes" : "No"), COLOR_PURPLE, 300, 350);
    draw_text("Frame Time: " + std::to_string(animation_frame_time(anim)), COLOR_ORANGE, 300, 400);
    refresh_screen();

    delay(5000);

    // Free resources
    free_animation(anim);
    free_animation_script(script);

    close_all_windows();
    return 0;
}
