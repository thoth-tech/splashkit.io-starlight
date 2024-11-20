#include "splashkit.h"

int main()
{
    // Variable Declaration
    string click = "Mouse clicked at ";
    string mouse_pos;

    // Open Window
    open_window("point to string", 600, 600);
    clear_screen(COLOR_GHOST_WHITE);

    while(!quit_requested())
    {
        // check for mouse click
        if(mouse_clicked(LEFT_BUTTON))
        { 
            mouse_pos = point_to_string(mouse_position());
            clear_screen(COLOR_GHOST_WHITE);
        }

        // Print mouse position to screen
        draw_text(click + mouse_pos,COLOR_BLACK,100,300);
        process_events();
        refresh_screen();
    }

    return 0;
}