#include "splashkit.h"

int main()
{
    // Open a window
    window my_window = open_window("Free All Fonts Example", 900, 600);

    //  Load the fonts from the resource bundle located in Resources/bundles/Font.txt
    load_resource_bundle("FontBundle", "Font.txt");

    // Display text using Font A and Font B (from the bundle)
    clear_screen(COLOR_WHITE);
    draw_text("This is Font A (Montserrat Black)", COLOR_BLACK, "FontA", 32, 100, 100);
    draw_text("This is Font B (Montserrat Thin)", COLOR_BLACK, "FontB", 32, 100, 150);
    refresh_screen();
    delay(2000); // Show fonts A and B for 2 seconds

    //  Free all loaded fonts
    free_all_fonts();

    //  Reload Font C manually by filename from Resources/fonts
    load_font("FontC", "OpenSans_Condensed-Bold.ttf");

    // Show that Font A and B are no longer available, and Font C is used now
    clear_screen(COLOR_WHITE);
    draw_text("Fonts A and B were freed.", COLOR_RED, "FontC", 32, 100, 250);
    draw_text("Now using Font C (OpenSans Condensed Bold)", COLOR_RED, "FontC", 32, 100, 300);
    refresh_screen();
    delay(2000); // Show Font C for 2 seconds

    // Close the window
    close_window(my_window);
    return 0;
}
