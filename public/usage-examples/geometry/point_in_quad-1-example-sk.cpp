#include "splashkit.h"

int main()
{
    open_window("Point In Quad", 800, 600);

    color quad_color;
    string text;
    quad quad = quad_from(point_at(250, 180), point_at(500, 210), point_at(300, 380), point_at(480, 480));

    while (!quit_requested())
    {
        process_events();
        point_2d cursor_pos = mouse_position();

        // The text and quad colour is updated depending on whether cursor is inside the quad
        if (point_in_quad(cursor_pos, quad))
        {
            quad_color = color_green();
            text = "Cursor in the quad!";
        }
        else
        {
            quad_color = color_red();
            text = "Cursor not in the quad!";
        }

        clear_screen(color_white());
        draw_quad(quad_color, quad);
        draw_text(text, quad_color, 300, 100);
        refresh_screen();
    }
    close_all_windows();
    return 0;
}