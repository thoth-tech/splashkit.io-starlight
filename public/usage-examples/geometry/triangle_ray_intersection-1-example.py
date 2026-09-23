from splashkit import *

open_window("Triangle Ray Intersection", 800, 600)

ray_origin = point_at(120, 300)

tri = triangle_from(
    point_at(500, 180),
    point_at(650, 420),
    point_at(420, 420)
)

while not quit_requested():
    process_events()

    mouse = mouse_position()

    heading = vector_to(
        mouse.x - ray_origin.x,
        mouse.y - ray_origin.y
    )

    intersects = triangle_ray_intersection(
        ray_origin,
        heading,
        tri
    )

    clear_screen_to_white()

    if intersects:
        fill_triangle_record(color_green(), tri)

        draw_text_no_font_no_size(
            "Ray intersects the triangle",
            color_green(),
            20,
            20
        )
    else:
        fill_triangle_record(color_red(), tri)

        draw_text_no_font_no_size(
            "Ray does not intersect the triangle",
            color_red(),
            20,
            20
        )

    draw_triangle_record(color_black(), tri)

    draw_circle(
        color_blue(),
        ray_origin.x,
        ray_origin.y,
        6
    )

    ray_length = 1000

    ray_end = point_at(
        ray_origin.x + heading.x * ray_length,
        ray_origin.y + heading.y * ray_length
    )

    draw_line(
        color_blue(),
        ray_origin.x,
        ray_origin.y,
        ray_end.x,
        ray_end.y
    )

    draw_text_no_font_no_size(
        "Move the mouse to change the ray direction",
        color_black(),
        20,
        550
    )

    refresh_screen()

close_all_windows()