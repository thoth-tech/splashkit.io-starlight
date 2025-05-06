#include "splashkit.h"

int main()
{
    open_window("Line Width Example", 800, 600);

    drawing_options opt = option_line_width(10);
    draw_line(COLOR_BLACK, 100, 100, 200, 200, opt);

    
    opt = option_line_width(5);
    draw_line(COLOR_RED, 400, 100, 600, 250, opt);
    refresh_screen();

    while (!quit_requested())
    {
        process_events();
    }

    return 0;
}
