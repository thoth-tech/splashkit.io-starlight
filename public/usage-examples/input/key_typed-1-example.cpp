#include "splashkit.h"
#include <string>

int main()
{
    open_window("Typed Key Counter", 800, 600);

    int a_count = 0;
    int space_count = 0;
    int enter_count = 0;
    std::string last_typed_key = "None";

    while (!quit_requested())
    {
        process_events();

        // Count each key once when it is first pressed.
        if (key_typed(A_KEY))
        {
            a_count++;
            last_typed_key = "A";
        }

        if (key_typed(SPACE_KEY))
        {
            space_count++;
            last_typed_key = "Space";
        }

        if (key_typed(RETURN_KEY))
        {
            enter_count++;
            last_typed_key = "Enter";
        }

        clear_screen(COLOR_WHITE);

        draw_text("Press A, Space, or Enter.", COLOR_BLACK, 20, 20);
        draw_text("Hold a key down and the count only changes once.", COLOR_BLACK, 20, 50);
        draw_text("Last typed key: " + last_typed_key, COLOR_BLACK, 20, 100);
        draw_text("A count: " + std::to_string(a_count), COLOR_BLACK, 20, 150);
        draw_text("Space count: " + std::to_string(space_count), COLOR_BLACK, 20, 190);
        draw_text("Enter count: " + std::to_string(enter_count), COLOR_BLACK, 20, 230);

        refresh_screen(60);
    }

    return 0;
}