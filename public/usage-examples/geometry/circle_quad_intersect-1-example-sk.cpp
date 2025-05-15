#include "splashkit.h"

int main()
{
    // Open a graphical window with a fixed title and size
    open_window("Circle Quad Intersect Example", 800, 600);

    // Define the four corners of the quad using descriptive snake_case variable names
    point_2d top_left = point_at(300, 200);
    point_2d top_right = point_at(500, 200);
    point_2d bottom_right = point_at(500, 400);
    point_2d bottom_left = point_at(300, 400);

    // Define a fixed radius for the mouse-following circle
    float radius = 30;

    // Main application loop — continues until the user closes the window
    while (!window_close_requested("Circle Quad Intersect Example"))
    {
        // Handle user input and OS events
        process_events();

        // Clear the screen with a dark slate gray background color
        clear_screen(COLOR_DARK_SLATE_GRAY);

        // Get the current position of the mouse
        point_2d mouse_pos = mouse_position();

        // Create a circle centered at the mouse position
        circle mouse_circle = circle_at(mouse_pos.x, mouse_pos.y, radius);

        // Construct a quad from the four points defined earlier
        quad fixed_quad = quad_from(top_left, top_right, bottom_right, bottom_left);

        // Check if the circle intersects the quad
        bool is_intersecting = circle_quad_intersect(mouse_circle, fixed_quad);

        // Choose fill color based on intersection state
        color quad_color = is_intersecting ? COLOR_RED : COLOR_GREEN;

        // Draw the quad using two filled triangles (ensures rendering works properly)
        fill_triangle(quad_color,
            top_left.x, top_left.y,
            top_right.x, top_right.y,
            bottom_right.x, bottom_right.y);

        fill_triangle(quad_color,
            top_left.x, top_left.y,
            bottom_left.x, bottom_left.y,
            bottom_right.x, bottom_right.y);

        // Draw the circle in white so it's clearly visible
        draw_circle(COLOR_WHITE, mouse_circle);

        // Refresh the screen at 60 frames per second
        refresh_screen(60);
    }

    return 0;
}