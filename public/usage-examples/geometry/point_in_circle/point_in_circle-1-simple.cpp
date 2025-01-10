#include "splashkit.h"

int main()
{
    // Let user create a circle
    write_line("Create a circle!");
    write_line("Center point x1: ");
    int x1 = convert_to_integer(read_line());
    write_line("Center point y1: ");
    int y1 = convert_to_integer(read_line());
    write_line("Radius for circle: ");
    int radius = convert_to_integer(read_line());

    // Let user create a point
    write_line("Create a point now!");
    write_line("x for point: ");
    int px1 = convert_to_integer(read_line());
    write_line("y for point: ");
    int py1 = convert_to_integer(read_line());

    open_window("Point In circle", 800, 600);
    clear_screen();

    // Create the circle base on the data given by user
    circle A = circle_at(x1, y1, radius);

    // Create the point base on the data given by user
    point_2d B = point_at(px1, py1);

    // Draw the circle
    draw_circle(COLOR_RED, A);

    // Draw the point
    fill_circle(COLOR_GREEN, px1, py1, 4);

    // Detect if the point in the circle or not
    if (point_in_circle(B, A))
    {
        write_line("Point in the circle!");
    }
    else
    {
        write_line("Point not in the circle!");
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}