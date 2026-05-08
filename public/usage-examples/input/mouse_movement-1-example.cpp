#include "splashkit.h"
#include <string>

int main()
{
    open_window("Mouse Movement Display", 800, 600);

    double circle_x = 400;
    double circle_y = 300;

    while (!quit_requested())
    {
        process_events();

        vector_2d movement = mouse_movement();

        circle_x += movement.x;
        circle_y += movement.y;

        clear_screen(COLOR_WHITE);

        draw_text("Move the mouse to see mouse_movement() values.", COLOR_BLACK, 20, 20);
        draw_text(std::string("Movement X: ") + std::to_string(movement.x), COLOR_BLACK, 20, 60);
        draw_text(std::string("Movement Y: ") + std::to_string(movement.y), COLOR_BLACK, 20, 100);

        fill_circle(COLOR_BLUE, circle_x, circle_y, 15);
        draw_circle(COLOR_BLACK, circle_x, circle_y, 15);

        draw_line(COLOR_RED, circle_x, circle_y, circle_x + movement.x * 5, circle_y + movement.y * 5);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}