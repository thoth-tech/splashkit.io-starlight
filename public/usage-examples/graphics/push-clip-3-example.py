from splashkit import *

window = open_window("Push Clip Example", 800, 600)


clip_rect = rectangle_from(400, 100, 200, 400)
push_clip(clip_rect)

corner_clip_rect = rectangle_from(200, 300, 400, 200)
push_clip(corner_clip_rect)

clear_screen(color_white())
fill_circle(color_red(), 400, 300, 200)
refresh_screen()

delay(4000)  

close_window(window)
