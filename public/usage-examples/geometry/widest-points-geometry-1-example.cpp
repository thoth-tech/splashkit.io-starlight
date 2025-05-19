#include "splashkit.h"

int main()
{
    open_window("Widest points on a circle along a vector", 600, 600);

    // Create the circle at the center of the screen
    circle circle = circle_at(screen_center(), 100);

    // Declare variables
    point_2d mouse_position_point;
    vector_2d direction_vector;
    point_2d widest_point1, widest_point2;

    while (!quit_requested())
    {
        process_events();

        // Get the current mouse position (used as the direction for the vector)
        mouse_position_point = mouse_position();

        // Calculate the vector from the circle center to the mouse position
        direction_vector = vector_point_to_point(circle.center, mouse_position_point);

        // Calculate the two widest points on the circle along the vector
        widest_points(circle, direction_vector, widest_point1, widest_point2);

        // Draw everything
        clear_screen();
        draw_circle(color_black(), circle);
        fill_circle(color_blue(), mouse_position_point.x, mouse_position_point.y, 5);
        fill_circle(color_red(), widest_point1.x, widest_point1.y, 5);
        fill_circle(color_red(), widest_point2.x, widest_point2.y, 5);
        draw_line(color_green(), circle.center, mouse_position_point);
        draw_line(color_red(), circle.center, widest_point1);
        draw_line(color_red(), circle.center, widest_point2);

        // Display calculation details
        draw_text(
            "Mouse Position (Vector Direction): (" + 
            std::to_string((int)mouse_position_point.x) + ", " + std::to_string((int)mouse_position_point.y) + ")", 
            color_black(), "Arial", 16, 10, 10);

        draw_text(
            "Widest Point 1: (" +
            std::to_string((int)widest_point1.x) + ", " + std::to_string((int)widest_point1.y) + ")",
            color_black(), "Arial", 16, 10, 35);

        draw_text(
            "Widest Point 2: (" +
            std::to_string((int)widest_point2.x) + ", " + std::to_string((int)widest_point2.y) + ")",
            color_black(), "Arial", 16, 10, 60);

        refresh_screen();
    }

    close_all_windows();

    return 0;
}
