#include "splashkit.h"

int main()
{
    // Build the Json from text, so the example needs no resource files
    json basket = json_from_string("{\"fruits\": [\"apple\", \"banana\", \"cherry\", \"mango\"]}");

    // The function fills a list that we create empty first
    vector<string> fruits;
    json_read_array(basket, "fruits", fruits);

    int fruit_count = fruits.size();

    open_window("Fruit Basket", 520, 360);

    while (!quit_requested())
    {
        process_events();
        clear_screen(COLOR_WHITE);

        draw_text("Fruits in the basket", COLOR_BLACK, "arial", 30, 30, 25);

        for (int index = 0; index < fruit_count; index++)
        {
            draw_text(std::to_string(index + 1) + ". " + fruits[index], COLOR_BLACK, "arial", 24, 30, 85 + index * 40);
        }

        refresh_screen(60);
    }

    free_json(basket);
    close_all_windows();
    return 0;
}
