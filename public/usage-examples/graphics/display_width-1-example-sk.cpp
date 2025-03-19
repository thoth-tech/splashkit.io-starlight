#include "splashkit.h"

int main()
{
    // Get display width
    int width = display_width(display_details(0));

    // Open window with same width of display
    open_window("Display Width Exmaple", width, 100);
    clear_screen(COLOR_BLACK);

    // Write on window the display width
    draw_text("Display Width: " + std::to_string(width),COLOR_WHITE,width/2,50);
    refresh_screen();
    while(!quit_requested()) process_events();
    return 0;
}