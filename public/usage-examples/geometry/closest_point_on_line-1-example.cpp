#include "splashkit.h"

int main()
{
    open_window("Point of Attraction", 800, 600);

    // Declaring line and variable points
    point_2d cursor_pos;
    point_2d closest_point;
    line line = line_from(150, 150, 500, 500);

    while (!quit_requested())
    {
        process_events();

        cursor_pos = mouse_position();
        closest_point = closest_point_on_line(cursor_pos, line);

        // Draw the line and display results
        clear_screen(color_white());
        draw_line(color_black(), line);
        fill_circle(color_red(), cursor_pos.x, cursor_pos.y, 5);
        fill_circle(color_blue(), closest_point.x, closest_point.y, 5);
        draw_line(color_green(), cursor_pos, closest_point);
        draw_text("Cursor Position: " + point_to_string(cursor_pos), color_black(), 20, 40);
        draw_text("Closest Point on Line: " + point_to_string(closest_point), color_black(), 20, 80);
        refresh_screen();
    }

    close_all_windows();
    return 0;
}