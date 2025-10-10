// I am showing a circle that can toggle fill, cycle colors, and pulse.
// I am pressing SPACE to toggle fill; I am pressing C to change color;
// I am pressing P to pulse; I am pressing ESC to quit.

#include "splashkit.h"
#include <cmath>
#include <vector>

int main()
{
    // I am opening a window with an ASCII title.
    const int window_width = 720, window_height = 405;
    open_window("Circle - fill / color / pulse", window_width, window_height);

    // I am keeping the circle centered.
    const int center_x = window_width / 2;
    const int center_y = window_height / 2;
    const double base_radius = 80.0;

    // I am using a small palette to keep the demo friendly.
    std::vector<color> palette = {
        rgb_color(100, 149, 237),  // cornflower
        rgb_color(255, 140, 0),    // dark orange
        rgb_color(46, 204, 113),   // emerald
        rgb_color(155, 89, 182),   // amethyst
        rgb_color(241, 196, 15)    // sunflower
    };
    int color_index = 0;

    // I am tracking fill/pulse state and a time value for pulsing.
    bool is_filled = false;
    bool is_pulsing = false;
    double t = 0.0;

    while (!quit_requested())
    {
        process_events();

        // I am handling the controls.
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(SPACE_KEY))
        {
            is_filled = !is_filled;
        }
        if (key_typed(C_KEY))
        {
            color_index = (color_index + 1) % static_cast<int>(palette.size());
        }
        if (key_typed(P_KEY))
        {
            is_pulsing = !is_pulsing;
        }

        clear_screen(COLOR_WHITE);

        // I am computing a gentle "breathing" radius when pulsing.
        double radius = base_radius;
        if (is_pulsing)
        {
            radius = base_radius + 12.0 * std::sin(t);
            t = t + 0.07;
        }

        const color ink = palette[static_cast<size_t>(color_index)];

        if (is_filled)
        {
            fill_circle(ink, center_x, center_y, radius);
            draw_circle(COLOR_BLACK, center_x, center_y, radius); // I am adding a subtle outline.
        }
        else
        {
            draw_circle(ink, center_x, center_y, radius);
        }

        // I am drawing the HUD (on-window text).
        draw_text("SPACE: fill   C: color   P: pulse   ESC: quit",
                  COLOR_NAVY, 16, 16);
        draw_text(is_filled ? "Mode: filled" : "Mode: outline",
                  COLOR_BLACK, 16, 40);

        refresh_screen(60);
    }
    return 0;
}