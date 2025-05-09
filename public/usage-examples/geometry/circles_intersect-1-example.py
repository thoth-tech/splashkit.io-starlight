from splashkit import *

# Open a game window
open_window("Avoid the Obstacle", 600, 400)

# Player circle properties
player_x = 300
player_y = 200
player_radius = 30

# Obstacle circle properties
obstacle_x = 100
obstacle_y = 100
obstacle_radius = 30
obstacle_speed_x = 0.3
obstacle_speed_y = 0.3

while not quit_requested():
    process_events()

    # Move the player circle using arrow keys
    if key_down(KeyCode.up_key):
        player_y -= 0.5
    if key_down(KeyCode.down_key):
        player_y += 0.5
    if key_down(KeyCode.left_key):
        player_x -= 0.5
    if key_down(KeyCode.right_key):
        player_x += 0.5

    # Prevent the player from going off-screen (soft wall boundaries)
    if player_x - player_radius < 0:
        player_x = player_radius
    if player_x + player_radius > 600:
        player_x = 600 - player_radius
    if player_y - player_radius < 0:
        player_y = player_radius
    if player_y + player_radius > 400:
        player_y = 400 - player_radius

    # Move the obstacle
    obstacle_x += obstacle_speed_x
    obstacle_y += obstacle_speed_y

    # Bounce the obstacle off window edges
    if obstacle_x - obstacle_radius < 0 or obstacle_x + obstacle_radius > 600:
        obstacle_speed_x *= -1
    if obstacle_y - obstacle_radius < 0 or obstacle_y + obstacle_radius > 400:
        obstacle_speed_y *= -1

    # 🎯 Correct: Create Circle objects before checking collision
    circle_x = circle_at_from_points(player_x, player_y, player_radius)
    circle_y = circle_at_from_points(obstacle_x, obstacle_y, obstacle_radius)

    # Change background color to red if a collision is detected, otherwise white
    if circles_intersect(circle_x, circle_y):
        clear_screen(color_red())
    else:
        clear_screen(color_white())

    # Draw the player and the obstacle
    fill_circle(color_blue(), player_x, player_y, player_radius)
    fill_circle(color_red(), obstacle_x, obstacle_y, obstacle_radius)

    # Refresh screen and delay
    refresh_screen_with_target_fps(60)

# Close the game window
close_all_windows()
