#include "splashkit.h"
#include <string>

using namespace std;

int main()
{
    open_window("Press S to Stop Timer", 700, 220);

    create_timer("demo");
    start_timer("demo");

    while (!quit_requested())
    {
        process_events();

        if (key_typed(S_KEY) && timer_started("demo"))
        {
            stop_timer("demo");
        }

        string status = timer_started("demo") ? "Running" : "Stopped";
        unsigned int ticks = timer_ticks("demo");

        clear_screen(COLOR_WHITE);

        draw_text("Press S to stop the timer", COLOR_BLACK, 20, 20);
        draw_text("Status: " + status, COLOR_BLUE, 20, 70);
        draw_text("Ticks: " + to_string((int)ticks), COLOR_RED, 20, 110);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}