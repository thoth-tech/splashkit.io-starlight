#include "splashkit.h"
#include <random>

int main()
{
    open_window("Draw Rectangle with Random Color", 800, 600);

    // A random number generator is created to provide rgb values
    std::random_device rd;  
    std::mt19937 gen(rd());
    int min = 0;
    int max = 255;
    std::uniform_int_distribution<> dist(min, max);

    int random_red = dist(gen);
    int random_green = dist(gen);
    int random_blue = dist(gen);
    // The function creates a color which is saved to a color variable. In this example a random red, green and blue value is inputted. Alpha/opacity is also set to the maximum
    color color = rgba_color(random_red, random_green, random_blue, 255);
    rectangle rectangle = rectangle_from(200, 100, 400, 300);

    clear_screen(color_white());
    fill_rectangle(color, rectangle);
    // Show RGBA values of the randomly generated color
    draw_text("Current color details: R-" + std::to_string(random_red) + ", G-" + std::to_string(random_green) + ", B-" + std::to_string(random_blue), color_black(), 235, 450);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}