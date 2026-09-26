from splashkit import *

open_window("Quads Intersect", 800, 600)

fixed_quad = quad_from(
    500, 200,
    470, 380,
    300, 180,
    280, 350
)

while not quit_requested():
    process_events()

    mouse = mouse_position()

    moving_quad = quad_from(
        mouse.x + 60, mouse.y - 45,
        mouse.x + 60, mouse.y + 45,
        mouse.x - 60, mouse.y - 45,
        mouse.x - 60, mouse.y + 45
    )

    intersects = quads_intersect(fixed_quad, moving_quad)

    clear_screen(color_white())

    fill_quad(color_light_gray(), fixed_quad)
    draw_quad(color_black(), fixed_quad)

    if intersects:
        fill_quad(color_red(), moving_quad)
        draw_text_no_font_no_size(
            "Quads intersect: TRUE",
            color_dark_red(),
            20,
            20
        )
    else:
        fill_quad(color_blue(), moving_quad)
        draw_text_no_font_no_size(
            "Quads intersect: FALSE",
            color_black(),
            20,
            20
        )

    draw_quad(color_black(), moving_quad)

    draw_text_no_font_no_size(
        "Move the mouse to test quad intersection",
        color_black(),
        20,
        550
    )

    refresh_screen()
