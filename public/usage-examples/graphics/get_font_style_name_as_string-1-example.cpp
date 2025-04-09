#include "splashkit.h"
#include <iostream>

std::string font_style_to_string(font_style style)
{
    switch (style)
    {
    case NORMAL_FONT:
        return "Normal";
    case BOLD_FONT:
        return "Bold";
    case ITALIC_FONT:
        return "Italic";
    case UNDERLINE_FONT:
        return "Underlined";
    default:
        return "Unknown";
    }
}

int main()
{
    open_window("Font Style", 800, 120);

    // Load font
    font myFont = load_font("Arial", "Arial.TTF");

    // Default message
    std::string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";
    std::string message1 = "";

    while (!quit_requested())
    {
        process_events();

        // Check key presses and update font style
        if (key_typed(N_KEY))
        {
            set_font_style(myFont, NORMAL_FONT);
        }
        else if (key_typed(B_KEY))
        {
            set_font_style(myFont, BOLD_FONT);
        }
        else if (key_typed(I_KEY))
        {
            set_font_style(myFont, ITALIC_FONT);
        }
        else if (key_typed(U_KEY))
        {
            set_font_style(myFont, UNDERLINE_FONT);
        }

        message1 = "Font style set to " + font_style_to_string(get_font_style(myFont));

        // Clear screen and draw updated message
        clear_screen(COLOR_WHITE);
        draw_text(message, COLOR_BLACK, myFont, 20, 50, 20);
        draw_text(message1, COLOR_BLACK, myFont, 20, 50, 80);
        // Refresh the window with the updated text
        refresh_screen();
    }

    delay(5000);
    close_all_windows();
    return 0;
}