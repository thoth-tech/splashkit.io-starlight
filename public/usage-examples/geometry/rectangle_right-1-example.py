from splashkit import *

open_window("Sliding Right Edge", 800, 600)

# Slide the rectangle side to side so the right edge keeps moving
box_x = 150
slide_step = 2

while not quit_requested():
    process_events()
    clear_screen(color_white())

    box = rectangle_from(box_x, 200, 300, 200)

    # The right edge is the left plus the width, so SplashKit works it out for us
    right_edge = rectangle_right(box)

    draw_rectangle_record(color_black(), box)
    draw_line(color_red(), right_edge, 0, right_edge, 600)
    draw_text_no_font_no_size(f"Rectangle Right: {int(right_edge)}", color_black(), 50, 50)

    # Turn around at each end so the rectangle stays on screen
    box_x = box_x + slide_step
    if box_x > 350 or box_x < 150:
        slide_step = -slide_step

    refresh_screen_with_target_fps(60)

close_all_windows()
