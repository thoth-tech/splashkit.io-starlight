from splashkit import *

open_window("Tracking the Center Point", 800, 600)

# Slide the rectangle diagonally so the center point keeps moving
box_x = 150
box_y = 100
slide_step = 2

while not quit_requested():
    process_events()
    clear_screen(color_white())

    box = rectangle_from(box_x, box_y, 300, 200)

    # The center is half the width and half the height in from the corner
    center = rectangle_center(box)

    draw_rectangle_record(color_black(), box)
    fill_circle_at_point(color_red(), center, 8)
    draw_text_no_font_no_size(f"Rectangle Center: ({int(center.x)}, {int(center.y)})", color_black(), 50, 50)

    # Turn around at each end so the rectangle stays on screen
    box_x = box_x + slide_step
    box_y = box_y + slide_step
    if box_x > 350 or box_x < 150:
        slide_step = -slide_step

    refresh_screen_with_target_fps(60)

close_all_windows()
