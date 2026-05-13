#include "splashkit.h"
#include <string>

int main()
{
    open_window("Start-Stop Stopwatch", 600, 300);

    // Create a named timer - it is not started until start_timer is called
    timer game_timer = create_timer("game_timer");

    while (!quit_requested())
    {
        process_events();

        // Start the timer when SPACE is pressed
        if (key_typed(SPACE_KEY))
            start_timer(game_timer);

        // Stop the timer when S is pressed
        if (key_typed(S_KEY))
            stop_timer(game_timer);

        clear_screen(COLOR_WHITE);

        // Use timer_started to check whether the timer is currently running
        bool is_running = timer_started(game_timer);

        // Display the timer status
        if (is_running)
        {
            draw_text("Status: Running", COLOR_GREEN, "Arial", 28, 170, 80);
        }
        else
        {
            draw_text("Status: Stopped", COLOR_RED, "Arial", 28, 170, 80);
        }

        // Display elapsed milliseconds - std::to_string converts a number to a string
        draw_text("Elapsed: " + std::to_string(timer_ticks(game_timer)) + " ms",
                  COLOR_BLACK, "Arial", 20, 185, 140);

        draw_text("[SPACE] Start   [S] Stop", COLOR_GRAY, "Arial", 16, 165, 220);

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
