#include "splashkit.h"

int main()
{
    // Variable Declaration
    string click_message = "Mouse clicked at ";
    string mouse_position_text;

    // Open Window
    open_window("Mouse Clicked Location", 600, 600);
    clear_screen(COLOR_GHOST_WHITE);

    while (!quit_requested())
    {
        // Check for mouse click
        if (mouse_clicked(LEFT_BUTTON))
        { 
            mouse_position_text = point_to_string(mouse_position());
            clear_screen(COLOR_GHOST_WHITE);
        }

        // Print mouse position to screen
        draw_text(click_message + mouse_position_text, COLOR_BLACK, 100, 300);
        process_events();
        refresh_screen();
    }

    close_all_windows();
    return 0;
}
