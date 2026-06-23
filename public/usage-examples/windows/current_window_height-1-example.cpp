#include "splashkit.h"
#include <random>

int main()
{
    // Initiates a random number generator between two points
    static std::mt19937 gen(std::random_device{}());
    static std::uniform_int_distribution<> dist(100, 800);
    open_window("Random Window Height", 275, dist(gen));

    clear_screen(color_white());
    draw_text("This window is " + std::to_string(current_window_height()) + " pixels tall", color_black(), 20, 20);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}