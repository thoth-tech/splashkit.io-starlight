from splashkit import *

# Build the Json from text, so the example needs no resource files
basket = json_from_string('{"fruits": ["apple", "banana", "cherry", "mango"]}')

# The function fills a list that we create empty first
fruits = []
json_read_array_of_string(basket, "fruits", fruits)

fruit_count = len(fruits)

open_window("Fruit Basket", 520, 360)

while not quit_requested():
    process_events()
    clear_screen_to_white()

    draw_text_font_as_string("Fruits in the basket", color_black(), "arial", 30, 30, 25)

    for index in range(fruit_count):
        draw_text_font_as_string(f"{index + 1}. {fruits[index]}", color_black(), "arial", 24, 30, 85 + index * 40)

    refresh_screen_with_target_fps(60)

free_json(basket)
close_all_windows()
