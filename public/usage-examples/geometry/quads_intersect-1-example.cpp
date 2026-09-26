#include "splashkit.h"

int main()
{
    open_window("Quads Intersect", 800, 600);

    quad fixed_quad = quad_from(
        500, 200,
        470, 380,
        300, 180,
        280, 350
    );

    while (!quit_requested())
    {
        process_events();

        point_2d mouse = mouse_position();

        quad moving_quad = quad_from(
            mouse.x + 60, mouse.y - 45,
            mouse.x + 60, mouse.y + 45,
            mouse.x - 60, mouse.y - 45,
            mouse.x - 60, mouse.y + 45
        );

        bool intersects = quads_intersect(fixed_quad, moving_quad);

        clear_screen(COLOR_WHITE);

        fill_quad(COLOR_LIGHT_GRAY, fixed_quad);
        draw_quad(COLOR_BLACK, fixed_quad);

        if (intersects)
        {
            fill_quad(COLOR_RED, moving_quad);
            draw_text(
                "Quads intersect: TRUE",
                COLOR_DARK_RED,
                20,
                20
            );
        }
        else
        {
            fill_quad(COLOR_BLUE, moving_quad);
            draw_text(
                "Quads intersect: FALSE",
                COLOR_BLACK,
                20,
                20
            );
        }

        draw_quad(COLOR_BLACK, moving_quad);

        draw_text(
            "Move the mouse to test quad intersection",
            COLOR_BLACK,
            20,
            550
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
