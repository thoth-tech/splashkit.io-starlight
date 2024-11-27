from splashkit import *

open_window("Abstract Mosaic", 800, 600)
for x in range(8):
    for y in range(6):
        fill_triangle(random_color(), x * 100, y * 100, x * 100 + 50, y * 100 + 50, x * 100 + 100, y * 100)
refresh_screen()
delay(5000)
close_all_windows()
