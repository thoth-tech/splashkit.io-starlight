#include "splashkit.h"

int main()
{
    // Open a new window
    window my_window = open_window("My SplashKit Window", 800, 600);

    // Get the window caption
    string caption = window_caption(my_window);

    // Keep the program running until the user closes the window
    while (!quit_requested())
    {
        process_events();

        // Draw content on the screen
        clear_screen(color_white());

        draw_text("Window caption:", color_black(), 260, 250);
        draw_text(caption, color_blue(), 260, 290);

        refresh_screen(60);
    }

    // Close all open windows
    close_all_windows();

    return 0;
}