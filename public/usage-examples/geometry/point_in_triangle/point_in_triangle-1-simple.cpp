#include "splashkit.h"

int main()
{
    // Let user create a triangle
    write_line("Create a triangle!");
    write_line("x1: ");
    int x1 = convert_to_integer(read_line());
    write_line("y1: ");
    int y1 = convert_to_integer(read_line());
    write_line("x2: ");
    int x2 = convert_to_integer(read_line());
    write_line("y2: ");
    int y2 = convert_to_integer(read_line());
    write_line("x3: ");
    int x3 = convert_to_integer(read_line());
    write_line("y3: ");
    int y3 = convert_to_integer(read_line());

    // Let user create a point
    write_line("Create a point now!");
    write_line("x for point: ");
    int px1 = convert_to_integer(read_line());
    write_line("y for point: ");
    int py1 = convert_to_integer(read_line());

    open_window("Point In Triangle", 800, 600);
    clear_screen();

    // Create the triangle base on the data given by user
    triangle A = triangle_from(x1, y1, x2, y2, x3, y3);

    // Create the point base on the data given by user
    point_2d B = point_at(px1, py1);

    // Draw the triangle
    draw_triangle(COLOR_RED, A);

    // Draw the point
    fill_circle(COLOR_GREEN, px1, py1, 4);

    // Detect if the point in the triangle or not
    if (point_in_triangle(B, A))
    {
        write_line("Point in the triangle!");
    }
    else
    {
        write_line("Point not in the triangle!");
    }

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}