from splashkit import *

open_window("Mouse Wheel Scroll", 800, 600)

x_scroll_counter = 0
y_scroll_counter = 0
font = font_named("Century.ttf")

while not quit_requested():
    x_scroll_counter += mouse_wheel_scroll().x
    y_scroll_counter += mouse_wheel_scroll().y
        
    process_events()
   
    clear_screen_to_white()
    draw_text(str(round(x_scroll_counter)) + ", " + str(round(y_scroll_counter)), color_black(), font, 200, 400 - (text_width(str(round(x_scroll_counter)) + ", " + str(round(y_scroll_counter)), font, 200) / 2), 90)
    draw_text("Reading is affected by moving the scroll wheel", color_black(), font, 15, 248, 400)
    refresh_screen()

close_all_windows()