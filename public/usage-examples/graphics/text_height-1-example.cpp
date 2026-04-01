#include "splashkit.h"

int main()
{
    open_window("Text Height", 800, 600);

    font text_font = font_named("Century.ttf");
    string text_string = "Example text";
    //Change the below value to affect the text's height
    int text_font_size = 100;
    int height = text_height(text_string, text_font, text_font_size);
    line l = line_from(30, 200, 30, 200 + height);
    
    clear_screen(color_white());
    draw_text(text_string, color_black(), text_font, text_font_size, 50, 200);
    draw_line(color_black(), l);
    fill_triangle(color_black(), l.start_point.x, l.start_point.y, l.start_point.x - 7, l.start_point.y + 7, l.start_point.x + 7, l.start_point.y + 7);
    fill_triangle(color_black(), l.end_point.x, l.end_point.y, l.end_point.x + 7, l.end_point.y - 7, l.end_point.x - 7, l.end_point.y - 7);
    draw_text("This text is " + std::to_string(height) + " pixels tall", color_black(), 30, 220 + height);
    refresh_screen();

    delay(5000);
    close_all_windows();
    return 0;
}