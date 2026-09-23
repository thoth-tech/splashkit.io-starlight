from splashkit import *

# The remote only needs the player's caption, so it never has to hold the player's window handle
player_caption = "Video Player"

remote_window = open_window("Remote Control", 480, 280)
player_window = open_window(player_caption, 480, 280)

# Place the windows side by side so both stay visible
move_window_to(remote_window, 60, 100)
move_window_to(player_window, 580, 100)

command_count = 0

while not quit_requested():
    process_events()

    # Pressing F is the remote's fullscreen button, and pressing it again undoes it
    if key_typed(KeyCode.f_key):
        window_toggle_fullscreen_named(player_caption)
        command_count += 1

    clear_window(remote_window, color_white())
    draw_text_on_window_font_as_string(remote_window, "Remote Control", color_black(), "arial", 40, 20, 40)
    draw_text_on_window_font_as_string(remote_window, "Press F to toggle the player", color_dark_gray(), "arial", 20, 20, 130)
    refresh_window(remote_window)

    # Count the commands on the player itself, because the remote is hidden while the player fills the screen
    clear_window(player_window, color_black())
    draw_text_on_window_font_as_string(player_window, "Now Playing", color_white(), "arial", 40, 20, 40)
    draw_text_on_window_font_as_string(player_window, f"Commands received: {command_count}", color_light_gray(), "arial", 30, 20, 120)
    draw_text_on_window_font_as_string(player_window, "Press F to toggle", color_light_gray(), "arial", 20, 20, 190)
    refresh_window(player_window)

close_all_windows()
