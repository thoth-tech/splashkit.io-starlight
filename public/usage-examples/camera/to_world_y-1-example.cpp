#include "splashkit.h"

int main()
{
    open_window("Depth Gauge", 800, 450);

    // The crosshair stays in the middle of the window, at this screen position
    double crosshair_y = 225;

    while (!quit_requested())
    {
        process_events();

        // The arrow keys slide the camera up and down the world
        if (key_down(UP_KEY))
        {
            move_camera_by(0, -4);
        }

        if (key_down(DOWN_KEY))
        {
            move_camera_by(0, 4);
        }

        clear_screen(COLOR_WHITE);

        // The gauge is part of the world, so it slides with the camera
        for (int tick = -1000; tick <= 3000; tick += 100)
        {
            draw_line(COLOR_GRAY, 480, tick, 680, tick);
            draw_text(std::to_string(tick), COLOR_BLACK, "arial", 18, 690, tick - 10);
        }

        // The crosshair is drawn with option_to_screen() so the camera does not move it
        draw_line(COLOR_RED, 0, crosshair_y, 800, crosshair_y, option_to_screen());

        // Turn the crosshair's screen position back into a position in the world
        double crosshair_world_y = to_world_y(crosshair_y);

        draw_text("World y under the crosshair: " + std::to_string((int)crosshair_world_y), COLOR_BLACK, "arial", 26, 30, 25, option_to_screen());
        draw_text("Up and down arrows move the camera", COLOR_GRAY, "arial", 20, 30, 410, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
