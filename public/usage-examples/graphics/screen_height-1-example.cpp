#include "splashkit.h"

int main()
{
    open_window("Screen Height", 800, 600);

    int height = screen_height();
    string text = "The screen is " + std::to_string(height) + " pixels tall";

    clear_screen(color_white());
    fill_rectangle(color_black(), screen_width() / 2, 0, 1, height);
    draw_text("^", color_black(), screen_width() / 2 - 3, 0);
    draw_text("V", color_black(), screen_width() / 2 - 3, height - 8);
    draw_text(text, color_black(), screen_width() / 2 + 20, screen_height() / 2);
    refresh_screen();

    delay(5000);
    close_all_windows();
    return 0;
}