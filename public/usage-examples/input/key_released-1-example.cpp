#include "splashkit.h"

int main()
{
    open_window("Key Released", 800, 600);

    int release_count = 0;
    string status = "Waiting...";

    while (!quit_requested())
    {
        process_events();

        if (key_down(SPACE_KEY))
        {
            status = "Holding Space...";
        }

        // key_released returns true only once per release event
        if (key_released(SPACE_KEY))
        {
            release_count++;
            status = "Space released!";
        }

        clear_screen(COLOR_WHITE);
        draw_text("Press and hold [SPACE], then release it", COLOR_BLACK, "Arial", 18, 200, 220);
        draw_text("Status: " + status, COLOR_DARK_GRAY, "Arial", 18, 200, 270);
        draw_text("Times released: " + to_string(release_count), COLOR_BLUE, "Arial", 24, 200, 320);
        refresh_screen(60);
    }

    close_all_windows();
    return 0;
}
