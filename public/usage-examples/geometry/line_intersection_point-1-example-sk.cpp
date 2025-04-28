#include "splashkit.h"

int main()
{
    open_window("Line Intersection Point", 800, 600);

    line line1;
    line line2;
    float line1_rotation_degrees = 0;
    bool boolean;
    point_2d line1_rotation_coordinates;
    point_2d line_intersection_coordinates;

    while (!quit_requested())
    {
        process_events();

        line1_rotation_degrees = line1_rotation_degrees + 0.01;
        line1_rotation_coordinates = point_at((250 + 100 * cosine(line1_rotation_degrees)), (250 + 100 * sine(line1_rotation_degrees)));
        
        line1 = line_from(point_at(250, 250), line1_rotation_coordinates);
        line2 = line_from(point_at(400, 0), point_at(800, 400));

        // The boolean variable that this function returns to isn't relevant
        // The 'line_intersection_coordinates' variable as noted here holds the Point2D data of where the two lines would intersect instead
        boolean = line_intersection_point(line1, line2, line_intersection_coordinates);

        clear_screen();
        draw_line(color_black(), line1);
        draw_line(color_black(), line2);
        fill_circle(color_red(), circle_at(line_intersection_coordinates, 5));
        draw_text("Position of intersection between the two lines would be at: " + point_to_string(line_intersection_coordinates), color_black(), 60, 500);
        
        refresh_screen();
    }
    close_all_windows();
    return 0;
}