from splashkit import *

open_window("Triangle Barycenter", 800, 600)

tri = triangle_from_coordinates(
    200, 450,
    400, 120,
    620, 450
)

barycenter = triangle_barycenter(tri)

while not quit_requested():
    process_events()

    clear_screen(color_white())

    fill_triangle_record(color_light_blue(), tri)
    draw_triangle_record(color_black(), tri)

    fill_circle(color_red(), barycenter.x, barycenter.y, 8)

    draw_text_no_font_no_size(
        "Triangle Barycenter",
        color_black(),
        20,
        20
    )

    draw_text_no_font_no_size(
        "The red point shows the barycenter of the triangle.",
        color_black(),
        20,
        50
    )

    refresh_screen()

close_all_windows()