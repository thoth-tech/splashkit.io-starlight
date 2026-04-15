#include "splashkit.h"

void draw_key_status(string label, key_code key, double x, double y)
{
    bool pressed = key_down(key);

    color indicator;
    string state;

    if (pressed)
    {
        indicator = COLOR_GREEN;
        state = "Pressed";
    }
    else
    {
        indicator = COLOR_GRAY;
        state = "Released";
    }

    fill_circle(indicator, x, y, 25);
    draw_text(label + ": " + state, COLOR_BLACK, x + 40, y - 10);
}

int main()
{
    open_window("Keyboard State Display", 800, 400);

    while (!quit_requested())
    {
        process_events();

        clear_screen(COLOR_WHITE);

        draw_text("Press the arrow keys or space bar to see their current state.", COLOR_BLACK, 120, 40);

        draw_key_status("Left", LEFT_KEY, 120, 130);
        draw_key_status("Right", RIGHT_KEY, 120, 190);
        draw_key_status("Up", UP_KEY, 120, 250);
        draw_key_status("Down", DOWN_KEY, 120, 310);
        draw_key_status("Space", SPACE_KEY, 500, 220);

        refresh_screen(60);
    }

    return 0;
}
