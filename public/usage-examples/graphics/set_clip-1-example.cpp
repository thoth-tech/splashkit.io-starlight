#include "splashkit.h"

int main()
{
    open_window("Set Clip Example", 600, 600);

    // Define a rectangle as the clip area
    rectangle clip_rect = rectangle_from(100, 100, 400, 200);

    // Set the clip rectangle for the current window
    set_clip(clip_rect);

    // Draw a background so we can see the clip area
    clear_screen(color_white());

    // Draw the outline of the clip area for visualization
    draw_rectangle(color_black(), clip_rect);

    // Only the part of the red rectangle inside the clip will be visible
    fill_rectangle(color_red(), 50, 50, 500, 300);

    // Draw a circle; only the part inside the clip area will be visible
    fill_circle(color_blue(), 300, 200, 150);

    // Display everything
    refresh_screen();
    delay(3000);

    // Remove the clipping (restore drawing to full window)
    pop_clip();

    // Draw more shapes, now visible everywhere
    fill_rectangle(color_green(), 0, 500, 600, 80);

    refresh_screen();
    delay(2000);

    close_all_windows();
}
