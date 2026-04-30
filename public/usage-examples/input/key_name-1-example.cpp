#include "splashkit.h"

int main()
{
    open_window("Key Name", 800, 600);

    // Store the last key typed from this example's set of demo keys
    key_code last_key = UNKNOWN_KEY;

    while (!quit_requested())
    {
        process_events();

        // Check which demo key was typed and save its key code
        if (key_typed(A_KEY)) last_key = A_KEY;
        if (key_typed(NUM_1_KEY)) last_key = NUM_1_KEY;
        if (key_typed(SPACE_KEY)) last_key = SPACE_KEY;
        if (key_typed(LEFT_KEY)) last_key = LEFT_KEY;
        if (key_typed(RETURN_KEY)) last_key = RETURN_KEY;

        // Draw the instructions and the readable name of the last key
        clear_screen(COLOR_WHITE);
        draw_text("Press A, 1, Space, Left, or Enter", COLOR_BLACK, 150, 220);
        draw_text("Last key: " + key_name(last_key), COLOR_BLUE, 280, 300);
        refresh_screen();
    }

    close_all_windows();
    return 0;
}
