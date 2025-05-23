#include "splashkit.h"
#include <cmath>
#include <vector>

using namespace std;

int main()
{
    // Declare a variable with snake_case (demonstrating naming convention)
    string snap_point_to_nearest_line = "This is snake case";

    // Open a window for drawing
    open_window("Snap Point to Nearest Line", 600, 600);

    // Define two lines using start and end points
    point_2d start1 = point_at(100, 100);
    point_2d end1 = point_at(500, 100);
    point_2d start2 = point_at(100, 300);
    point_2d end2 = point_at(500, 500);

    // Store lines as pairs in a vector
    vector<pair<point_2d, point_2d>> all_lines = { {start1, end1}, {start2, end2} };

    // Load a font for drawing text
    font my_font = load_font("default_font", "Arial.ttf");

    // Main loop: runs until user closes the window
    while (!quit_requested())
    {
        process_events();              // Handle input events
        clear_screen(COLOR_WHITE);    // Clear the screen with white background

        // Get current mouse position
        point_2d current_point = mouse_position();

        // Initialize variables to track the closest point and line
        float min_distance = numeric_limits<float>::infinity();
        point_2d nearest_snap_point;
        int nearest_line_index = -1;

        // Loop through each line to find the nearest point to the mouse
        for (int i = 0; i < all_lines.size(); i++)
        {
            point_2d start = all_lines[i].first;
            point_2d end = all_lines[i].second;

            // Calculate vectors AP and AB
            float ap_x = current_point.x - start.x;
            float ap_y = current_point.y - start.y;
            float ab_x = end.x - start.x;
            float ab_y = end.y - start.y;

            // Compute dot product and clamp projection t to [0, 1]
            float ab_len_sq = ab_x * ab_x + ab_y * ab_y;
            float dot = ap_x * ab_x + ap_y * ab_y;
            float t = max(0.0f, min(1.0f, dot / ab_len_sq));

            // Calculate the closest point coordinates
            float closest_x = start.x + ab_x * t;
            float closest_y = start.y + ab_y * t;
            point_2d candidate_point = point_at(closest_x, closest_y);

            // Calculate Euclidean distance from mouse to this point
            float distance = sqrt(
                pow(candidate_point.x - current_point.x, 2) +
                pow(candidate_point.y - current_point.y, 2)
            );

            // Update if this is the closest point found so far
            if (distance < min_distance)
            {
                min_distance = distance;
                nearest_snap_point = candidate_point;
                nearest_line_index = i;
            }
        }

        // Draw all lines in gray
        for (auto &line : all_lines)
        {
            draw_line(COLOR_GRAY, line.first.x, line.first.y, line.second.x, line.second.y);
        }

        // Draw mouse point as a black circle
        fill_circle(COLOR_BLACK, current_point.x, current_point.y, 5);

        // Draw nearest point on line as a green circle
        fill_circle(COLOR_GREEN, nearest_snap_point.x, nearest_snap_point.y, 5);

        // Draw red line connecting the two points
        draw_line(COLOR_RED, current_point.x, current_point.y, nearest_snap_point.x, nearest_snap_point.y);

        // Display labels near the points and top of the screen
        draw_text("Black: From Point", COLOR_BLACK, my_font, 12, current_point.x + 10, current_point.y);
        draw_text("Green: Closest Point", COLOR_GREEN, my_font, 12, nearest_snap_point.x + 10, nearest_snap_point.y);
        draw_text("Closest line index: " + to_string(nearest_line_index), COLOR_BLUE, my_font, 14, 20, 20);

        // Render the frame
        refresh_screen();
    }

    // Close the window when done
    close_window("Snap Point to Nearest Line");
    return 0;
}
