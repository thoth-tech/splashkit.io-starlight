#include "splashkit.h"

int main()
{
    open_window("Set Camera Y Example", 800, 600);

    double y = 0;

    while (!quit_requested())
    {
        process_events();

        if (key_down(UP_KEY))
            y -= 5;

        if (key_down(DOWN_KEY))
            y += 5;

        set_camera_y(y);

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