from splashkit import *

def main():
    # Load the JSON file
    level_info = json_from_file("level_data.json")

    # Read basic data fields
    level_name = json_read_string(level_info, "level_name")
    difficulty = json_read_integer(level_info, "difficulty")
    theme = json_read_string(level_info, "theme")

    open_window(f"Data-Driven Dungeon: {level_name}", 800, 600)

    while not quit_requested():
        process_events()
        clear_screen(color_black())

        # Display metadata on screen
        draw_text(f"Level Name: {level_name}", color_white(), 20, 20)
        draw_text(f"Difficulty Score: {difficulty}", color_white(), 20, 40)
        draw_text(f"Dungeon Theme: {theme}", color_white(), 20, 60)

        # Access arrays and objects nested inside the JSON
        spawn_points = json_read_array(level_info, "spawn_points")
        for i in range(json_array_size(spawn_points)):
            entry = json_read_object_at_index(spawn_points, i)
            entity_type = json_read_string(entry, "type")
            x = json_read_number(entry, "x")
            y = json_read_number(entry, "y")

            draw_color = color_green() if entity_type == "Player" else color_red()
            fill_rectangle(draw_color, x, y, 32, 32)
            draw_text(entity_type, color_white(), x, y - 15)

        # Iterate through loot array
        loot_items = json_read_array(level_info, "loot")
        for i in range(json_array_size(loot_items)):
            item = json_read_object_at_index(loot_items, i)
            item_name = json_read_string(item, "item")
            x = json_read_number(item, "x")
            y = json_read_number(item, "y")

            fill_circle(color_gold(), x, y, 8)
            draw_text(item_name, color_gold(), x - 20, y - 20)

        refresh_screen_with_target_fps(60)

    # Note: free_json(level_info) is implicitly handled in splashkit-python wrapper but explicit cleanup is good practice
    close_all_windows()

if __name__ == "__main__":
    main()
