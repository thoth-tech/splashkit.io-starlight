#include "splashkit.h"

int main()
{
    open_window("Mouse Button Lamp", 800, 600);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Hold the left mouse button to turn the lamp red.", COLOR_BLACK, 20, 20);

        // The lamp stays green while the button is released and turns red for as long as it is held
        if (mouse_up(LEFT_BUTTON))
        {
            fill_circle(COLOR_GREEN, 400, 330, 110);
            draw_text("Left button: up", COLOR_BLACK, 20, 60);
        }
        else
        {
            fill_circle(COLOR_RED, 400, 330, 110);
            draw_text("Left button: down", COLOR_BLACK, 20, 60);
        }

        draw_circle(COLOR_BLACK, 400, 330, 110);

        refresh_screen(60);
    }

    close_all_windows();

    return 0;
}
