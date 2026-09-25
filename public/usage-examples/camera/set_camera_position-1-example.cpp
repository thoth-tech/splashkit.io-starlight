#include "splashkit.h"

int main()
{
    open_window("Set Camera Position Example", 400, 300);

    double camera_x = 0;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Move the camera position each frame
        set_camera_position(point_at(camera_x, 0));
        camera_x += 1;

        // A stationary object in the world - it does not move itself
        fill_rectangle(COLOR_RED, 200, 100, 50, 50);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}