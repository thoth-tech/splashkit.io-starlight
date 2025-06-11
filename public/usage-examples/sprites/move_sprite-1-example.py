from splashkit import *

open_window("Ball Throw with Mouse", 800, 600)

# Load the ball bitmap
ball_bitmap = load_bitmap("ball", "ball_sprite.png")
ball = create_sprite(ball_bitmap)

# Center the ball on screen
sprite_set_x(ball, 0)
sprite_set_y(ball, 350)

velocity = vector_to(0, 0)

while not quit_requested():
    process_events()

    # Throw the ball toward the mouse when clicked
    if mouse_clicked(MouseButton.left_button):
        ball_pos = sprite_center_point(ball)
        target = mouse_position()
        direction = unit_vector(vector_point_to_point(ball_pos, target))

        velocity = vector_multiply(direction, 8)  # Adjust throw force

    move_sprite_by_vector(ball, velocity)

    clear_screen(color_white())
    draw_sprite(ball)
    refresh_screen_with_target_fps(60)
