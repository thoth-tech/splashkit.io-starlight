from splashkit import *

open_window("Mouse Button Lamp", 800, 600)

while not quit_requested():
    process_events()

    clear_screen(color_white())

    draw_text_no_font_no_size("Hold the left mouse button to turn the lamp red.", color_black(), 20, 20)

    # The lamp stays green while the button is released and turns red for as long as it is held
    if mouse_up(MouseButton.left_button):
        fill_circle(color_green(), 400, 330, 110)
        draw_text_no_font_no_size("Left button: up", color_black(), 20, 60)
    else:
        fill_circle(color_red(), 400, 330, 110)
        draw_text_no_font_no_size("Left button: down", color_black(), 20, 60)

    draw_circle(color_black(), 400, 330, 110)

    refresh_screen_with_target_fps(60)

close_all_windows()
