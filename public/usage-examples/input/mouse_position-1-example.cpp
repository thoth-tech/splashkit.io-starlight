#include "splashkit.h"

int main()
{
    open_window("Mouse Position Display", 800, 600);

    while (!quit_requested())
    {
        process_events();

        point_2d mouse_point = mouse_position();

        clear_screen(COLOR_WHITE);

        draw_text("Move the mouse to track its position in the window.", COLOR_BLACK, 20, 20);
        draw_text("Mouse X: " + to_string(mouse_point.x), COLOR_BLACK, 20, 60);
        draw_text("Mouse Y: " + to_string(mouse_point.y), COLOR_BLACK, 20, 100);

        fill_circle(COLOR_BLUE, mouse_point.x, mouse_point.y, 8);
        draw_circle(COLOR_BLACK, mouse_point.x, mouse_point.y, 8);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}