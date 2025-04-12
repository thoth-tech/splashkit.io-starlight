#include "splashkit.h"

int main()
{
    window window = open_window("Point In Quad", 800, 600);

    point_2d cursor_pos;
    color quad_clr;
    string text;
    quad quad = quad_from(point_at(250, 180), point_at(500, 210), point_at(300, 380), point_at(480, 480));

    while (!quit_requested())
    {
        process_events();
        cursor_pos = mouse_position();

        // The text and quad colour is updated depending on whether cursor is inside the quad
        if (point_in_quad(cursor_pos, quad))
        {
            quad_clr = color_green();
            text = "Cursor in the quad!";
        }
        else
        {
            quad_clr = color_red();
            text = "Cursor not in the quad!";
        }

        clear_screen();
        draw_quad(quad_clr, quad);
        draw_text(text, quad_clr, 300, 100);
        refresh_screen();
    }
    close_window(window);
    return 0;
}