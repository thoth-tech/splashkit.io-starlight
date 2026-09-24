from splashkit import *


open_window("Moving Triangle Intersection", 800, 600)

fixed_x1 = 250
fixed_y1 = 200
fixed_x2 = 400
fixed_y2 = 150
fixed_x3 = 350
fixed_y3 = 350

fixed_triangle = triangle_from(
    point_at(fixed_x1, fixed_y1),
    point_at(fixed_x2, fixed_y2),
    point_at(fixed_x3, fixed_y3)
)

while not quit_requested():
    process_events()

    mouse_point = mouse_position()

    moving_x1 = mouse_point.x
    moving_y1 = mouse_point.y - 60
    moving_x2 = mouse_point.x - 60
    moving_y2 = mouse_point.y + 40
    moving_x3 = mouse_point.x + 60
    moving_y3 = mouse_point.y + 40

    moving_triangle = triangle_from(
        point_at(moving_x1, moving_y1),
        point_at(moving_x2, moving_y2),
        point_at(moving_x3, moving_y3)
    )

    clear_screen(color_white())

    draw_triangle(
        color_blue(),
        fixed_x1,
        fixed_y1,
        fixed_x2,
        fixed_y2,
        fixed_x3,
        fixed_y3
    )

    if triangles_intersect(fixed_triangle, moving_triangle):
        draw_triangle(
            color_red(),
            moving_x1,
            moving_y1,
            moving_x2,
            moving_y2,
            moving_x3,
            moving_y3
        )

        draw_text_font_as_string(
            "The triangles intersect",
            color_red(),
            "Arial",
            24,
            250,
            50
        )
    else:
        draw_triangle(
            color_green(),
            moving_x1,
            moving_y1,
            moving_x2,
            moving_y2,
            moving_x3,
            moving_y3
        )

        draw_text_font_as_string(
            "The triangles do not intersect",
            color_green(),
            "Arial",
            24,
            220,
            50
        )

    refresh_screen_with_target_fps(60)

close_all_windows()
