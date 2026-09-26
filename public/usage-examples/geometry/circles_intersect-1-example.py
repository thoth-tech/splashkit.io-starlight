from splashkit import *

open_window("Circle Intersection Demo", 800, 600)

fixed_circle = circle_at_from_points(350, 280, 100)

while not quit_requested():
    process_events()

    # Move the second circle with the mouse to test for intersections.
    movable_circle = circle_at_from_points(
        mouse_x(),
        mouse_y(),
        70
    )

    # Check whether the two circles intersect.
    is_intersecting = circles_intersect(fixed_circle, movable_circle)

    clear_screen(color_white())

    if is_intersecting:
        fill_circle_record(color_red(), fixed_circle)
        fill_circle_record(color_red(), movable_circle)
        draw_text_no_font_no_size(
            "Circles are intersecting!",
            color_black(),
            20,
            20
        )
    else:
        fill_circle_record(color_blue(), fixed_circle)
        fill_circle_record(color_green(), movable_circle)
        draw_text_no_font_no_size(
            "Circles are not intersecting.",
            color_black(),
            20,
            20
        )

    draw_text_no_font_no_size(
        "Move the mouse-controlled circle over the fixed circle.",
        color_black(),
        20,
        550
    )

    refresh_screen_with_target_fps(60)

close_all_windows()