#include "splashkit.h"

int main()
{
    open_window("Camera Y Example", 800, 600);

    while (!quit_requested())
    {
        process_events();

        if (key_down(UP_KEY))
            move_camera_by(0, -5);

        if (key_down(DOWN_KEY))
            move_camera_by(0, 5);

        clear_screen(COLOR_WHITE);

        fill_rectangle(COLOR_RED, 200, 100, 100, 100);
        fill_rectangle(COLOR_GREEN, 200, 1000, 100, 100);

        draw_text(
            "Camera Y: " + std::to_string(camera_y()),
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