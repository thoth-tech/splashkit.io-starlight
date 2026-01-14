from splashkit import *
import time

# Open the gameplay window 
window = open_window("Dodge the Bouncing Balls", 800, 600)

# Initialize player and enemy circles 
player_circle = circle_at_from_points(400, 300, 20)
enemy_circle_1 = circle_at_from_points(100, 100, 30)
enemy_circle_2 = circle_at_from_points(700, 500, 30)

# Assign initial velocities to make enemies bounce off the window edges
enemy_dx_1, enemy_dy_1 = 3, 2
enemy_dx_2, enemy_dy_2 = -2, -3

# Run the main game loop until the player quits or a collision occurs
while not quit_requested():
    process_events()

    # Update player position based on arrow key inputs
    if key_down(KeyCode.left_key):
        player_circle.center.x -= 5
    if key_down(KeyCode.right_key):
        player_circle.center.x += 5
    if key_down(KeyCode.up_key):
        player_circle.center.y -= 5
    if key_down(KeyCode.down_key):
        player_circle.center.y += 5

    # Move enemy 1 and bounce off the edges of the window
    enemy_circle_1.center.x += enemy_dx_1
    enemy_circle_1.center.y += enemy_dy_1
    if (enemy_circle_1.center.x < circle_radius(enemy_circle_1) or
        enemy_circle_1.center.x > screen_width() - circle_radius(enemy_circle_1)):
        enemy_dx_1 = -enemy_dx_1
    if (enemy_circle_1.center.y < circle_radius(enemy_circle_1) or
        enemy_circle_1.center.y > screen_height() - circle_radius(enemy_circle_1)):
        enemy_dy_1 = -enemy_dy_1

    # Move enemy 2 and bounce off the edges of the window
    enemy_circle_2.center.x += enemy_dx_2
    enemy_circle_2.center.y += enemy_dy_2
    if (enemy_circle_2.center.x < circle_radius(enemy_circle_2) or
        enemy_circle_2.center.x > screen_width() - circle_radius(enemy_circle_2)):
        enemy_dx_2 = -enemy_dx_2
    if (enemy_circle_2.center.y < circle_radius(enemy_circle_2) or
        enemy_circle_2.center.y > screen_height() - circle_radius(enemy_circle_2)):
        enemy_dy_2 = -enemy_dy_2

    # Render player and enemy circles on screen
    clear_screen(color_white())
    fill_circle(color_green(), player_circle.center.x, player_circle.center.y, circle_radius(player_circle))
    fill_circle(color_red(), enemy_circle_1.center.x, enemy_circle_1.center.y, circle_radius(enemy_circle_1))
    fill_circle(color_red(), enemy_circle_2.center.x, enemy_circle_2.center.y, circle_radius(enemy_circle_2))
    refresh_screen_with_target_fps(60)

    # Display "Game Over" and exit if a collision is detected
    if circles_intersect(player_circle, enemy_circle_1) or circles_intersect(player_circle, enemy_circle_2):
        clear_screen(color_white())
        draw_text("Game Over", color_black(), "default", 24, 350, 280)
        refresh_screen_with_target_fps(60)

        time.sleep(2)
        break

# Close window
close_window(window)
