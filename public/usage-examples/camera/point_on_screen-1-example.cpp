#include "splashkit.h"

int main()
{
    open_window("Point On Screen Example", 400, 300);

    // Load the font used to display the visibility status text
    font status_font = load_font("StatusFont", "DejaVuSans.ttf");

    // A fixed point in the world we will check each frame
    point_2d world_point = point_at(500, 100);

    double camera_x = 0;

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        // Move the camera position each frame
        set_camera_position(point_at(camera_x, 0));
        camera_x += 5;

        // Draw a circle at the fixed world point - it does not move itself
        fill_circle(COLOR_RED, world_point, 20);

        // Convert the world point to screen coordinates, then check visibility
        // The text is drawn to_screen so it stays fixed and does not scroll with the camera
        if (point_on_screen(to_screen(world_point)))
        {
            draw_text("Point On Screen: TRUE", COLOR_BLACK, status_font, 20, 10, 10, option_to_screen());
        }
        else
        {
            draw_text("Point On Screen: FALSE", COLOR_BLACK, status_font, 20, 10, 10, option_to_screen());
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}