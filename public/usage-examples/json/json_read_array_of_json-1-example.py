from splashkit import *

# Build the Json from text, so the example needs no resource files
scores = json_from_string('{"players": [{"name": "Ada", "score": 120}, {"name": "Grace", "score": 95}, {"name": "Linus", "score": 140}]}')

# Each entry in this list is a Json object of its own
players = []
json_read_array_of_json(scores, "players", players)

player_count = len(players)

open_window("Score Board", 520, 360)

while not quit_requested():
    process_events()
    clear_screen_to_white()

    draw_text_font_as_string("Score board", color_black(), "arial", 30, 30, 25)

    for index in range(player_count):
        # Read the fields from each player like from any other Json object
        player_name = json_read_string(players[index], "name")
        player_score = json_read_number_as_int(players[index], "score")

        draw_text_font_as_string(f"{player_name}: {player_score}", color_black(), "arial", 24, 30, 85 + index * 40)

    refresh_screen_with_target_fps(60)

# Frees the scores and the player objects that were read from it
free_all_json()
close_all_windows()
