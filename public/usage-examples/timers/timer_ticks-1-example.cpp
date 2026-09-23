#include "splashkit.h"

int main()
{
    open_window("timer_ticks Example", 800, 600);

    create_timer("demo timer");
    start_timer("demo timer");

    while (!window_close_requested("timer_ticks Example"))
    {
        process_events();
        clear_screen(COLOR_WHITE);

        int elapsed = timer_ticks("demo timer");

        draw_text("timer_ticks Example", COLOR_BLACK, 20, 20);
        draw_text("Elapsed time (ms): " + std::to_string(elapsed), COLOR_BLUE, 20, 70);
        draw_text("This value increases while the timer is running.", COLOR_DARK_GREEN, 20, 120);

        refresh_screen(60);

        if (elapsed > 5000)
        {
            break;
        }
    }

    return 0;
}