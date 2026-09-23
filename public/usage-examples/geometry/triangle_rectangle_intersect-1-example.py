from splashkit import *

open_window("Triangle Rectangle Intersect Example", 800, 600)

rect_x = 300
rect_y = 220
rect_width = 200
rect_height = 160

target_rect = rectangle_from(
    rect_x,
    rect_y,
    rect_width,
    rect_height
)

while not quit_requested():
    process_events()

    mx = mouse_x()
    my = mouse_y()

    x1 = mx
    y1 = my - 60

    x2 = mx - 60
    y2 = my + 50

    x3 = mx + 60
    y3 = my + 50

    moving_triangle = triangle_from(
        point_at(x1, y1),
        point_at(x2, y2),
        point_at(x3, y3)
    )

    intersects = triangle_rectangle_intersect(
        moving_triangle,
        target_rect
    )

    clear_screen(color_white())

    # Fixed rectangle
    fill_rectangle(
        color_gray(),
        rect_x,
        rect_y,
        rect_width,
        rect_height
    )

    draw_rectangle(
        color_black(),
        rect_x,
        rect_y,
        rect_width,
        rect_height
    )

    # Moving triangle
    if intersects:
        fill_triangle(
            color_red(),
            x1,
            y1,
            x2,
            y2,
            x3,
            y3
        )
    else:
        fill_triangle(
            color_blue(),
            x1,
            y1,
            x2,
            y2,
            x3,
            y3
        )

    draw_triangle(
        color_black(),
        x1,
        y1,
        x2,
        y2,
        x3,
        y3
    )

    draw_text_no_font_no_size(
        "Move the triangle with your mouse",
        color_black(),
        230,
        40
    )

    if intersects:
        draw_text_no_font_no_size(
            "Intersection detected!",
            color_red(),
            300,
            520
        )
    else:
        draw_text_no_font_no_size(
            "No intersection",
            color_black(),
            330,
            520
        )

    refresh_screen_with_target_fps(60)

close_all_windows()
