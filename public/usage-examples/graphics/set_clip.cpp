#include "splashkit.h"

int main()
{
    open_window("House Drawing with Clipping", 800, 600);

    // Set a clipping region (only drawings inside this will appear)
    rectangle clip_rect = rectangle_from(250, 200, 300, 300);
    set_clip(clip_rect);

    // Optional: clear background inside the clipping region
    clear_screen(COLOR_DARK_ORANGE);

    // Draw the house body (only visible within clip_rect)
    fill_rectangle(COLOR_BEIGE, 300, 250, 200, 200);

    // Draw the roof
    draw_line(COLOR_BROWN, 300, 250, 400, 150);
    draw_line(COLOR_BROWN, 400, 150, 500, 250);
    draw_line(COLOR_BROWN, 300, 250, 500, 250);

    // Draw door
    fill_rectangle(COLOR_DARK_RED, 375, 370, 50, 80);

    // Draw windows
    fill_rectangle(COLOR_LIGHT_BLUE, 320, 270, 40, 40); // left window
    fill_rectangle(COLOR_LIGHT_BLUE, 440, 270, 40, 40); // right window

    // Draw the clipping border to show the area
    draw_rectangle(COLOR_BLACK, clip_rect);

    refresh_screen();
    delay(5000); // Show for 5 seconds

    return 0;
}
