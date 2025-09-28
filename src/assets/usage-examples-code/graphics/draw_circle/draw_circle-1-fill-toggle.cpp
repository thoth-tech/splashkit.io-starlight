// I am showing a circle that can toggle fill, cycle colors, and pulse.
// SPACE toggles fill; C changes color; P pulses; ESC is quitting.

#include "splashkit.h"
#include <cmath>
#include <vector>

int main()
{
    // Window details use descriptive names
    const int window_width = 720, window_height = 405;
    open_window("Circle — fill / color / pulse", window_width, window_height);

    // Circle placement stays centered
    const int center_x = window_width / 2;
    const int center_y = window_height / 2;
    const double base_radius = 80.0;

    // Pleasant color palette
    std::vector<color> palette = {
        rgb_color(100, 149, 237),   // cornflower
        rgb_color(255, 140, 0),     // dark orange
        rgb_color(46, 204, 113),    // emerald
        rgb_color(155, 89, 182),    // amethyst
        rgb_color(241, 196, 15)     // sunflower
    };
    int color_index = 0;

    bool is_filled = false;
    bool is_pulsing = false;
    double time_value = 0.0;

    while (not quit_requested())
    {
        process_events();

        // Controls use clear ifs with braces (no single-line ifs)
        if (key_typed(ESCAPE_KEY))
        {
            break;
        }
        if (key_typed(SPACE_KEY))
        {
            is_filled = not is_filled;
        }
        if (key_typed(C_KEY))
        {
            color_index = (color_index + 1) % static_cast<int>(palette.size());
        }
        if (key_typed(P_KEY))
        {
            is_pulsing = not is_pulsing;
        }

        clear_screen(COLOR_WHITE);

        // Pulse is adding a gentle “breathing” radius
        double radius = base_radius;
        if (is_pulsing)
        {
            radius = base_radius + 12.0 * std::sin(time_value);
            time_value = time_value + 0.07;
        }

        const color circle_color = palette[static_cast<size_t>(color_index)];

        if (is_filled)
        {
            fill_circle(circle_color, center_x, center_y, radius);
            draw_circle(COLOR_BLACK, center_x, center_y, radius); // subtle outline
        }
        else
        {
            draw_circle(circle_color, center_x, center_y, radius);
        }

        // On-window instructions (no terminal output in graphics examples)
        draw_text("SPACE: fill   C: color   P: pulse   ESC: quit",
                  COLOR_NAVY, 16, 16);

        draw_text(is_filled ? "Mode: filled" : "Mode: outline",
                  COLOR_BLACK, 16, 40);

        refresh_screen(60);
    }
    return 0;
}