from splashkit import *


def main():
    SPEED = 3
    PLAYER_RADIUS = 50
    
    circles = [
        circle_at_from_points(150, 150, 130),
        circle_at_from_points(450, 150, 130),
        circle_at_from_points(150, 450, 130),
        circle_at_from_points(450, 450, 130)
    ]
    
    player_circle = circle_at_from_points(300, 300, PLAYER_RADIUS)
    
    

    open_window("Intersecting Circles?", 600, 600)

    while (not quit_requested()):
        process_events()
        if key_down(KeyCode.left_key) and player_circle.center.x > PLAYER_RADIUS:
            player_circle.center.x -= SPEED
        if key_down(KeyCode.right_key) and player_circle.center.x < screen_width() - PLAYER_RADIUS:
            player_circle.center.x += SPEED
        if key_down(KeyCode.up_key) and player_circle.center.y > PLAYER_RADIUS:
            player_circle.center.y -= SPEED
        if key_down(KeyCode.down_key) and player_circle.center.y < screen_height() - PLAYER_RADIUS:
            player_circle.center.y += SPEED
         
        clear_screen(color_white())
        for i in range(0, 4):
            # Check if the player circle has intersected any other circles
            if circles_intersect(player_circle, circles[i]):
                fill_circle_record(color_red(), circles[i])
            else:
                draw_circle_record(color_red(), circles[i])

        fill_circle_record(color_blue(), player_circle)
        delay(60)
        refresh_screen()
    close_all_windows()

if __name__ == "__main__":
    main()
