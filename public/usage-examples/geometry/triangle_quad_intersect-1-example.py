from splashkit import *

open_window("Triangle Quad Intersect", 800, 600)

# Create a fixed quad
target_quad = quad_from(
    450, 180,
    650, 180,
    450, 380,
    650, 380
)

while not quit_requested():
    process_events()

    # Get current mouse position
    mouse_pt = mouse_position()
    mx = mouse_pt.x
    my = mouse_pt.y

    # Create a triangle that follows the mouse
    moving_triangle = triangle_from_coordinates(
        mx, my - 60,
        mx - 60, my + 50,
        mx + 60, my + 50
    )

    # Check whether the triangle intersects the quad
    intersects = triangle_quad_intersect(
        moving_triangle,
        target_quad
    )

    clear_screen(color_white())

    # Draw the fixed quad
    fill_quad(color_light_gray(), target_quad)
    draw_quad(color_black(), target_quad)

    # Change triangle colour depending on intersection
    if intersects:
        fill_triangle_record(
            color_red(),
            moving_triangle
        )

        draw_text_no_font_no_size(
            "Triangle intersects the quad!",
            color_red(),
            20,
            20
        )
    else:
        fill_triangle_record(
            color_blue(),
            moving_triangle
        )

        draw_text_no_font_no_size(
            "Move the triangle into the quad",
            color_black(),
            20,
            20
        )

    draw_triangle_record(
        color_black(),
        moving_triangle
    )

    refresh_screen()

close_all_windows()
