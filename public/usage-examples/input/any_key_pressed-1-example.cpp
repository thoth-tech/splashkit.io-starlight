#include "splashkit.h"

int main()
{
    open_window("Any Key Pressed", 800, 600);

    std::string message = "No key is being pressed.";
    color circle_color = COLOR_RED;

    while (!quit_requested())
    {
        process_events();

        if (any_key_pressed())
        {
            message = "A key is being pressed.";
            circle_color = COLOR_GREEN;
        }
        else
        {
            message = "No key is being pressed.";
            circle_color = COLOR_RED;
        }

        clear_screen(COLOR_WHITE);

        fill_circle(circle_color, 400, 250, 80);
        draw_text(message, COLOR_BLACK, 240, 400);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}