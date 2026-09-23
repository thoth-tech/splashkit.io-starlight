from splashkit import *

open_window("Sliding Top Edge", 800, 600)

# Slide the rectangle up and down so the top edge keeps moving
box_y = 100
slide_step = 2

while not quit_requested():
    process_events()
    clear_screen(color_white())

    box = rectangle_from(250, box_y, 300, 200)

    # Ask SplashKit where the top edge sits, then mark it across the window
    top_edge = rectangle_top(box)

    draw_rectangle_record(color_black(), box)
    draw_line(color_red(), 0, top_edge, 800, top_edge)
    draw_text_no_font_no_size(f"Rectangle Top: {int(top_edge)}", color_black(), 50, 50)

    # Turn around at each end so the rectangle stays on screen
    box_y = box_y + slide_step
    if box_y > 300 or box_y < 100:
        slide_step = -slide_step

    refresh_screen_with_target_fps(60)

close_all_windows()
