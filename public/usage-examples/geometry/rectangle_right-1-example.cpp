#include "splashkit.h"

int main()
{
    open_window("Sliding Right Edge", 800, 600);

    // Slide the rectangle side to side so the right edge keeps moving
    double box_x = 150;
    double slide_step = 2;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        rectangle box = rectangle_from(box_x, 200, 300, 200);

        // The right edge is the left plus the width, so SplashKit works it out for us
        double right_edge = rectangle_right(box);

        draw_rectangle(COLOR_BLACK, box);
        draw_line(COLOR_RED, right_edge, 0, right_edge, 600);
        draw_text("Rectangle Right: " + std::to_string((int)right_edge), COLOR_BLACK, 50, 50);

        // Turn around at each end so the rectangle stays on screen
        box_x = box_x + slide_step;
        if (box_x > 350 || box_x < 150)
        {
            slide_step = -slide_step;
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
