from splashkit import *

# Build the Json from text, so the example needs no resource files
progress = json_from_string('{"badges": [true, false, true, true, false]}')

# The function fills a list that we create empty first
badges = []
json_read_array_of_bool(progress, "badges", badges)

# Count the unlocked badges once, because the list never changes
badge_count = len(badges)
unlocked_count = 0

for index in range(badge_count):
    if badges[index]:
        unlocked_count += 1

open_window("Badge Board", 520, 360)

while not quit_requested():
    process_events()
    clear_screen_to_white()

    draw_text_font_as_string("Your badges", color_black(), "arial", 30, 30, 25)

    for index in range(badge_count):
        if badges[index]:
            draw_text_font_as_string(f"Badge {index + 1}: unlocked", color_dark_green(), "arial", 24, 30, 85 + index * 40)
        else:
            draw_text_font_as_string(f"Badge {index + 1}: locked", color_gray(), "arial", 24, 30, 85 + index * 40)

    draw_text_font_as_string(f"Unlocked: {unlocked_count} of {badge_count}", color_black(), "arial", 26, 30, 310)

    refresh_screen_with_target_fps(60)

free_json(progress)
close_all_windows()
