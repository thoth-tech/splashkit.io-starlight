from splashkit import *

open_window("Sprite Add To Velocity Example", 400, 300)

# Create a small bitmap and draw a circle onto it to act as our sprite
ball_bitmap = create_bitmap("BallBitmap", 30, 30)
fill_circle_on_bitmap(ball_bitmap, color_red(), 15, 15, 15)

# Create the sprite using the bitmap, starting at the center of the window
ball = create_sprite(ball_bitmap)
sprite_set_position(ball, point_at(185, 135))

while not quit_requested():
    process_events()

    clear_screen(color_white())

    # Add a small amount of velocity in the direction of whichever arrow key is held
    if key_down(KeyCode.up_key):
        sprite_add_to_velocity(ball, vector_to(0, -0.05))
    if key_down(KeyCode.down_key):
        sprite_add_to_velocity(ball, vector_to(0, 0.05))
    if key_down(KeyCode.left_key):
        sprite_add_to_velocity(ball, vector_to(-0.05, 0))
    if key_down(KeyCode.right_key):
        sprite_add_to_velocity(ball, vector_to(0.05, 0))

    update_sprite(ball)
    draw_sprite(ball)

    refresh_screen_with_target_fps(60)

close_all_windows()