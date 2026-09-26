#include "splashkit.h"

int main()
{
    open_window("Random Color Example", 800, 600);

    color box_color = COLOR_BLUE;

    while (!quit_requested())
    {
        process_events();

        if (mouse_clicked(LEFT_BUTTON))
        {
            box_color = random_color();
        }

        clear_screen(COLOR_WHITE);

        fill_rectangle(box_color, 250, 200, 300, 180);

        draw_text(
            "Click anywhere to change colour",
            COLOR_BLACK,
            220,
            420
        );

        refresh_screen();
    }

    return 0;
}