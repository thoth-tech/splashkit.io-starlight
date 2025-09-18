#include "splashkit.h"
#include <random>

int main()
{
    int random_number = rnd(100, 800);

    open_window("Random Window Height", 275, random_number);

    clear_screen(color_white());
    draw_text("This window is " + std::to_string(current_window_height()) + " pixels tall", color_black(), 20, 20);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}