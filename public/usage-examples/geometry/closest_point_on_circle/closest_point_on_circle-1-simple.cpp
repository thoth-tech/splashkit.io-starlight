#include "splashkit.h"

int main()
{
    // Prompt for x and y value 
    write("Enter x point: ");
    int x = convert_to_integer(read_line());
    write("Enter y point: ");
    int y = convert_to_integer(read_line());

    window wnd = open_window("Closest point", 600, 600);
    clear_screen();

    // Set circle point to center of screen and draw to screen
    point_2d circle_pnt = {300, 300};
    circle circle = circle_at(circle_pnt, 100);
    draw_circle(COLOR_BLACK, circle);

    refresh_screen();

    // Initialize the input points as a 2D point
    point_2d point = {x, y};

    // Get closest point to the point on circle 
    point_2d close_point = closest_point_on_circle(point, circle);

    // Draw circle to indicate points
    fill_circle_on_window(wnd, COLOR_RED, close_point.x, close_point.y, 5);
    fill_circle_on_window(wnd, COLOR_BLUE, point.x, point.y, 5);

    refresh_screen();

    delay(5000);

    close_all_windows();

    return 0;
}