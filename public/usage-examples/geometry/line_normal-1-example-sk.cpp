#include "splashkit.h"

int main()
{
    open_window("Interactive Line on Graph", 800, 600);

    line user_line;
    line x_axis_line;
    line y_axis_line;
    point_2d cursor_pos;
    vector_2d vector;

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();
        user_line = line_from(point_at(400, 350), cursor_pos);

        x_axis_line = line_from(point_at(cursor_pos.x, 350), point_at(400, 350));
        y_axis_line = line_from(point_at(400, cursor_pos.y), point_at(400, 350));

        // The line normal of the desired line is stored under the vector 2d variable
        vector = line_normal(user_line);

        clear_screen();
        draw_line(color_black(), user_line);
        draw_line(color_red(), x_axis_line);
        draw_line(color_red(), y_axis_line);
        draw_text("The black line's normal is: " + std::to_string(vector.x) + "," + std::to_string(vector.y), color_black(), 60, 500);

        refresh_screen();
    }
    close_all_windows();
    return 0;
}