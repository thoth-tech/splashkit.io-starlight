#include "splashkit.h"

int main()
{
    open_window("Screen Height", 800, 600);

    int height = screen_height();
    line l = line_from(screen_width() / 2, 0, screen_width() / 2, height);
    string text = "The screen is " + std::to_string(height) + " pixels tall";
    
    clear_screen(color_white());
    draw_line(color_black(), l);
    fill_triangle(color_black(), l.start_point.x, l.start_point.y, l.start_point.x - 10, l.start_point.y + 10, l.start_point.x + 10, l.start_point.y + 10);
    fill_triangle(color_black(), l.end_point.x, l.end_point.y, l.end_point.x + 10, l.end_point.y - 10, l.end_point.x - 10, l.end_point.y - 10);
    draw_text(text, color_black(), screen_width() / 2 + 20, screen_height() / 2);
    refresh_screen();

    delay(5000);
    close_all_windows();
    return 0;
}