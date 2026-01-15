#include "splashkit.h"

int main()
{
    open_window("Interactive Font Style Changer", 800, 120);
    font Arial = load_font("Arial", "Arial.TTF");

    // Initialise Default message
    string info_text = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
    string font_text = "";
    font_style style = NORMAL_FONT;

    while (!quit_requested())
    {
        process_events();

        // Check key presses and update font style
        if (key_typed(N_KEY))
        {
            set_font_style(Arial, NORMAL_FONT);
        }
        else if (key_typed(B_KEY))
        {
            set_font_style(Arial, BOLD_FONT);
        }
        else if (key_typed(I_KEY))
        {
            set_font_style(Arial, ITALIC_FONT);
        }
        else if (key_typed(U_KEY))
        {
            set_font_style(Arial, UNDERLINE_FONT);
        }

        font_text = "Font style set to ";
        style = get_font_style(Arial);
        switch (style)
        {
        case NORMAL_FONT:
            font_text += "Normal";
            break;
        case BOLD_FONT:
            font_text += "Bold";
            break;
        case ITALIC_FONT:
            font_text += "Italic";
            break;
        case UNDERLINE_FONT:
            font_text += "Underlined";
            break;
        default:
            font_text += "Unknown";
            break;
        }

        // Clear screen and draw updated message
        clear_screen(COLOR_WHITE);
        draw_text(info_text, COLOR_BLACK, Arial, 20, 50, 20);
        draw_text(font_text, COLOR_BLACK, Arial, 20, 50, 80);
        refresh_screen();
    }

    delay(5000);
    close_all_windows();
    return 0;
}