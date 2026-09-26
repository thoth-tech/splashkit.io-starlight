from splashkit import *


open_window("World Point to Screen Position", 800, 600)

# Position the camera away from the origin so the translation is visible.
move_camera_to(150, 100)

world_point = point_at(500, 350)
world_to_screen = vector_world_to_screen()

# Apply the returned vector to map the world point onto the screen.
screen_point = point_at(
    world_point.x + world_to_screen.x,
    world_point.y + world_to_screen.y
)

screen_options = option_to_screen()

while not quit_requested():
    process_events()
    clear_screen(color_white())

    # Draw the world point normally so it is affected by the camera.
    fill_circle(
        color_blue(),
        world_point.x,
        world_point.y,
        30
    )

    # Draw the calculated screen point without applying the camera again.
    draw_circle_with_options(
        color_red(),
        screen_point.x,
        screen_point.y,
        40,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "Vector World To Screen",
        color_black(),
        20,
        20,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "Camera position: (150, 100)",
        color_black(),
        20,
        55,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "World point: " + point_to_string(world_point),
        color_black(),
        20,
        85,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "Translation vector: " + vector_to_string(world_to_screen),
        color_black(),
        20,
        115,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "Calculated screen point: " + point_to_string(screen_point),
        color_black(),
        20,
        145,
        screen_options
    )

    draw_text_no_font_no_size_with_options(
        "The matching circles confirm the coordinate conversion.",
        color_black(),
        20,
        175,
        screen_options
    )

    refresh_screen_with_target_fps(60)

close_all_windows()