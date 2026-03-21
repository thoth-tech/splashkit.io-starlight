#include "splashkit.h"

void draw_key_status(string label, key_code key, double x, double y)
{
    // Check whether the selected key is currently pressed
    bool pressed = key_down(key);
    color indicator = pressed ? COLOR_GREEN : COLOR_GRAY;
    string state = pressed ? "Pressed" : "Released";

    // Draw the key status indicator and label
    fill_circle(indicator, x, y, 25);
    draw_text(label + ": " + state, COLOR_BLACK, x + 40, y - 10);
}

int main()
{
    // Open the window for the usage example
    open_window("Keyboard State Display", 800, 400);

    while (!window_close_requested("Keyboard State Display"))
    {
        process_events();

        // Draw the background and instructions
        clear_screen(COLOR_WHITE);
        draw_text("Press the arrow keys or space bar to see their current state.", COLOR_BLACK, 120, 40);

        // Draw the live status of each selected key
        draw_key_status("Left", LEFT_KEY, 120, 130);
        draw_key_status("Right", RIGHT_KEY, 120, 190);
        draw_key_status("Up", UP_KEY, 120, 250);
        draw_key_status("Down", DOWN_KEY, 120, 310);
        draw_key_status("Space", SPACE_KEY, 500, 220);

        refresh_screen(60);
    }

    return 0;
}