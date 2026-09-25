#include "splashkit.h"
#include <string>

int main()
{
    window display_window = open_window("Current Window Example", 800, 600);

    while (!quit_requested())
    {
        process_events();

        display_window = current_window();

        int width = window_width(display_window);
        int height = window_height(display_window);
        string caption = window_caption(display_window);
        string current_status = is_current_window(display_window) ? "true" : "false";

        clear_window(display_window, COLOR_WHITE);

        draw_text("Using current_window()", COLOR_BLACK, 20, 20);
        draw_text("Caption: " + caption, COLOR_BLACK, 20, 60);
        draw_text("Window Width: " + std::to_string(width), COLOR_BLACK, 20, 100);
        draw_text("Window Height: " + std::to_string(height), COLOR_BLACK, 20, 140);
        draw_text("Is Current Window: " + current_status, COLOR_BLACK, 20, 180);

        fill_rectangle(COLOR_BLUE, 20, 230, width - 40, 80);
        draw_text("This rectangle is drawn in the current window.", COLOR_WHITE, 40, 260);

        refresh_window(display_window, 60);
    }

    close_window(display_window);

    return 0;
}