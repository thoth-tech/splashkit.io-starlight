#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Ray Intersection", 400, 400);

    // Define the ray
    point_2d ray_origin = {200, 200};
    vector_2d ray_vector = vector_from_angle(45, 150);
    line ray_line = line_from(ray_origin, ray_vector);

    // Define the walls
    point_2d red_start = {100, 300};
    point_2d red_end = {300, 300};
    line red_wall = line_from(red_start, red_end);

    point_2d black_start = {100, 100};
    point_2d black_end = {300, 100};
    line black_wall = line_from(black_start, black_end);

    // Visualize the scene
    clear_screen(COLOR_WHITE);
  
  	write_line("Drawing Blue Ray");
    draw_line(COLOR_BLUE, ray_line);
  
  	write_line("Drawing Red and Black Walls");
    draw_line(COLOR_RED, red_wall);
    draw_line(COLOR_BLACK, black_wall);

    // Check for ray-wall intersections and calculate intersection points
    point_2d collision_point_1, collision_point_2;

    if (ray_intersection_point(ray_origin, ray_vector, red_wall, collision_point_1))
    {
        write_line("Collision with red wall at: " + point_to_string(collision_point_1));
        fill_circle(COLOR_GREEN, circle_at(collision_point_1, 4));
    }
    else
    {
        write_line("No collision with red wall.");
    }

    if (ray_intersection_point(ray_origin, ray_vector, black_wall, collision_point_2))
    {
        write_line("Collision with black wall at: " + point_to_string(collision_point_2));
        fill_circle(COLOR_GREEN, circle_at(collision_point_2, 4));
    }
    else
    {
        write_line("No collision with black wall.");
    }

    // Refresh the screen and wait
    refresh_screen();
    delay(5000);

    // Close all windows
    close_all_windows();

    return 0;
}
