#include "splashkit.h"

int main()
{
    // Open window for the button font 
    open_window("Button Interface Font", 800, 600);

    // Load and register two fonts
    load_font("courier",   "courier.ttf");

    // Use Arial for all interface text (buttons, labels, etc.)
    set_interface_font("courier");

    // Define a button rectangle
    rectangle btn_rect = rectangle_from(300, 250, 200, 60);

    // Main loop: draw the button with our chosen interface font
    while (!quit_requested())
    {
        process_events();

        clear_screen(color_white());

        // Draw a button labeled "Click Me!" using the interface font
        button("Just a button", btn_rect);

        // Render all interface elements
        draw_interface();

        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
