#include "splashkit.h"

void draw_line(color c, const line &my_line)
{
    draw_line(c, my_line.start_point, my_line.end_point);
}

int main()
{
    open_window("Magnetic Point", 600, 600);

    line my_line = line_from(100, 100, 500, 400);
    point_2d mouse_pos, closest_pt;

    while (!quit_requested())
    {
        process_events();
        mouse_pos = mouse_position();
        closest_pt = closest_point_on_line(mouse_pos, my_line);

        clear_screen(COLOR_WHITE);
        draw_line(COLOR_BLACK, my_line);
        fill_circle(COLOR_BLUE, mouse_pos.x, mouse_pos.y, 5);
        fill_circle(COLOR_RED, closest_pt.x, closest_pt.y, 5);
        draw_line(COLOR_GRAY, mouse_pos.x, mouse_pos.y, closest_pt.x, closest_pt.y);

        draw_text("Mouse: " + point_to_string(mouse_pos), COLOR_BLACK, 20, 520);
        draw_text("Closest: " + point_to_string(closest_pt), COLOR_RED, 20, 540);

        refresh_screen();
    }

    close_all_windows();
    return 0;
}
