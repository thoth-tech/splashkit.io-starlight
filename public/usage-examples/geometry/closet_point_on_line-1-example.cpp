#include "splashkit.h"

int main()
{
    open_window("Closest Point on Line", 600, 600);

    point_2d from_pt, closest_pt;
    line my_line = line_from(100, 100, 500, 400);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        from_pt = mouse_position();
        closest_pt = closest_point_on_line(from_pt, my_line);

        draw_line_record(COLOR_BLACK, my_line);
        fill_circle(COLOR_BLUE, from_pt.x, from_pt.y, 5);
        fill_circle(COLOR_RED, closest_pt.x, closest_pt.y, 5);
        draw_line(COLOR_GRAY, from_pt, closest_pt);

        draw_text("Mouse: " + point_to_string(from_pt), COLOR_BLACK, 20, 520);
        draw_text("Closest: " + point_to_string(closest_pt), COLOR_RED, 20, 540);

        refresh_screen();
    }

    close_window("Closest Point on Line");
    return 0;
}
