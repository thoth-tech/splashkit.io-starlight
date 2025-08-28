#include "splashkit.h"
#include <random>

int main()
{
    open_window("Rgba Color", 800, 600);

    // A random number generator is created to provide rgb values
    std::random_device rd;  
    std::mt19937 gen(rd());
    int min = 0;
    int max = 255;
    std::uniform_int_distribution<> dist(min, max);

    int random_red = dist(gen);
    int random_green = dist(gen);
    int random_blue = dist(gen);
    // Function used here ↓
    color color = rgba_color(random_red, random_green, random_blue, 255);
    rectangle rectangle = rectangle_from(200, 100, 400, 300);

    clear_screen(color_white());
    fill_rectangle(color, rectangle);
    draw_text("Current color details: R-" + std::to_string(random_red) + ", G-" + std::to_string(random_green) + ", B-" + std::to_string(random_blue), color_black(), 235, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}