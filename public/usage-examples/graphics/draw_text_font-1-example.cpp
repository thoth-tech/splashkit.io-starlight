#include "splashkit.h"

int main()
{
    open_window("Font Example", 800, 600);
    load_font("myFont", "arial.ttf");

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Hello with Font!", COLOR_BLACK, "myFont", 20, 200, 250);

        refresh_screen();
    }

    return 0;
}