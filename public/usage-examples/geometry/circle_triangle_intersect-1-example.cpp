#include "splashkit.h"

int main()
{
    open_window("Intruder Alert!!", 800, 600);

    // Declaring variables
    point_2d p1 = point_at(400, 200);
    point_2d p2 = point_at(300, 400);
    point_2d p3 = point_at(500, 400);
    triangle house = triangle_from(p1, p2, p3);
    point_2d cursor_position;
    circle intruder;
    color flash = color_red();

    while (!quit_requested())
    {
        process_events();

        // Get mouse position
        cursor_position = mouse_position();
        intruder = circle_at(cursor_position, 20);

        if (circle_triangle_intersect(intruder, house))
        {
            clear_screen(flash);
            draw_text("House Breached!!", color_black(), 350, 100);

            // Toggle flash color
            if (flash == color_red())
            {
                flash = color_blue();
            }
            else
            {
                flash = color_red();
            }
            delay(500);
        }
        else
        {
            clear_screen(color_white());
        }

        draw_triangle(color_black(), house);
        fill_circle(color_black(), intruder);
        refresh_screen();
    }

    close_all_windows();
    return 0;
}