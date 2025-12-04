#include "splashkit.h"

int main()
{
    open_window("Screen Width", 800, 600);

    int width = screen_width();
    string text = "The screen is " + std::to_string(width) + " pixels wide";

    clear_screen(color_white());
    fill_rectangle(color_black(), 0, screen_height() / 2, width, 1);
    draw_text("<", color_black(), -2, screen_height() / 2 - 3);
    draw_text(">", color_black(), width - 6, screen_height() / 2 - 3);
    draw_text(text, color_black(), (width / 2) - (text_width(text, 0, 0) / 2), screen_height() / 2 - 20);
    refresh_screen();

    delay(5000);
    close_all_windows();
    return 0;
}