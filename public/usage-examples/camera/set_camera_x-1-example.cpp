#include "splashkit.h"

int main()
{
    open_window("Set Camera X Example", 800, 600);

    double x = 0;

    while (!quit_requested())
    {
        process_events();

        if (key_down(LEFT_KEY))
            x -= 5;

        if (key_down(RIGHT_KEY))
            x += 5;

        set_camera_x(x);

        clear_screen(COLOR_WHITE);

        fill_rectangle(COLOR_RED, 100, 200, 100, 100);
        fill_rectangle(COLOR_GREEN, 1000, 200, 100, 100);

        draw_text(
            "Camera X: " + std::to_string(camera_x()),
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