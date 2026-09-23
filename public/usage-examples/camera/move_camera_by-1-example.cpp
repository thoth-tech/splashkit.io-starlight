#include "splashkit.h"

int main()
{
    open_window("Move Camera By Example", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // Move the camera using the arrow keys
        if (key_down(LEFT_KEY))
            move_camera_by(-5, 0);

        if (key_down(RIGHT_KEY))
            move_camera_by(5, 0);

        if (key_down(UP_KEY))
            move_camera_by(0, -5);

        if (key_down(DOWN_KEY))
            move_camera_by(0, 5);

        clear_screen(COLOR_WHITE);

        // Stationary objects in the game world
        fill_rectangle(COLOR_RED, 100, 200, 100, 100);
        fill_circle(COLOR_BLUE, 600, 300, 50);
        fill_rectangle(COLOR_GREEN, 1100, 200, 100, 100);
        fill_circle(COLOR_RED, 600, 800, 60);

        // Keep the instructions fixed on the screen
        draw_text(
            "Use arrow keys to move the camera",
            COLOR_BLACK,
            20,
            20,
            option_to_screen()
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}