#include "splashkit.h"
#include <string>

int main()
{
    open_window("Simple Timer Display", 800, 600);

    timer example_timer = create_timer("Example Timer");
    start_timer(example_timer);

    while (!quit_requested())
    {
        process_events();

        double elapsed_seconds = timer_ticks(example_timer) / 1000.0;

        clear_screen(COLOR_WHITE);

        draw_text("Timer created and running", COLOR_BLACK, 20, 20);
        draw_text(
            "Elapsed time: " + std::to_string(elapsed_seconds) + " seconds",
            COLOR_BLACK,
            20,
            60
        );
        draw_text("Close the window to finish.", COLOR_BLACK, 20, 100);

        refresh_screen(60);
    }

    free_timer(example_timer);

    return 0;
}