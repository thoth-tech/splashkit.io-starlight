#include "splashkit.h"

int main()
{
    open_window("Mouse Wheel Scroll", 800, 600);

    int x_scroll_counter = 0;
    int y_scroll_counter = 0;
    font font = font_named("Century.ttf");

    while (!quit_requested())
    {
        x_scroll_counter += mouse_wheel_scroll().x;
        y_scroll_counter += mouse_wheel_scroll().y;

        process_events();

        clear_screen(color_white());
        draw_text(std::to_string(x_scroll_counter) + ", " + std::to_string(y_scroll_counter), color_black(), font, 200, 400 - (text_width(std::to_string(x_scroll_counter) + ", " + std::to_string(y_scroll_counter), font, 200) / 2), 90);
        draw_text("Reading is affected by moving the scroll wheel", color_black(), font, 15, 248, 400);
        refresh_screen();
    }
    close_all_windows();
    return 0;
}