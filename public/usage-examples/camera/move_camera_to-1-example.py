from splashkit import *

# Open a window
open_window("Move Camera To Example", 800, 600)

# Create a player bitmap and sprite
player_bmp = create_bitmap("player", 40, 40)
clear_bitmap(player_bmp, color_bright_green())
player = create_sprite(player_bmp)

# Position the player further out in the game world
sprite_set_x(player, 1000)
sprite_set_y(player, 1000)

while not quit_requested():
    # Handle input to move the player
    process_events()

    if key_down(KeyCode.left_key):
        sprite_set_x(player, sprite_x(player) - 5)
    if key_down(KeyCode.right_key):
        sprite_set_x(player, sprite_x(player) + 5)
    if key_down(KeyCode.up_key):
        sprite_set_y(player, sprite_y(player) - 5)
    if key_down(KeyCode.down_key):
        sprite_set_y(player, sprite_y(player) + 5)

    # Center camera on player when SPACE is pressed
    if key_typed(KeyCode.space_key):
        # Calculate the top-left position for the camera to center the player
        target_x = sprite_x(player) + sprite_width(player) / 2 - screen_width() / 2
        target_y = sprite_y(player) + sprite_height(player) / 2 - screen_height() / 2
        
        # Move the camera to the calculated point
        move_camera_to(target_x, target_y)

    # Reset camera to origin when M is pressed
    if key_typed(KeyCode.m_key):
        move_camera_to(0, 0)

    # Clear the screen
    clear_screen(color_black())

    # Draw some world markers to visualize the camera move
    fill_rectangle(color_white(), 0, 0, 20, 20)
    draw_text_no_font_no_size("World (0,0)", color_white(), 5, 25)

    fill_rectangle(color_red(), 1000, 1000, 20, 20)
    draw_text_no_font_no_size("World (1000,1000)", color_red(), 1000, 1025)

    # Draw the sprite (automatically uses camera offset)
    draw_sprite(player)

    # Draw HUD (Heads-Up Display) directly to the screen
    fill_rectangle(color_dim_gray(), 0, 0, 260, 80, option_to_screen())
    draw_text_no_font_no_size_with_options(f"Camera Position: {point_to_string(camera_position())}", color_white(), 10, 10, option_to_screen())
    draw_text_no_font_no_size_with_options(f"Player World Pos: ({int(sprite_x(player))}, {int(sprite_y(player))})", color_white(), 10, 30, option_to_screen())
    draw_text_no_font_no_size_with_options("Press SPACE to center on player", color_white(), 10, 50, option_to_screen())
    draw_text_no_font_no_size_with_options("Press M to move camera to (0,0)", color_white(), 10, 65, option_to_screen())

    refresh_screen_with_target_fps(60)

close_all_windows()
