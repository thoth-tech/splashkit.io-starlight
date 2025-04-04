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
    open_window("Font Style", 1100, 120);

    // Load font
    font myFont = load_font("Arial", "arial.ttf");

    // Default message
    std::string message = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

    while (!quit_requested())
    {
        process_events();

        // Check key presses and update font style
        if (key_typed(N_KEY))
        {
            set_font_style(myFont, NORMAL_FONT);
            message = "Font style set to " + font_style_to_string(get_font_style(myFont)) + ". Press B for Bold, I for Italics, or U for Underlined.";
        }
        else if (key_typed(B_KEY))
        {
            set_font_style(myFont, BOLD_FONT);
            message = "Font style set to " + font_style_to_string(get_font_style(myFont)) + ". Press N for Normal, I for Italics, or U for Underlined.";
        }
        else if (key_typed(I_KEY))
        {
            set_font_style(myFont, ITALIC_FONT);
            message = "Font style set to " + font_style_to_string(get_font_style(myFont)) + ". Press N for Normal, B for Bold, or U for Underlined.";
        }
        else if (key_typed(U_KEY))
        {
            set_font_style(myFont, UNDERLINE_FONT);
            message = "Font style set to " + font_style_to_string(get_font_style(myFont)) + ". Press N for Normal, B for Bold, or I for Italics.";
        }

        // Clear screen and draw updated message
        clear_screen(COLOR_WHITE);
        draw_text(message, COLOR_BLACK, myFont, 20, 50, 20);
        // Refresh the window with the updated text
        refresh_screen();
    }

    // Cleanup and close
    delay(5000);
    close_all_windows();
    return 0;
}