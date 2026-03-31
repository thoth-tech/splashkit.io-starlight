#include "splashkit.h"
#include <cmath>

int main()
{
    // Window dimensions
    const int WINDOW_WIDTH = 800;
    const int WINDOW_HEIGHT = 600;

    // Open a window for the lantern scene
    open_window("The Raycast Lantern", WINDOW_WIDTH, WINDOW_HEIGHT);

    // Define obstacle rectangles (walls that block light)
    rectangle obstacle1 = rectangle_from(150, 150, 100, 200);
    rectangle obstacle2 = rectangle_from(500, 100, 150, 120);
    rectangle obstacle3 = rectangle_from(350, 350, 200, 80);

    // Define edges of each obstacle as lines for ray intersection
    // Obstacle 1 edges
    line obs1_top = line_from(150, 150, 250, 150);
    line obs1_bottom = line_from(150, 350, 250, 350);
    line obs1_left = line_from(150, 150, 150, 350);
    line obs1_right = line_from(250, 150, 250, 350);

    // Obstacle 2 edges
    line obs2_top = line_from(500, 100, 650, 100);
    line obs2_bottom = line_from(500, 220, 650, 220);
    line obs2_left = line_from(500, 100, 500, 220);
    line obs2_right = line_from(650, 100, 650, 220);

    // Obstacle 3 edges
    line obs3_top = line_from(350, 350, 550, 350);
    line obs3_bottom = line_from(350, 430, 550, 430);
    line obs3_left = line_from(350, 350, 350, 430);
    line obs3_right = line_from(550, 350, 550, 430);

    // Collect all edges into an array for easy iteration
    const int NUM_EDGES = 12;
    line edges[NUM_EDGES] = {
        obs1_top, obs1_bottom, obs1_left, obs1_right,
        obs2_top, obs2_bottom, obs2_left, obs2_right,
        obs3_top, obs3_bottom, obs3_left, obs3_right
    };

    // Number of rays to cast around the lantern
    const int NUM_RAYS = 360;

    while (!quit_requested())
    {
        process_events();

        // Lantern follows the mouse position
        point_2d lantern_pos = mouse_position();

        // Store the endpoint of each ray (intersection or window edge)
        point_2d ray_endpoints[NUM_RAYS];

        // Cast rays in all directions from the lantern
        for (int i = 0; i < NUM_RAYS; i++)
        {
            double angle = i * (360.0 / NUM_RAYS);

            // Create a direction vector for this ray
            vector_2d heading = vector_from_angle(angle, 1.0);

            // Max ray distance based on window diagonal for scalability
            double closest_dist = sqrt(WINDOW_WIDTH * WINDOW_WIDTH + WINDOW_HEIGHT * WINDOW_HEIGHT);
            point_2d closest_pt = point_at(
                lantern_pos.x + heading.x * closest_dist,
                lantern_pos.y + heading.y * closest_dist
            );

            // Check each obstacle edge for intersection
            for (int j = 0; j < NUM_EDGES; j++)
            {
                point_2d hit_pt = point_at(0, 0);

                // Use ray_intersection_point to detect where the ray hits an edge
                if (ray_intersection_point(lantern_pos, heading, edges[j], hit_pt))
                {
                    // Calculate distance to this intersection
                    double dist = point_point_distance(lantern_pos, hit_pt);

                    // Keep the closest intersection point
                    if (dist < closest_dist)
                    {
                        closest_dist = dist;
                        closest_pt = hit_pt;
                    }
                }
            }

            ray_endpoints[i] = closest_pt;
        }

        // Render the scene
        clear_screen(color_black());

        // Draw the illuminated area using filled triangles
        // Each triangle connects the lantern to two adjacent ray endpoints
        for (int i = 0; i < NUM_RAYS; i++)
        {
            int next = (i + 1) % NUM_RAYS;

            // Fill triangle to create the lit region
            fill_triangle(
                rgba_color(255, 220, 100, 40),
                lantern_pos.x, lantern_pos.y,
                ray_endpoints[i].x, ray_endpoints[i].y,
                ray_endpoints[next].x, ray_endpoints[next].y
            );

            // Draw triangle outline for subtle light boundary
            draw_triangle(
                rgba_color(255, 220, 100, 15),
                lantern_pos.x, lantern_pos.y,
                ray_endpoints[i].x, ray_endpoints[i].y,
                ray_endpoints[next].x, ray_endpoints[next].y
            );
        }

        // Draw light rays from lantern to intersection points
        for (int i = 0; i < NUM_RAYS; i += 6)
        {
            draw_line(rgba_color(255, 200, 50, 20), lantern_pos, ray_endpoints[i]);
        }

        // Draw the obstacle outlines on top
        draw_rectangle(color_dark_gray(), obstacle1);
        draw_rectangle(color_dark_gray(), obstacle2);
        draw_rectangle(color_dark_gray(), obstacle3);

        // Fill obstacles to make them look solid
        fill_rectangle(color_gray(), obstacle1);
        fill_rectangle(color_gray(), obstacle2);
        fill_rectangle(color_gray(), obstacle3);

        // Draw the lantern glow at the mouse position
        fill_circle(color_yellow(), lantern_pos.x, lantern_pos.y, 8);
        fill_circle(rgba_color(255, 200, 50, 100), lantern_pos.x, lantern_pos.y, 20);

        // Display instructions
        draw_text("Move the mouse to reposition the lantern", color_white(), 10, 10);
        draw_text("Rays: " + std::to_string(NUM_RAYS) + " | Obstacles: 3", color_white(), 10, 30);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
