#include "splashkit.h"

int main()
{
    // open a window
    window window_handle = open_window("Close Window Example", 400, 200);

    bool countdown_started = false;
    int countdown = 5;
    timer countdown_timer = create_timer("countdown");

    while (!quit_requested())
    {
        // get user events
        process_events();

        // clear screen
        clear_screen(COLOR_WHITE);

        if (!countdown_started)
        {
            // Show the button before countdown starts
            if (button("Click Me!", rectangle_from(150, 85, 100, 30)))
            {
                countdown_started = true;
                start_timer(countdown_timer);
            }
        }
        else
        {
            // Display countdown
            draw_text("This window will close in " + std::to_string(countdown), COLOR_BLACK, "arial", 18, 50, 85);

            // Check if 1 second has passed
            if (timer_ticks(countdown_timer) > 1000)
            {
                countdown--;
                reset_timer(countdown_timer);

                if (countdown <= 0)
                {
                    close_window(window_handle);
                    break;
                }
            }
        }

        draw_interface();
        refresh_screen();
    }

    // close all open windows
    close_all_windows();
    return 0;
}