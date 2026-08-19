from splashkit import *

open_window("Rectangle Intersection Demo", 800, 600)

fixed_rectangle = rectangle_from(300, 220, 200, 120)

while not quit_requested():
    process_events()

    # Move the second rectangle with the mouse to test for intersections.
    movable_rectangle = rectangle_from(
        mouse_x() - 75,
        mouse_y() - 50,
        150,
        100
    )

    # Check whether the two rectangles intersect.
    is_intersecting = rectangles_intersect(
        fixed_rectangle,
        movable_rectangle
    )

    clear_screen(color_white())

    if is_intersecting:
        fill_rectangle_record(color_red(), fixed_rectangle)
        fill_rectangle_record(color_red(), movable_rectangle)

        draw_text_no_font_no_size(
            "Rectangles are intersecting.",
            color_black(),
            240,
            60
        )
    else:
        fill_rectangle_record(color_blue(), fixed_rectangle)
        fill_rectangle_record(color_green(), movable_rectangle)

        draw_text_no_font_no_size(
            "Move the green rectangle with the mouse.",
            color_black(),
            185,
            60
        )

    refresh_screen_with_target_fps(60)

close_all_windows()