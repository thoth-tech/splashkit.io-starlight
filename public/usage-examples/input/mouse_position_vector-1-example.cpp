#include "splashkit.h"

int main()
{
    open_window("Mouse Position Arrow", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // The vector runs from the window origin (the top-left corner) to the mouse
        vector_2d mouse_vector = mouse_position_vector();

        clear_screen(COLOR_WHITE);

        draw_line(COLOR_BLUE, 0, 0, mouse_vector.x, mouse_vector.y);

        // Two short lines swept back from the tip make the arrowhead
        double arrow_angle = vector_angle(mouse_vector);
        vector_2d head_left = vector_from_angle(arrow_angle + 150, 25);
        vector_2d head_right = vector_from_angle(arrow_angle - 150, 25);
        draw_line(COLOR_BLUE, mouse_vector.x, mouse_vector.y, mouse_vector.x + head_left.x, mouse_vector.y + head_left.y);
        draw_line(COLOR_BLUE, mouse_vector.x, mouse_vector.y, mouse_vector.x + head_right.x, mouse_vector.y + head_right.y);

        draw_text("Move the mouse to aim the arrow from the corner.", COLOR_BLACK, 20, 510);
        draw_text("Vector X: " + to_string(static_cast<int>(mouse_vector.x)), COLOR_BLACK, 20, 540);
        draw_text("Vector Y: " + to_string(static_cast<int>(mouse_vector.y)), COLOR_BLACK, 20, 570);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
