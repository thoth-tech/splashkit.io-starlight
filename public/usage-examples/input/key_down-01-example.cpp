#include "splashkit.h"

int main()
{
    open_window("Key Down Example", 800, 600);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        if (key_down(SPACE_KEY))
        {
            draw_text("Space key is pressed", COLOR_BLACK, 200, 300);
        }
        else
        {
            draw_text("Press the space key", COLOR_BLACK, 200, 300);
        }

        refresh_screen();
    }

    return 0;
}
