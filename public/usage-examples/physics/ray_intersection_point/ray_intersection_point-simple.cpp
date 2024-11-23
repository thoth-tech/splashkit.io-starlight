#include "splashkit.h"

int main()
{
    // Open the window
    open_window("Ray Intersection", 300, 300);

    // Define the ray
    point_2d ray_origin = {150, 150};
    vector_2d ray_vector = vector_from_angle(45, 100);
    line ray_line = line_from(ray_origin, ray_vector);

    // Define the walls
    point_2d red_start = {150, 200};
    point_2d red_end = {300, 200};
    line red_wall = line_from(red_start, red_end);

    point_2d black_start = {150, 50};
    point_2d black_end = {200, 50};
    line black_wall = line_from(black_start, black_end);

    // Define collision points
    point_2d collision_point_1 = {250, 250};
    point_2d collision_point_2 = {250, 125};

    // Visualize the scene
    clear_screen(COLOR_WHITE);
    fill_circle(COLOR_BROWN, circle_at(collision_point_1, 2));
    fill_circle(COLOR_BROWN, circle_at(collision_point_2, 2));
    draw_line(COLOR_BLUE, ray_line);
    draw_line(COLOR_RED, red_wall);
    draw_line(COLOR_BLACK, black_wall);

    // Check for ray-wall intersections
    if (ray_intersection_point(ray_origin, ray_vector, red_wall, collision_point_1))
        write_line("Collision with red wall!");
    if (ray_intersection_point(ray_origin, ray_vector, black_wall, collision_point_2))
        write_line("Collision with black wall!");

    refresh_screen();
    delay(4000);
    close_all_windows();

    return 0;
}
