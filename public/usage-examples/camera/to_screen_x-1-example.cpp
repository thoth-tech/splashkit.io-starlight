#include "splashkit.h"

int main()
{
    open_window("Landmark Tracker", 800, 450);

    // The tower stays at this world position, wherever the camera is looking
    double tower_x = 400;

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

        // Shapes are drawn in world coordinates, so they slide across the window with the camera
        draw_line(COLOR_GRAY, -2000, 350, 4000, 350);
        fill_rectangle(COLOR_DARK_RED, tower_x - 20, 230, 40, 120);

        // Ask the camera where the tower's world position appears on the screen
        double tower_screen_x = to_screen_x(tower_x);

        // A marker at that screen position, drawn with option_to_screen() so the camera does not move it
        draw_line(COLOR_BLUE, tower_screen_x, 100, tower_screen_x, 395, option_to_screen());

        draw_text("Tower world x: " + std::to_string((int)tower_x), COLOR_BLACK, "arial", 26, 30, 25, option_to_screen());
        draw_text("Tower screen x: " + std::to_string((int)tower_screen_x), COLOR_BLACK, "arial", 26, 30, 65, option_to_screen());
        draw_text("Left and right arrows move the camera", COLOR_GRAY, "arial", 20, 30, 410, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
