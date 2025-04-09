#include "splashkit.h"

int main()
{
    open_window("Line Width Example", 800, 600);

    // Set line width to 10
    drawing_options opt1 = option_line_width(10);
    draw_line(COLOR_BLACK, 100, 100, 200, 200, opt1);  // Use draw_line instead of draw_rectangle

    // Set line width to 5
    drawing_options opt2 = option_line_width(5);
    draw_line(COLOR_RED, 400, 100, 600, 250, opt2);  // Use draw_line instead of draw_rectangle

    refresh_screen();

    // Keep the window open until the user closes it
    while (!quit_requested())
    {
        process_events();
    }

    return 0;
}
