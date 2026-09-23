#include "splashkit.h"

int main()
{
    open_window("Sliding Bottom Edge", 800, 600);

    // Slide the rectangle up and down so the bottom edge keeps moving
    double box_y = 100;
    double slide_step = 2;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        rectangle box = rectangle_from(250, box_y, 300, 200);

        // The bottom edge is the top plus the height, so SplashKit works it out for us
        double bottom_edge = rectangle_bottom(box);

        draw_rectangle(COLOR_BLACK, box);
        draw_line(COLOR_RED, 0, bottom_edge, 800, bottom_edge);
        draw_text("Rectangle Bottom: " + std::to_string((int)bottom_edge), COLOR_BLACK, 50, 50);

        // Turn around at each end so the rectangle stays on screen
        box_y = box_y + slide_step;
        if (box_y > 300 || box_y < 100)
        {
            slide_step = -slide_step;
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
