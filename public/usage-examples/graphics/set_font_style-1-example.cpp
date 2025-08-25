#include "splashkit.h"

int main()
{
    open_window("Set Font Style", 800, 600);

    // Different fonts can be added to the fonts folder and used below ↓
    font font = font_named("Century.ttf");
    rectangle rectangle = rectangle_from(100, 200, 150, 30);

    while (!quit_requested())
    {
        process_events();

        if (reading_text() == 0)
        {
            start_reading_text(rectangle);
        }

        // Function used here ↓
        if (text_input() == "1")
        {
            set_font_style(font, BOLD_FONT);
        }
        else if (text_input() == "2")
        {
            set_font_style(font, ITALIC_FONT);
        }
        else if (text_input() == "3")
        {
            set_font_style(font, UNDERLINE_FONT);
        }
        else
        {
            set_font_style(font, NORMAL_FONT);
        }

        clear_screen(color_white());
        draw_text("Please select your desired font style (type numbers 1-3):", color_black(), font, 15, 100, 60);
        draw_text("1 - Bold", color_black(), font, 15, 100, 90);
        draw_text("2 - Italic", color_black(), font, 15, 100, 120);
        draw_text("3 - Underline", color_black(), font, 15, 100, 150);
        draw_rectangle(color_black(), 100, 200, 150, 30);
        draw_text(text_input(), color_black(), 110, 210);
        refresh_screen();
    }
    close_all_windows();
    return 0;
}