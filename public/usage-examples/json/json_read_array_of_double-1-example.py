from splashkit import *

# Build the Json from text, so the example needs no resource files
weather = json_from_string('{"temperatures": [18.5, 21.5, 19.5, 22.5]}')

# The function fills a list that we create empty first
temperatures = []
json_read_array_of_double(weather, "temperatures", temperatures)

# The readings never change, so add them up once instead of every frame
temperature_count = len(temperatures)
total = 0

for index in range(temperature_count):
    total += temperatures[index]

average = total / temperature_count

open_window("Temperature Log", 520, 360)

while not quit_requested():
    process_events()
    clear_screen_to_white()

    draw_text_font_as_string("Recent temperatures", color_black(), "arial", 30, 30, 25)

    for index in range(temperature_count):
        draw_text_font_as_string(f"Day {index + 1}: {temperatures[index]} C", color_black(), "arial", 24, 30, 85 + index * 40)

    draw_text_font_as_string(f"Average: {average} C", color_black(), "arial", 26, 30, 270)

    refresh_screen_with_target_fps(60)

free_json(weather)
close_all_windows()
