#include "splashkit.h"

int main()
{
    // Load the JSON file directly
    json level_info = json_from_file("public/usage-examples/json/level_data.json");

    // Check if JSON loaded successfully
    if (!json_has_key(level_info, "level_name"))
    {
        // Fallback for local execution if path above fails
        free_json(level_info);
        level_info = json_from_file("level_data.json");
    }

    // Reading top-level strings and integers
    string level_name = json_read_string(level_info, "level_name");
    int difficulty = json_read_number_as_int(level_info, "difficulty");
    string theme = json_read_string(level_info, "theme");

    open_window("Data-Driven Dungeon: " + level_name, 800, 600);

    while (!quit_requested())
    {
        process_events();
        clear_screen(color_black());

        // Display Dungeon metadata
        draw_text("Level: " + level_name, color_white(), 20, 20);
        draw_text("Difficulty: " + std::to_string(difficulty), color_white(), 20, 40);
        draw_text("Theme: " + theme, color_white(), 20, 60);

        // Accessing the 'spawn_points' array and looping through objects
        vector<json> spawn_points;
        json_read_array(level_info, "spawn_points", spawn_points);
        for (int i = 0; i < spawn_points.size(); i++)
        {
            json entry = spawn_points[i];
            string type = json_read_string(entry, "type");
            double x = json_read_number(entry, "x");
            double y = json_read_number(entry, "y");

            color draw_color = (type == "Player") ? color_green() : color_red();
            fill_rectangle(draw_color, x, y, 32, 32);
            draw_text(type, color_white(), x, y - 15);
        }

        // Accessing the 'loot' array
        vector<json> loot_list;
        json_read_array(level_info, "loot", loot_list);
        for (int i = 0; i < loot_list.size(); i++)
        {
            json item = loot_list[i];
            string item_name = json_read_string(item, "item");
            double x = json_read_number(item, "x");
            double y = json_read_number(item, "y");

            fill_circle(color_gold(), x, y, 8);
            draw_text(item_name, color_gold(), x - 20, y - 20);
        }

        refresh_screen(60);
    }

    // Clean up
    free_json(level_info);
    close_all_windows();

    return 0;
}
