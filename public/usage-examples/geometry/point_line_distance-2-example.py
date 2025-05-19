from splashkit import *

WINDOW_WIDTH  = 800
WINDOW_HEIGHT = 600
MAX_DISTANCE  = 50
TITLE         = "Stay Close to the Line"

def main():
    # Open the game window and keep the handle
    game_win = open_window(TITLE, WINDOW_WIDTH, WINDOW_HEIGHT)  # :contentReference[oaicite:0]{index=0}

    # Define the line endpoints
    line_start = point_at(100, 300)
    line_end   = point_at(700, 300)
    # Python binding wants four coords: x1, y1, x2, y2
    path_line  = line_from(
        line_start.x, line_start.y,
        line_end.x,   line_end.y
    )

    # Define the player point
    player = point_at(400, 300)

    # Main game loop: breaks if user clicks the window’s X or we stray too far
    while not window_close_requested(game_win):                # :contentReference[oaicite:1]{index=1}
        process_events()

        # Move the player with arrow keys
        if key_down(KeyCode.up_key):    player.y -= 5
        if key_down(KeyCode.down_key):  player.y += 5
        if key_down(KeyCode.left_key):  player.x -= 5
        if key_down(KeyCode.right_key): player.x += 5

        # Compute distance from player to the line
        distance = point_line_distance(player, path_line)

        # Draw everything
        clear_screen(color_white())
        draw_line(color_black(), line_start.x, line_start.y, line_end.x, line_end.y)
        fill_circle(color_green(), player.x, player.y, 5)

        # Game over condition
        if distance > MAX_DISTANCE:
            draw_text("Game Over - Too Far from the Line", color_red(),"arial", 200, 50)
            refresh_screen()
            delay(2000)
            break

        # Cap frame‐rate at 60 FPS
        refresh_screen(60)

    # Close and free the specific window object
    close_window(game_win)                                      # :contentReference[oaicite:2]{index=2}

if _name_ == "_main_":
    main()