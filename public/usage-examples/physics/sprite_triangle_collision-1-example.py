from splashkit import *

open_window("Move the Sprite into the Triangle", 800, 600)

# Prepare the generated bitmap pixels for collision testing
sprite_bitmap = create_bitmap("blue square", 40, 40)
clear_bitmap(sprite_bitmap, color_blue())
setup_collision_mask(sprite_bitmap)
test_sprite = create_sprite(sprite_bitmap)

collision_area = triangle_from(
    point_at(400, 120),
    point_at(650, 500),
    point_at(150, 500)
)

while not quit_requested():
    process_events()

    # Let the user test the triangle area by moving the sprite
    mouse_location = mouse_position()
    sprite_set_position(test_sprite, mouse_location)

    if sprite_triangle_collision(test_sprite, collision_area):
        triangle_color = color_green()
        status_text = "Collision detected!"
    else:
        triangle_color = color_red()
        status_text = "No collision detected."

    clear_screen_to_white()
    fill_triangle_record(triangle_color, collision_area)
    draw_sprite(test_sprite)
    draw_text_no_font_no_size(
        "Move the blue sprite into the triangle",
        color_black(),
        20,
        20
    )
    draw_text_no_font_no_size(status_text, color_black(), 20, 50)
    refresh_screen_with_target_fps(60)

close_all_windows()
