from splashkit import *

open_window("Mouse Drag Example", 800, 600)

circle_x = 400
circle_y = 300
circle_radius = 50

dragging = False
was_mouse_down = False

offset_x = 0
offset_y = 0

while not quit_requested():
    process_events()

    mouse = mouse_position()
    left_mouse_down = mouse_down(MouseButton.left_button)

    # Start dragging when the circle is pressed
    if (
        not dragging
        and left_mouse_down
        and not was_mouse_down
        and point_in_circle(
            mouse,
            circle_at_from_points(
                circle_x,
                circle_y,
                circle_radius
            )
        )
    ):
        dragging = True

        offset_x = circle_x - mouse.x
        offset_y = circle_y - mouse.y

    # Move the circle while dragging
    if dragging and left_mouse_down:
        circle_x = mouse.x + offset_x
        circle_y = mouse.y + offset_y

    # Stop dragging when released
    if not left_mouse_down:
        dragging = False

    was_mouse_down = left_mouse_down

    clear_screen(color_white())

    if dragging:
        fill_circle(
            color_red(),
            circle_x,
            circle_y,
            circle_radius
        )
    else:
        fill_circle(
            color_blue(),
            circle_x,
            circle_y,
            circle_radius
        )

    draw_text_no_font_no_size(
        "Click and drag the circle",
        color_black(),
        20,
        20
    )

    refresh_screen_with_target_fps(60)

close_all_windows()