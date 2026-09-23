#include "splashkit.h"

int main()
{
    open_window("Tracking the Center Point", 800, 600);

    // Slide the rectangle diagonally so the center point keeps moving
    double box_x = 150;
    double box_y = 100;
    double slide_step = 2;

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        rectangle box = rectangle_from(box_x, box_y, 300, 200);

        // The center is half the width and half the height in from the corner
        point_2d center = rectangle_center(box);

        draw_rectangle(COLOR_BLACK, box);
        fill_circle(COLOR_RED, center, 8);
        draw_text("Rectangle Center: (" + std::to_string((int)center.x) + ", " + std::to_string((int)center.y) + ")", COLOR_BLACK, 50, 50);

        // Turn around at each end so the rectangle stays on screen
        box_x = box_x + slide_step;
        box_y = box_y + slide_step;
        if (box_x > 350 || box_x < 150)
        {
            slide_step = -slide_step;
        }

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
