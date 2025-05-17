#include "splashkit.h"

int main()
{
    open_window("Font Style", 800, 60);
    load_font("Arial", "Arial.TTF");

    // Default instructions
    string instructions = "Press N for Normal, B for Bold, I for Italics, or U for Underlined.";

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

        // Clear screen and draw updated instructions
        clear_screen(COLOR_WHITE);
        draw_text(instructions, COLOR_BLACK, "Arial", 20, 50, 20);
        // Refresh the window with the updated text
        refresh_screen();
    }

    delay(5000);
    close_all_windows();
}