#include "splashkit.h"
#include <string>

void draw_line(const line &my_line, color c)
{
    draw_line(c, my_line.start_point, my_line.end_point);
}

int main()
{
    window window = open_window("Magnetic Point", 600, 600);
    line my_line = line_from(100, 100, 500, 400);

    while (!window_close_requested(window))
    {
        process_events();

        point_2d mouse = mouse_position();
        point_2d closest = closest_point_on_line(mouse, my_line);

        clear_screen(COLOR_WHITE);
        draw_line(my_line, COLOR_BLACK);

        fill_circle(COLOR_BLUE, mouse.x, mouse.y, 5);
        fill_circle(COLOR_RED, closest.x, closest.y, 5);
        draw_line(COLOR_GRAY, mouse.x, mouse.y, closest.x, closest.y);

        // Convert point to string and draw text
        string mouse_text = "Mouse: (" + to_string(mouse.x) + ", " + to_string(mouse.y) + ")";
        string closest_text = "Closest: (" + to_string(closest.x) + ", " + to_string(closest.y) + ")";

        draw_text(mouse_text.c_str(), COLOR_BLACK, 14, 20, 520);
        draw_text(closest_text.c_str(), COLOR_RED, 14, 20, 540);

        refresh_screen();
    }

    close_window(window);
    return 0;
}

