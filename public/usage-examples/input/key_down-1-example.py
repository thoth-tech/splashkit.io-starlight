from splashkit import *


def draw_key_state(key_name, is_pressed, x, y):
    if is_pressed:
        circle_color = Color.GREEN
    else:
        circle_color = Color.GRAY

    fill_circle(circle_color, x + 15, y + 15, 15)
    draw_circle(Color.BLACK, x + 15, y + 15, 15)

    if is_pressed:
        draw_text(key_name + ": Pressed", Color.BLACK, x + 40, y)
    else:
        draw_text(key_name + ": Released", Color.BLACK, x + 40, y)


open_window("Live Key Press Display", 800, 400)

while not quit_requested():
    process_events()

    space_pressed = key_down(SPACE_KEY)
    left_pressed = key_down(LEFT_KEY)
    right_pressed = key_down(RIGHT_KEY)
    up_pressed = key_down(UP_KEY)
    down_pressed = key_down(DOWN_KEY)

    clear_screen(Color.WHITE)

    draw_text("Hold the keys to see their current state.", Color.BLACK, 20, 20)

    draw_key_state("Space", space_pressed, 20, 80)
    draw_key_state("Left", left_pressed, 20, 130)
    draw_key_state("Right", right_pressed, 20, 180)
    draw_key_state("Up", up_pressed, 20, 230)
    draw_key_state("Down", down_pressed, 20, 280)

    refresh_screen(60)

close_all_windows()