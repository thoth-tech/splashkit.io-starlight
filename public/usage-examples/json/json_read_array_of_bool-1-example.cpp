#include "splashkit.h"

int main()
{
    // Build the Json from text, so the example needs no resource files
    json progress = json_from_string("{\"badges\": [true, false, true, true, false]}");

    // The function fills a list that we create empty first
    vector<bool> badges;
    json_read_array(progress, "badges", badges);

    // Count the unlocked badges once, because the list never changes
    int badge_count = badges.size();
    int unlocked_count = 0;

    for (int index = 0; index < badge_count; index++)
    {
        if (badges[index])
        {
            unlocked_count++;
        }
    }

    open_window("Badge Board", 520, 360);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Your badges", COLOR_BLACK, "arial", 30, 30, 25);

        for (int index = 0; index < badge_count; index++)
        {
            if (badges[index])
            {
                draw_text("Badge " + std::to_string(index + 1) + ": unlocked", COLOR_DARK_GREEN, "arial", 24, 30, 85 + index * 40);
            }
            else
            {
                draw_text("Badge " + std::to_string(index + 1) + ": locked", COLOR_GRAY, "arial", 24, 30, 85 + index * 40);
            }
        }

        draw_text("Unlocked: " + std::to_string(unlocked_count) + " of " + std::to_string(badge_count), COLOR_BLACK, "arial", 26, 30, 310);

        refresh_screen(60);
    }

    free_json(progress);
    close_all_windows();
    return 0;
}
