#include "splashkit.h"

int main()
{
    open_window("Mouse Height Gauge", 800, 600);

    while (!quit_requested())
    {
        process_events();

        // Read the height once so the line, the bar and the text always agree
        float pointer_height = mouse_y();

        clear_screen(COLOR_WHITE);

        // The bar grows from the bottom of the window up to the pointer
        fill_rectangle(COLOR_BLUE, 340, pointer_height, 120, 600 - pointer_height);
        draw_line(COLOR_RED, 0, pointer_height, 800, pointer_height);

        draw_text("Move the mouse up and down to change the gauge.", COLOR_BLACK, 20, 20);
        draw_text("Mouse Y: " + to_string(static_cast<int>(pointer_height)), COLOR_BLACK, 20, 60);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
