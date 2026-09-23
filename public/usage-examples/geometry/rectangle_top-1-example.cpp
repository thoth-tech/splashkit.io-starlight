#include "splashkit.h"

int main()
{
    open_window("Sliding Top Edge", 800, 600);

    // Slide the rectangle up and down so the top edge keeps moving
    double box_y = 100;
    double slide_step = 2;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        rectangle box = rectangle_from(250, box_y, 300, 200);

        // Ask SplashKit where the top edge sits, then mark it across the window
        double top_edge = rectangle_top(box);

        draw_rectangle(COLOR_BLACK, box);
        draw_line(COLOR_RED, 0, top_edge, 800, top_edge);
        draw_text("Rectangle Top: " + std::to_string((int)top_edge), COLOR_BLACK, 50, 50);

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
