from splashkit import *


def draw_window_status(wnd, name):
    # Ask this specific window, using its handle, whether it is fullscreen
    is_fullscreen = window_is_fullscreen(wnd)

    clear_window(wnd, color_white())
    draw_text_on_window_font_as_string(wnd, name, color_black(), "arial", 40, 20, 30)

    if is_fullscreen:
        draw_text_on_window_font_as_string(wnd, "Fullscreen: true", color_black(), "arial", 30, 20, 100)
    else:
        draw_text_on_window_font_as_string(wnd, "Fullscreen: false", color_black(), "arial", 30, 20, 100)

    draw_text_on_window_font_as_string(wnd, "Press L or R to toggle a window", color_dark_gray(), "arial", 20, 20, 170)
    refresh_window(wnd)


left_window = open_window("Left Window", 480, 280)
right_window = open_window("Right Window", 480, 280)

# Place the windows side by side so both stay visible
move_window_to(left_window, 60, 100)
move_window_to(right_window, 580, 100)

while not quit_requested():
    process_events()

    # Each key sends one window in or out of fullscreen
    if key_typed(KeyCode.l_key):
        window_toggle_fullscreen(left_window)

    if key_typed(KeyCode.r_key):
        window_toggle_fullscreen(right_window)

    # Every window reports its own state, so the text stays visible while it fills the screen
    draw_window_status(left_window, "Left Window")
    draw_window_status(right_window, "Right Window")

close_all_windows()
