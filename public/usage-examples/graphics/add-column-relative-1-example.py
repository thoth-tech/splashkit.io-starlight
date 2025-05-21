from splashkit import *

def add_column_relative(width, x, container_width, height, col):
    col_width = int(container_width * width)
    fill_rectangle(col, x, 0, col_width, height)
    return x + col_width

open_window("Columns with Increasing Percentage Width", 600, 200)

while not quit_requested():
    process_events()
    clear_screen(Color.White)

    x = 0
    win_width = 600
    win_height = 200

    x = add_column_relative(0.10, x, win_width, win_height, Color.LightBlue)
    x = add_column_relative(0.20, x, win_width, win_height, Color.LightGreen)
    x = add_column_relative(0.30, x, win_width, win_height, Color.Yellow)
    x = add_column_relative(0.40, x, win_width, win_height, Color.Pink)

    draw_text("Columns: 10% | 20% | 30% | 40%", Color.Black, 10, win_height - 30)

    refresh_screen()
