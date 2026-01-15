#include "splashkit.h"

int main()
{
    display display = display_details(0);
    int width = display_width(display);

    open_window("How Wide is Your Screen?", width, 250);

    font font = font_named("Century.ttf");
    string text = "The display is " + std::to_string(width) + " pixels wide";

    clear_screen(color_white());
    fill_rectangle(color_black(), 0, screen_height() / 2, width, 1);
    draw_text("<", color_black(), -2, screen_height() / 2 - 3);
    draw_text(">", color_black(), width - 6, screen_height() / 2 - 3);
    draw_text(text, color_black(), font, 30, (screen_width() / 2) - (text_width(text, font, 30) / 2), screen_height() / 2 - 60);
    refresh_screen();

    delay(5000);
    close_all_windows();
    return 0;
}