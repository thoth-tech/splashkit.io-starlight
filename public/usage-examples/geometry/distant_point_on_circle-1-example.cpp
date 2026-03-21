#include "splashkit.h"

int main()
{
    // Create the circle and window used to demonstrate the distant point
    circle demo_circle = circle_at(400, 300, 120);
    window demo_window = open_window("Opposite Point to Mouse on Circle", 800, 600);

    while (!quit_requested())
    {
        process_events();
        // Use the mouse position as the point being tested
        point_2d test_point = mouse_position();

        // Find the point on the circle furthest from the mouse
        point_2d distant_point = distant_point_on_circle(test_point, demo_circle);

        // Centre point of the circle
        point_2d circle_center = center_point(demo_circle);

        clear_screen(COLOR_WHITE);

        // Draw the circle and helper lines to show the relationship clearly
        draw_circle(COLOR_BLACK, demo_circle);
        draw_line(COLOR_GRAY, circle_center, test_point);
        draw_line(COLOR_GREEN, circle_center, distant_point);

        // Highlight the important points in the example
        fill_circle(COLOR_RED, test_point.x, test_point.y, 6);
        fill_circle(COLOR_GREEN, distant_point.x, distant_point.y, 8);
        fill_circle(COLOR_BLUE, circle_center.x, circle_center.y, 5);

        // Display labels on the window for beginner-friendly guidance
        draw_text("Move the mouse to change the test point", COLOR_BLACK, 20, 20);
        draw_text("Red = test point", COLOR_RED, 20, 50);
        draw_text("Green = distant point on circle", COLOR_GREEN, 20, 80);
        draw_text("Blue = circle center", COLOR_BLUE, 20, 110);

        refresh_screen(60);
    }

    return 0;
}