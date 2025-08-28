#include "splashkit.h"

int main()
{
    open_window("String To Color", 800, 600);
    // Change this string to get different colors 
    string color_hex = "#921e64d9";
    // Function used here ↓
    color color = string_to_color(color_hex);
    int red_component = red_of(color);
    int green_component = green_of(color);
    int blue_component = blue_of(color);
    rectangle rectangle = rectangle_from(200, 100, 400, 300);

    clear_screen(color_white());
    fill_rectangle(color, rectangle);
    draw_text("Current color's RGBA hex value is " + color_hex, color_black(), 235, 450);
    draw_text("It's RGB values are: R-" + std::to_string(red_component) + ", G-" + std::to_string(green_component) + ", B-" + std::to_string(blue_component), color_black(), 235, 470);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}