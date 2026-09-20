from splashkit import *

notes_window = open_window("Presenter Notes", 480, 280)
projector_window = open_window("Projector", 480, 280)

# Place the windows side by side so both stay visible
move_window_to(notes_window, 60, 100)
move_window_to(projector_window, 580, 100)

toggle_count = 0

while not quit_requested():
    process_events()

    # Only the projector goes fullscreen, so the notes stay on the presenter's own screen
    if key_typed(KeyCode.f_key):
        window_toggle_fullscreen(projector_window)
        toggle_count += 1

    clear_window(notes_window, color_white())
    draw_text_on_window_font_as_string(notes_window, "Presenter Notes", color_black(), "arial", 40, 20, 40)
    draw_text_on_window_font_as_string(notes_window, "Press F to toggle the projector", color_dark_gray(), "arial", 20, 20, 130)
    refresh_window(notes_window)

    # Show the count on the projector itself, because the notes are hidden while it fills the screen
    if window_is_fullscreen(projector_window):
        clear_window(projector_window, color_black())
        draw_text_on_window_font_as_string(projector_window, "Big Slide", color_white(), "arial", 40, 20, 40)
        draw_text_on_window_font_as_string(projector_window, f"Toggles so far: {toggle_count}", color_light_gray(), "arial", 30, 20, 120)
    else:
        clear_window(projector_window, color_white())
        draw_text_on_window_font_as_string(projector_window, "Big Slide", color_black(), "arial", 40, 20, 40)
        draw_text_on_window_font_as_string(projector_window, f"Toggles so far: {toggle_count}", color_dark_gray(), "arial", 30, 20, 120)

    refresh_window(projector_window)

close_all_windows()
