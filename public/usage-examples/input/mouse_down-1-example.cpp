#include "splashkit.h"

int main()
{
    open_window("Mouse Drag Example", 800, 600);

    double circle_x = 400;
    double circle_y = 300;
    const double circle_radius = 50;

    bool dragging = false;
    bool was_mouse_down = false;

    double offset_x = 0;
    double offset_y = 0;

    while (!quit_requested())
    {
        process_events();

        point_2d mouse = mouse_position();
        bool left_mouse_down = mouse_down(LEFT_BUTTON);

        // Start dragging when the mouse is first pressed inside the circle
        if (
            !dragging &&
            left_mouse_down &&
            !was_mouse_down &&
            point_in_circle(
                mouse.x,
                mouse.y,
                circle_x,
                circle_y,
                circle_radius
            )
        )
        {
            dragging = true;

            // Keep the circle from jumping to the centre of the mouse
            offset_x = circle_x - mouse.x;
            offset_y = circle_y - mouse.y;
        }

        // Move the circle while the mouse button is held down
        if (dragging && left_mouse_down)
        {
            circle_x = mouse.x + offset_x;
            circle_y = mouse.y + offset_y;
        }

        // Stop dragging when the mouse button is released
        if (!left_mouse_down)
        {
            dragging = false;
        }

        was_mouse_down = left_mouse_down;

        clear_screen(color_white());

        if (dragging)
        {
            fill_circle(
                color_red(),
                circle_x,
                circle_y,
                circle_radius
            );
        }
        else
        {
            fill_circle(
                color_blue(),
                circle_x,
                circle_y,
                circle_radius
            );
        }

        draw_text(
            "Click and drag the circle",
            color_black(),
            20,
            20
        );

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}