#include "splashkit.h"

int main()
{
    // first we'll open a window 
    window my_window = open_window("Usage Example", 900, 600);
    // loading a font (Arial)
    font arial_font = load_font("Arial", "C:/Users/jangh/Desktop/SplashKitTestCpp/splashkit.io-starlight/src/fonts/arial.ttf");\

    // creating a loop so that the window stays open
    while (!window_close_requested(my_window))
    {
        // just so that our window is responsive
        process_events();
        // clearing the screen
        clear_screen(COLOR_WHITE);
        // with the loaded font, we will be drawing the text to display 
        draw_text("Hello, This is Usage Example", COLOR_BLACK, arial_font, 32, 100, 100);

        // refreshing the screen
        refresh_screen(60);
    }
    // after the window is closed we will free all the fonts before completely exiting
    free_all_fonts();

    // closing the window 
    close_window(my_window);

    return 0;
}
