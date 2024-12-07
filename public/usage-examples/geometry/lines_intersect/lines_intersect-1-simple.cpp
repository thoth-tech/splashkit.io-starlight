#include "splashkit.h"

int main()
{
    open_window("Lines Intersect", 800, 600);

    // Define points for the lines
    point_2d start_point_1 = {100, 150};
    point_2d end_point_1 = {500, 550};

    point_2d start_point_2 = {100, 550};
    point_2d end_point_2 = {500, 150};

    point_2d start_point_3 = {550, 150};
    point_2d end_point_3 = {550, 500};

    // Draw the lines
    line demo_line_1 = line_from(start_point_1, end_point_1);
    draw_line(COLOR_RED, demo_line_1);
    draw_text("A", COLOR_BLACK, start_point_1.x - 20, start_point_1.y - 10);

    line demo_line_2 = line_from(start_point_2, end_point_2);
    draw_line(COLOR_BLUE, demo_line_2);
    draw_text("B", COLOR_BLACK, start_point_2.x - 20, start_point_2.y - 10);

    line demo_line_3 = line_from(start_point_3, end_point_3);
    draw_line(COLOR_GREEN, demo_line_3);
    draw_text("C", COLOR_BLACK, start_point_3.x - 20, start_point_3.y - 10);

    // Check intersections
    bool intersect_1_2 = lines_intersect(demo_line_1, demo_line_2);
    bool intersect_1_3 = lines_intersect(demo_line_1, demo_line_3);

    // Display intersection results
    draw_text("A and B intersect: " + std::string(intersect_1_2 ? "Yes" : "No"), COLOR_BLACK, 150, 130);
    draw_text("A and C intersect: " + std::string(intersect_1_3 ? "Yes" : "No"), COLOR_BLACK, 150, 150);

    refresh_screen();
    delay(5000);

    close_all_windows();
    return 0;
}
