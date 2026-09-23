#include "splashkit.h"

int main()
{
    open_window("Red Channel Shades", 700, 450);

    color low_red = rgb_color(30, 80, 120);
    color medium_red = rgb_color(130, 80, 120);
    color high_red = rgb_color(230, 80, 120);

    clear_screen(color_white());

    fill_rectangle(low_red, 80, 70, 180, 80);
    draw_text(
        "Red value: " + std::to_string(red_of(low_red)),
        color_black(),
        300,
        100
    );

    fill_rectangle(medium_red, 80, 180, 180, 80);
    draw_text(
        "Red value: " + std::to_string(red_of(medium_red)),
        color_black(),
        300,
        210
    );

    fill_rectangle(high_red, 80, 290, 180, 80);
    draw_text(
        "Red value: " + std::to_string(red_of(high_red)),
        color_black(),
        300,
        320
    );

    refresh_screen();
    delay(5000);

    close_all_windows();

    return 0;
}