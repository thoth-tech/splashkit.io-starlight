#include "splashkit.h"

int main()
{
    open_window("Crosshair Ruler", 800, 450);

    // The crosshair stays in the middle of the window, at this screen position
    double crosshair_x = 400;

    while (!quit_requested())
    {
        process_events();

        // The arrow keys slide the camera along the world
        if (key_down(LEFT_KEY))
        {
            move_camera_by(-4, 0);
        }

        if (key_down(RIGHT_KEY))
        {
            move_camera_by(4, 0);
        }

        clear_screen(COLOR_WHITE);

        // The ruler is part of the world, so it slides with the camera
        for (int tick = -1000; tick <= 3000; tick += 100)
        {
            draw_line(COLOR_GRAY, tick, 150, tick, 300);
            draw_text(std::to_string(tick), COLOR_BLACK, "arial", 18, tick + 5, 305);
        }

        // The crosshair is drawn with option_to_screen() so the camera does not move it
        draw_line(COLOR_RED, crosshair_x, 70, crosshair_x, 395, option_to_screen());

        // Turn the crosshair's screen position back into a position in the world
        double crosshair_world_x = to_world_x(crosshair_x);

        draw_text("World x under the crosshair: " + std::to_string((int)crosshair_world_x), COLOR_BLACK, "arial", 26, 30, 25, option_to_screen());
        draw_text("Left and right arrows move the camera", COLOR_GRAY, "arial", 20, 30, 410, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
