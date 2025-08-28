#include "splashkit.h"
#include <random>

int main()
{
    open_window("Random Color", 800, 600);

    // Function used here ↓
    color color = random_color();
    int red_component = red_of(color);
    int green_component = green_of(color);
    int blue_component = blue_of(color);
    int alpha_component = alpha_of(color);
    rectangle rectangle = rectangle_from(200, 100, 400, 300);

    clear_screen(color_white());
    fill_rectangle(color, rectangle);
    draw_text("This random color's RGBA values are: R-" + std::to_string(red_component) + ", G-" + std::to_string(green_component) + ", B-" + std::to_string(blue_component) + ", A-" + std::to_string(alpha_component), color_black(), 160, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}