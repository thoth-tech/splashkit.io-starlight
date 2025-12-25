#include "splashkit.h"
#include <random>

int main()
{
    int random_number = rnd(275, 800);
    open_window("Random Window Width", random_number, 100);

    clear_screen(color_white());
    draw_text("This window is " + std::to_string(current_window_width()) + " pixels wide", color_black(), 20, 20);
    refresh_screen();

    delay(5000);

    close_all_windows();
    return 0;
}