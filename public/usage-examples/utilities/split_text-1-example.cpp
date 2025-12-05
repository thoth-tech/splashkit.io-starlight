#include "splashkit.h"
#include <vector>

color blend_colors(color c1, color c2, double t)
{
    // linear interpolation for RGB channels
    int r = (int)((1 - t) * red_of(c1) + t * red_of(c2));
    int g = (int)((1 - t) * green_of(c1) + t * green_of(c2));
    int b = (int)((1 - t) * blue_of(c1) + t * blue_of(c2));
    return rgb_color(r, g, b);
}

int main()
{
    open_window("Split Text Example", 800, 400);

    // I am defining the text to split
    string text = "apple,banana,carrot";

    // I am splitting the string into parts using SplashKit's split() function
    vector<string> parts = split(text, ',');

    // I am drawing a gradient background manually
    color top = rgb_color(245, 251, 255);
    color bottom = rgb_color(200, 230, 255);

    for (int y = 0; y < 400; y++)
    {
        double t = static_cast<double>(y) / 400.0;
        color blended = blend_colors(top, bottom, t);
        draw_line(blended, 0, y, 800, y);
    }

    draw_text("Original string:", color_dark_blue(), "arial", 20, 60, 50);
    draw_text(text, color_black(), "arial", 20, 280, 50);

    int y = 130;
    for (string s : parts)
    {
        draw_text("Token: " + s, color_black(), "arial", 18, 60, y);
        y += 40;
    }

    draw_text("Press ESC to exit", color_gray(), "arial", 14, 620, 360);

    refresh_screen();

    while (!quit_requested())
    {
        process_events();
        if (key_typed(ESCAPE_KEY)) break;
    }

    close_all_windows();
    return 0;
}
