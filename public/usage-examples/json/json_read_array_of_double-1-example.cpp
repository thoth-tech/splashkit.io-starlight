#include "splashkit.h"

int main()
{
    // Build the Json from text, so the example needs no resource files
    json weather = json_from_string("{\"temperatures\": [18.5, 21.5, 19.5, 22.5]}");

    // The function fills a list that we create empty first
    vector<double> temperatures;
    json_read_array(weather, "temperatures", temperatures);

    // The readings never change, so add them up once instead of every frame
    int temperature_count = temperatures.size();
    double total = 0;

    for (int index = 0; index < temperature_count; index++)
    {
        total += temperatures[index];
    }

    double average = total / temperature_count;

    open_window("Temperature Log", 520, 360);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Recent temperatures", COLOR_BLACK, "arial", 30, 30, 25);

        for (int index = 0; index < temperature_count; index++)
        {
            draw_text("Day " + std::to_string(index + 1) + ": " + to_string(temperatures[index], 1) + " C", COLOR_BLACK, "arial", 24, 30, 85 + index * 40);
        }

        draw_text("Average: " + to_string(average, 1) + " C", COLOR_BLACK, "arial", 26, 30, 270);

        refresh_screen(60);
    }

    free_json(weather);
    close_all_windows();
    return 0;
}
