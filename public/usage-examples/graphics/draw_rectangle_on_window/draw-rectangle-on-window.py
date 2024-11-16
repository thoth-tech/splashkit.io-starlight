import splashkit

window_width = 800
window_height = 600
rows = 8
cols = 8
rect_size = 60
offset_x = (window_width - cols * rect_size) / 2
offset_y = (window_height - rows * rect_size) / 2

my_window = splashkit.open_window("Checkerboard", window_width, window_height)

while not splashkit.window_close_requested(my_window):
    splashkit.clear_window(my_window, splashkit.color_white())
    
    for r in range(rows):
        for c in range(cols):
            x = offset_x + c * rect_size
            y = offset_y + r * rect_size
            fill_color = splashkit.color_black() if (r + c) % 2 == 0 else splashkit.color_light_gray()
            
            splashkit.fill_rectangle_on_window(my_window, fill_color, x, y, rect_size, rect_size)
            splashkit.draw_rectangle_on_window(my_window, splashkit.color_blue(), x, y, rect_size, rect_size)
    
    splashkit.refresh_window(my_window)

splashkit.close_window(my_window)
