#include "splashkit.h"

int main()
{
    // Open new windows
    window whiteWindow = open_window("Ellipse Painter on White", 500, 500);
    window blueWindow = open_window("Ellipse Painter on Blue", 500, 500);

    // Set windows' postions
    move_window_to(whiteWindow, 100, 100);
    move_window_to(blueWindow, 620, 100);

    // Clear windows to white and blue
    clear_window(whiteWindow, color_white());
    clear_window(blueWindow, color_aqua());

    // While user doesn't request to quit windows
    while (!window_close_requested(whiteWindow) && !window_close_requested(blueWindow))
    {
        process_events();
        draw_text_on_window(whiteWindow, "Press L to paint. Press on the C key to clear screen", color_black(), 5, 10);
        draw_text_on_window(blueWindow, "Press P to paint. Press on the D key to clear screen", color_black(), 5, 10);

        // Get random points on the windows
        point_2d whitePos = random_window_point(whiteWindow);
        point_2d bluePos = random_window_point(blueWindow);

        // If L key is pressed draw ellipse on whiteWindow in random point
        if (key_typed(L_KEY))
        {
            fill_ellipse_on_window(whiteWindow, random_color(), whitePos.x, whitePos.y, 100, 50);
        }

        // If P key is pressed draw ellipse on blueWindow in random point
        if (key_typed(P_KEY))
        {
            fill_ellipse_on_window(blueWindow, random_color(), bluePos.x, bluePos.y, 100, 50);
        }

        // Clear whiteWindow if C key is pressed 
        if (key_typed(C_KEY))
        {
            clear_window(whiteWindow, color_white());
        }

         // Clear blueWindow if D key is pressed 
        if (key_typed(D_KEY))
        {
            clear_window(blueWindow, color_aqua());
        }

        refresh_window(whiteWindow, 60);
        refresh_window(blueWindow, 60);
    }

    // Close all windows
    close_all_windows();
    return 0;
}