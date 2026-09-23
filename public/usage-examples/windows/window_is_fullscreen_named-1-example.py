from splashkit import *

# Keep the caption in one variable so the window and the lookups can never disagree
preview_caption = "Preview"

dashboard_window = open_window("Dashboard", 480, 280)
preview_window = open_window(preview_caption, 480, 280)

# Place the windows side by side so both stay visible
move_window_to(dashboard_window, 60, 100)
move_window_to(preview_window, 580, 100)

while not quit_requested():
    process_events()

    # The F key sends the preview window in and out of fullscreen
    if key_typed(KeyCode.f_key):
        window_toggle_fullscreen_named(preview_caption)

    # Look the window up by its caption, so no window handle is needed here
    preview_is_fullscreen = window_is_fullscreen_named(preview_caption)

    # The whole dashboard acts as a status light
    if preview_is_fullscreen:
        clear_window(dashboard_window, color_light_green())
        draw_text_on_window_font_as_string(dashboard_window, "Preview is fullscreen", color_black(), "arial", 30, 20, 60)
    else:
        clear_window(dashboard_window, color_light_gray())
        draw_text_on_window_font_as_string(dashboard_window, "Preview is windowed", color_black(), "arial", 30, 20, 60)

    draw_text_on_window_font_as_string(dashboard_window, "Press F to toggle the preview", color_dark_gray(), "arial", 20, 20, 140)
    refresh_window(dashboard_window)

    clear_window(preview_window, color_light_blue())
    draw_text_on_window_font_as_string(preview_window, "Preview", color_black(), "arial", 40, 20, 40)

    # The preview shows the same answer, because the dashboard is hidden while it fills the screen
    if preview_is_fullscreen:
        draw_text_on_window_font_as_string(preview_window, "Fullscreen: true", color_black(), "arial", 30, 20, 120)
    else:
        draw_text_on_window_font_as_string(preview_window, "Fullscreen: false", color_black(), "arial", 30, 20, 120)

    draw_text_on_window_font_as_string(preview_window, "Press F to toggle", color_dark_gray(), "arial", 20, 20, 190)
    refresh_window(preview_window)

close_all_windows()
