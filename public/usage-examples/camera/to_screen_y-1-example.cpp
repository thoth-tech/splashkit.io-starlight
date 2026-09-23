#include "splashkit.h"

int main()
{
    open_window("Balloon Height", 800, 450);

    // The balloon stays at this world position, wherever the camera is looking
    double balloon_x = 600;
    double balloon_y = 225;

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

        // Shapes are drawn in world coordinates, so they slide across the window with the camera
        draw_line(COLOR_GRAY, 400, 420, 800, 420);
        draw_line(COLOR_GRAY, balloon_x, balloon_y + 40, balloon_x, 420);
        fill_circle(COLOR_RED, balloon_x, balloon_y, 40);

        // Ask the camera where the balloon's world position appears on the screen
        double balloon_screen_y = to_screen_y(balloon_y);

        // A marker at that screen position, drawn with option_to_screen() so the camera does not move it
        draw_line(COLOR_BLUE, 380, balloon_screen_y, 800, balloon_screen_y, option_to_screen());

        draw_text("Balloon world y: " + std::to_string((int)balloon_y), COLOR_BLACK, "arial", 26, 30, 25, option_to_screen());
        draw_text("Balloon screen y: " + std::to_string((int)balloon_screen_y), COLOR_BLACK, "arial", 26, 30, 65, option_to_screen());
        draw_text("Up and down arrows move the camera", COLOR_GRAY, "arial", 20, 30, 410, option_to_screen());

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
