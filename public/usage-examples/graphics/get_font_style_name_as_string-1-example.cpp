#include "splashkit.h"

int main()
{
    open_window("Interactive Font Style Changer", 800, 120);
    load_font("Arial", "Arial.TTF");

    // Initialise Default message
    string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
    string message1 = "";
    font_style style = NORMAL_FONT;

    while (!quit_requested())
    {
        process_events();

        // Check key presses and update font style
        if (key_typed(N_KEY))
        {
            set_font_style("Arial", NORMAL_FONT);
        }
        else if (key_typed(B_KEY))
        {
            set_font_style("Arial", BOLD_FONT);
        }
        else if (key_typed(I_KEY))
        {
            set_font_style("Arial", ITALIC_FONT);
        }
        else if (key_typed(U_KEY))
        {
            set_font_style("Arial", UNDERLINE_FONT);
        }

        message1 = "Font style set to ";
        style = get_font_style("Arial");

        // A switch case is needed for c++ as get_font_style returns an enum not a string
        switch (style)
        {
        case NORMAL_FONT:
            message1 += "Normal";
            break;
        case BOLD_FONT:
            message1 += "Bold";
            break;
        case ITALIC_FONT:
            message1 += "Italic";
            break;
        case UNDERLINE_FONT:
            message1 += "Underlined";
            break;
        default:
            message1 += "Unknown";
            break;
        }

        // Clear screen and draw updated message
        clear_screen(COLOR_WHITE);
        draw_text(message, COLOR_BLACK, "Arial", 20, 50, 20);
        draw_text(message1, COLOR_BLACK, "Arial", 20, 50, 80);
        refresh_screen();
    }

    delay(5000);
    close_all_windows();
    return 0;
}